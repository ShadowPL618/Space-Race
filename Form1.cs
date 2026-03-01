using NAudio.Wave;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Media;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APPR_TheRace_24SD_BPRJ_S2
{
    public partial class Form1 : Form
    {
        // ==================== RACER OBJECTS ====================
        csRacerBase obRacerOne = new csRacerBase();
        csRacerBase obRacerTwo = new csRacerBase();
        csRacerBase obRacerThree = new csRacerBase();
        csRacerBase obRacerFour = new csRacerBase();

        // ==================== STATISTICS VARIABLES ====================
        double racerOneTotalPositions = 0;
        double racerTwoTotalPositions = 0;
        double racerThreeTotalPositions = 0;
        double racerFourTotalPositions = 0;

        double racerOnePrevAverage = 0;
        double racerTwoPrevAverage = 0;
        double racerThreePrevAverage = 0;
        double racerFourPrevAverage = 0;

        int nrOfRaces = 0;

        // ==================== RACE VARIABLES ====================
        int laneLength = 0;
        int finishedPosition = 0;
        bool positionsReset = false;
        int raceTime = 0;
        int minSpeed = 0;
        int maxSpeed = 0;
        int speedChangeCount = 0;  // Track number of speed changes during race

        // ==================== FILE HANDLING VARIABLES ====================
        string relativeFileDirectory = "";

        // ==================== AUDIO OBJECTS ====================
        private IWavePlayer cantinaOutDevice;
        private AudioFileReader cantinaAudioFile;
        SoundPlayer endSound;

        // ==================== STAR WARS QUOTES ====================
        private string[] starWarsQuotes = new string[]
        {
            "\"Do. Or do not. There is no try.\" - Yoda",
            "\"I've got a bad feeling about this...\"",
            "\"May the Force be with you.\"",
            "\"It's a trap!\" - Admiral Ackbar",
            "\"I am one with the Force, the Force is with me.\"",
            "\"The Force will be with you. Always.\" - Obi-Wan",
            "\"Never tell me the odds!\" - Han Solo",
            "\"I find your lack of faith disturbing.\" - Vader",
            "\"This is the way.\" - The Mandalorian",
            "\"That's no moon...\" - Obi-Wan",
            "\"These aren't the droids you're looking for.\"",
            "\"Help me, Obi-Wan Kenobi. You're my only hope.\"",
            "\"I have spoken.\" - Kuiil",
            "\"Your focus determines your reality.\" - Qui-Gon",
            "\"In my experience, there's no such thing as luck.\" - Obi-Wan"
        };

        private Random quoteRandom = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitApplication();
        }

        /// <summary>
        /// Initialize the application on startup
        /// </summary>
        private void InitApplication()
        {
            // Set window title
            this.Text = "Galactic Race - by Juliusz Krajewski - " + obRacerOne.version + " - " + Application.ProductVersion;

            // UI REQUIREMENT: Hide tab headers - navigation only via menu
            tbcMainJkra.Appearance = TabAppearance.FlatButtons;
            tbcMainJkra.ItemSize = new Size(0, 1);
            tbcMainJkra.SizeMode = TabSizeMode.Fixed;
            tbcMainJkra.SelectedIndex = 0;

            // Set file directory
            relativeFileDirectory = Application.StartupPath + "\\..\\..\\doc\\";

            // Initialize audio (finish.wav from Properties folder)
            try
            {
                endSound = new SoundPlayer(Application.StartupPath + "\\..\\..\\Properties\\finish.wav");
            }
            catch
            {
                endSound = new SoundPlayer();
            }

            // Reset all racers to starting positions
            ResetPositionsGest();
        }

        // ==================== HELPER: MP3 PLAYER ====================
        /// <summary>
        /// Plays MP3 sound effects asynchronously without freezing UI
        /// </summary>
        private void PlayMp3Effect(string fileName)
        {
            string path = Application.StartupPath + "\\..\\..\\Properties\\" + fileName;
            if (File.Exists(path))
            {
                Task.Run(() =>
                {
                    try
                    {
                        using (var audioFile = new AudioFileReader(path))
                        using (var outputDevice = new WaveOutEvent())
                        {
                            outputDevice.Init(audioFile);
                            outputDevice.Play();
                            while (outputDevice.PlaybackState == PlaybackState.Playing)
                            {
                                System.Threading.Thread.Sleep(100);
                            }
                        }
                    }
                    catch { /* Sound file missing - continue without sound */ }
                });
            }
        }

        /// <summary>
        /// Get random Star Wars quote for race logging
        /// </summary>
        private string GetRandomStarWarsQuote()
        {
            return starWarsQuotes[quoteRandom.Next(starWarsQuotes.Length)];
        }

        // ==================== MENU HANDLERS ====================

        /// <summary>
        /// Quit the application with confirmation
        /// </summary>
        private void mspMainQuitGest_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("You are about to quit the application, unsaved work might be lost. Continue?",
                "Quit?", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                // Stop music before closing
                if (cantinaOutDevice != null)
                {
                    cantinaOutDevice.Stop();
                    cantinaOutDevice.Dispose();
                }
                if (cantinaAudioFile != null)
                {
                    cantinaAudioFile.Dispose();
                }

                Application.Exit();
            }
        }

        /// <summary>
        /// Navigate to Setup and Statistics tab
        /// </summary>
        private void mspMainViewSetupGest_Click(object sender, EventArgs e)
        {
            tbcMainJkra.SelectedTab = tbpSetupAndStatisticsJkra;
            this.Height = Convert.ToInt32(455 * 0.75) + 21;
            this.Width = Convert.ToInt32(1191 * 0.75) + 10;
        }

        /// <summary>
        /// Navigate to The Race tab
        /// </summary>
        private void mspMainViewTheRaceGest_Click(object sender, EventArgs e)
        {
            tbcMainJkra.SelectedTab = tbpTheRaceJkra;
        }

        /// <summary>
        /// Navigate to Logging tab
        /// </summary>
        private void mspMainViewLoggingGest_Click(object sender, EventArgs e)
        {
            tbcMainJkra.SelectedTab = tbpSetupAndStatisticsJkra;
        }

        /// <summary>
        /// Show about dialog
        /// </summary>
        private void mspMainAboutJkra_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Galactic Race - A Star Wars themed racing simulation.\n\n" +
                "Control 4 racers with different speeds and watch them compete!\n\n" +
                "Features:\n" +
                "• Dynamic speed changes during races\n" +
                "• Star Wars sound effects and music\n" +
                "• Race statistics and logging\n" +
                "• Save/Load race results\n\n" +
                "May the Force be with you!",
                "About Galactic Race", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Show application location
        /// </summary>
        private void msiTheRaceLocate_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Application.StartupPath, "Location of application", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Open PDF user manual
        /// </summary>
        private void mspHelpUserManualJkra_Click(object sender, EventArgs e)
        {
            try
            {
                string pdfPath = Application.StartupPath + "\\..\\..\\doc\\Manual.pdf";
                if (File.Exists(pdfPath))
                {
                    Process.Start(new ProcessStartInfo(pdfPath) { UseShellExecute = true });
                }
                else
                {
                    // Fallback to text manual
                    MessageBox.Show("User Manual:\n\n" +
                        "1. Go to Setup tab and configure racer names and speeds\n" +
                        "2. Click 'Setup Racers' to initialize\n" +
                        "3. Go to The Race tab\n" +
                        "4. Click START! to begin the race\n" +
                        "5. Click Reset to prepare for next race\n\n" +
                        "Use File menu to save/load settings.",
                        "User Manual", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("Could not open Manual.pdf. Please check the doc folder.",
                    "Manual Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // ==================== SETUP HANDLERS ====================

        /// <summary>
        /// Setup all racers with current settings
        /// </summary>
        private void btnSetUpRacers_Click(object sender, EventArgs e)
        {
            try
            {
                // Calculate lane length
                laneLength = pnlFinishLineJkra.Left - (pnlStartPositionsJkra.Left + pnlStartPositionsJkra.Width);

                // Set timer interval
                tmrMain.Interval = string.IsNullOrEmpty(txbTrackSpeedJkra.Text) ? 1 : Convert.ToInt32(txbTrackSpeedJkra.Text);

                // Get speed range
                minSpeed = string.IsNullOrEmpty(txbMinSpeedJkra.Text) ? 900 : Convert.ToInt32(txbMinSpeedJkra.Text);
                maxSpeed = string.IsNullOrEmpty(txbMaxSpeedJkra.Text) ? 1400 : Convert.ToInt32(txbMaxSpeedJkra.Text);

                // Setup all 4 racers
                SetUpRacersGest();

                rtbRaceResultsJkra.AppendText("✓ Racers configured successfully.\n");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error setting up racers: " + ex.Message + "\n\nUsing default values.",
                    "Setup Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                // Set defaults on error
                txbTrackSpeedJkra.Text = "1";
                txbMinSpeedJkra.Text = "900";
                txbMaxSpeedJkra.Text = "1400";
            }
        }

        /// <summary>
        /// Initialize all 4 racers with speeds and calculate step sizes
        /// </summary>
        private void SetUpRacersGest()
        {
            string[] defaultNames = { "Baron Soontir Fel", "Anakin Skywalker", "Luke Skywalker", "Han Solo" };

            var racers = new[] { obRacerOne, obRacerTwo, obRacerThree, obRacerFour };
            var nameBoxes = new[] { txbRacerOneNameJkra, txbRacerTwoNameJkra, txbRacerThreeNameJkra, txbRacerFourNameJkra };
            var speedLabels = new[] { lblRacerOneSpeedJkra, lblRacerTwoSpeedJkra, lblRacerThreeSpeedJkra, lblRacerFourSpeedJkra };
            var stepLabels = new[] { lblRacerOneStepJkra, lblRacerTwoStepJkra, lblRacerThreeStepJkra, lblRacerFourStepJkra };

            for (int i = 0; i < racers.Length; i++)
            {
                racers[i].setSpeed(minSpeed, maxSpeed);
                racers[i].calculateStepSize(laneLength);
                racers[i].racerName = string.IsNullOrEmpty(nameBoxes[i].Text) ? defaultNames[i] : nameBoxes[i].Text;

                speedLabels[i].Text = racers[i].GetTunedRacerSpeed.ToString();
                stepLabels[i].Text = racers[i].GetStepSizePerTick.ToString("F2");
            }

            UpdateSettings();
        }

        /// <summary>
        /// Set default values for track and racer speeds
        /// </summary>
        private void btnDefaultSetup_Click(object sender, EventArgs e)
        {
            // AUDIO: Roger Roger on Default
            PlayMp3Effect("Roger_Roger.mp3");

            txbTrackSpeedJkra.Text = "1";
            txbMinSpeedJkra.Text = "900";
            txbMaxSpeedJkra.Text = "1400";
            cbxDynamicSpeed.Checked = true;

            rtbRaceResultsJkra.AppendText("⚙ Standard settings restored.\n");
        }

        /// <summary>
        /// Update racer names
        /// </summary>
        private void btnUpdateNames_Click(object sender, EventArgs e)
        {
            obRacerOne.racerName = txbRacerOneNameJkra.Text;
            obRacerTwo.racerName = txbRacerTwoNameJkra.Text;
            obRacerThree.racerName = txbRacerThreeNameJkra.Text;
            obRacerFour.racerName = txbRacerFourNameJkra.Text;

            UpdateSettings();
        }

        /// <summary>
        /// Update all GUI elements with current racer data
        /// </summary>
        private void UpdateSettings()
        {
            lblRacerOneName.Text = obRacerOne.racerName;
            lblRacerTwoName.Text = obRacerTwo.racerName;
            lblRacerThreeName.Text = obRacerThree.racerName;
            lblRacerFourName.Text = obRacerFour.racerName;

            txbRacerOneNameJkra.Text = obRacerOne.racerName;
            txbRacerTwoNameJkra.Text = obRacerTwo.racerName;
            txbRacerThreeNameJkra.Text = obRacerThree.racerName;
            txbRacerFourNameJkra.Text = obRacerFour.racerName;
        }

        // ==================== RACE CONTROL ====================

        /// <summary>
        /// Start the race
        /// </summary>
        private void btnStartJkra_Click(object sender, EventArgs e)
        {
            if (positionsReset == true)
            {
                // AUDIO: Ship Start sound
                PlayMp3Effect("Ship_Start.mp3");

                tmrMain.Enabled = true;
                finishedPosition = 0;
                speedChangeCount = 0;  // Reset speed change counter
                nrOfRaces++;
                lblNrOfRacesJkra.Text = nrOfRaces.ToString();

                // Log with Star Wars quote
                rtbRaceResultsJkra.AppendText("\n=== Race " + nrOfRaces + " Started ===\n");
                rtbRaceResultsJkra.AppendText(GetRandomStarWarsQuote() + "\n");
            }
            else
            {
                MessageBox.Show("Please reset the racers first!", "Reset Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Timer tick - update race state
        /// </summary>
        private void tmrMain_Tick(object sender, EventArgs e)
        {
            raceTime++;

            // Safety timeout
            if (raceTime > 10000)
            {
                raceTime = 0;
                tmrMain.Enabled = false;
                MessageBox.Show("Race timeout - something went wrong!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            lblRaceTimeJkra.Text = raceTime.ToString();

            // Speed changes at 1/3 and 2/3 of expected race duration
            if (cbxDynamicSpeed.Checked)
            {
                if (raceTime == 30 && speedChangeCount == 0)
                {
                    ChangeAllRacerSpeeds();
                    speedChangeCount++;
                    rtbRaceResultsJkra.AppendText("⚡ Speed shift #1 at time " + raceTime + "!\n");
                }
                else if (raceTime == 65 && speedChangeCount == 1)
                {
                    ChangeAllRacerSpeeds();
                    speedChangeCount++;
                    rtbRaceResultsJkra.AppendText("⚡ Speed shift #2 at time " + raceTime + "!\n");
                }
            }

            // UI REQUIREMENT: Update real-time speed displays
            lblRacerOneStepActual.Text = obRacerOne.GetTunedRacerSpeed.ToString();
            lblRacerTwoStepActual.Text = obRacerTwo.GetTunedRacerSpeed.ToString();
            lblRacerThreeStepActual.Text = obRacerThree.GetTunedRacerSpeed.ToString();
            lblRacerFourStepActual.Text = obRacerFour.GetTunedRacerSpeed.ToString();

            UpdatePositionsGest();
        }

        /// <summary>
        /// Change speed for all racers while maintaining min/max range
        /// Each racer gets a NEW random speed within the configured range
        /// </summary>
        private void ChangeAllRacerSpeeds()
        {
            // Give each racer a new random speed within the min/max range
            obRacerOne.setSpeed(minSpeed, maxSpeed);
            obRacerOne.calculateStepSize(laneLength);

            obRacerTwo.setSpeed(minSpeed, maxSpeed);
            obRacerTwo.calculateStepSize(laneLength);

            obRacerThree.setSpeed(minSpeed, maxSpeed);
            obRacerThree.calculateStepSize(laneLength);

            obRacerFour.setSpeed(minSpeed, maxSpeed);
            obRacerFour.calculateStepSize(laneLength);

            // Update speed displays on setup screen
            lblRacerOneSpeedJkra.Text = obRacerOne.GetTunedRacerSpeed.ToString();
            lblRacerTwoSpeedJkra.Text = obRacerTwo.GetTunedRacerSpeed.ToString();
            lblRacerThreeSpeedJkra.Text = obRacerThree.GetTunedRacerSpeed.ToString();
            lblRacerFourSpeedJkra.Text = obRacerFour.GetTunedRacerSpeed.ToString();

            lblRacerOneStepJkra.Text = obRacerOne.GetStepSizePerTick.ToString("F2");
            lblRacerTwoStepJkra.Text = obRacerTwo.GetStepSizePerTick.ToString("F2");
            lblRacerThreeStepJkra.Text = obRacerThree.GetStepSizePerTick.ToString("F2");
            lblRacerFourStepJkra.Text = obRacerFour.GetStepSizePerTick.ToString("F2");
        }

        /// <summary>
        /// Update all racer positions
        /// </summary>
        private void UpdatePositionsGest()
        {
            UpdatePosAndFinishRacerOne();
            UpdatePosAndFinishRacerTwo();
            UpdatePosAndFinishRacerThree();
            UpdatePosAndFinishRacerFour();

            FinalizeRaceGest();
        }

        /// <summary>
        /// Update Racer One position and check finish
        /// </summary>
        private void UpdatePosAndFinishRacerOne()
        {
            if (pbxRacerOneJkra.Left > pnlFinishLineJkra.Left)
            {
                if (obRacerOne.racerFinished == false)
                {
                    obRacerOne.racerFinished = true;
                    finishedPosition++;
                    lblRacerOneFinishedPosition.Text = finishedPosition.ToString();

                    // UI REQUIREMENT: Visual finish with color
                    lblRacerOneFinishedPosition.ForeColor = finishedPosition == 1 ? Color.Gold : Color.White;

                    racerOneTotalPositions += finishedPosition;
                    racerOnePrevAverage = Math.Round(racerOneTotalPositions / nrOfRaces, 1);
                    lblRacerOneAverageJkra.Text = racerOnePrevAverage.ToString("F1");

                    lblRacerOneRankUpDownJkra.Text = "✓";
                    lblRacerOneRankUpDownJkra.ForeColor = Color.Green;

                    rtbRaceResultsJkra.AppendText("Position " + finishedPosition + ": " + obRacerOne.racerName +
                        " (Time: " + raceTime + ")\n");
                }
            }
            else
            {
                obRacerOne.calculateCurrentPosition();
                pbxRacerOneJkra.Left = obRacerOne.GetActualPositionInLaneRounded;
                pbxRacerOneTrace.Width = pbxRacerOneJkra.Left - pbxRacerOneTrace.Left;
            }
        }

        /// <summary>
        /// Update Racer Two position and check finish
        /// </summary>
        private void UpdatePosAndFinishRacerTwo()
        {
            if (pbxRacerTwoJkra.Left > pnlFinishLineJkra.Left)
            {
                if (obRacerTwo.racerFinished == false)
                {
                    obRacerTwo.racerFinished = true;
                    finishedPosition++;
                    lblRacerTwoFinishedPosition.Text = finishedPosition.ToString();

                    lblRacerTwoFinishedPosition.ForeColor = finishedPosition == 1 ? Color.Gold : Color.White;

                    racerTwoTotalPositions += finishedPosition;
                    racerTwoPrevAverage = Math.Round(racerTwoTotalPositions / nrOfRaces, 1);
                    lblRacerTwoAverageJkra.Text = racerTwoPrevAverage.ToString("F1");

                    lblRacerTwoRankUpDownJkra.Text = "✓";
                    lblRacerTwoRankUpDownJkra.ForeColor = Color.Green;

                    rtbRaceResultsJkra.AppendText("Position " + finishedPosition + ": " + obRacerTwo.racerName +
                        " (Time: " + raceTime + ")\n");
                }
            }
            else
            {
                obRacerTwo.calculateCurrentPosition();
                pbxRacerTwoJkra.Left = obRacerTwo.GetActualPositionInLaneRounded;
                pbxRacerTwoTrace.Width = pbxRacerTwoJkra.Left - pbxRacerTwoTrace.Left;
            }
        }

        /// <summary>
        /// Update Racer Three position and check finish
        /// </summary>
        private void UpdatePosAndFinishRacerThree()
        {
            if (pbxRacerThreeJkra.Left > pnlFinishLineJkra.Left)
            {
                if (obRacerThree.racerFinished == false)
                {
                    obRacerThree.racerFinished = true;
                    finishedPosition++;
                    lblRacerThreeFinishedPosition.Text = finishedPosition.ToString();

                    lblRacerThreeFinishedPosition.ForeColor = finishedPosition == 1 ? Color.Gold : Color.White;

                    racerThreeTotalPositions += finishedPosition;
                    racerThreePrevAverage = Math.Round(racerThreeTotalPositions / nrOfRaces, 1);
                    lblRacerThreeAverageJkra.Text = racerThreePrevAverage.ToString("F1");

                    lblRacerThreeRankUpDownJkra.Text = "✓";
                    lblRacerThreeRankUpDownJkra.ForeColor = Color.Green;

                    rtbRaceResultsJkra.AppendText("Position " + finishedPosition + ": " + obRacerThree.racerName +
                        " (Time: " + raceTime + ")\n");
                }
            }
            else
            {
                obRacerThree.calculateCurrentPosition();
                pbxRacerThreeJkra.Left = obRacerThree.GetActualPositionInLaneRounded;
                pbxRacerThreeTrace.Width = pbxRacerThreeJkra.Left - pbxRacerThreeTrace.Left;
            }
        }

        /// <summary>
        /// Update Racer Four position and check finish
        /// </summary>
        private void UpdatePosAndFinishRacerFour()
        {
            if (pbxRacerFourJkra.Left > pnlFinishLineJkra.Left)
            {
                if (obRacerFour.racerFinished == false)
                {
                    obRacerFour.racerFinished = true;
                    finishedPosition++;
                    lblRacerFourFinishedPosition.Text = finishedPosition.ToString();

                    lblRacerFourFinishedPosition.ForeColor = finishedPosition == 1 ? Color.Gold : Color.White;

                    racerFourTotalPositions += finishedPosition;
                    racerFourPrevAverage = Math.Round(racerFourTotalPositions / nrOfRaces, 1);
                    lblRacerFourAverageJkra.Text = racerFourPrevAverage.ToString("F1");

                    lblRacerFourRankUpDownJkra.Text = "✓";
                    lblRacerFourRankUpDownJkra.ForeColor = Color.Green;

                    rtbRaceResultsJkra.AppendText("Position " + finishedPosition + ": " + obRacerFour.racerName +
                        " (Time: " + raceTime + ")\n");
                }
            }
            else
            {
                obRacerFour.calculateCurrentPosition();
                pbxRacerFourJkra.Left = obRacerFour.GetActualPositionInLaneRounded;
                pbxRacerFourTrace.Width = pbxRacerFourJkra.Left - pbxRacerFourTrace.Left;
            }
        }

        /// <summary>
        /// Check if race is complete and finalize
        /// </summary>
        private void FinalizeRaceGest()
        {
            if (obRacerOne.racerFinished && obRacerTwo.racerFinished &&
                obRacerThree.racerFinished && obRacerFour.racerFinished)
            {
                tmrMain.Enabled = false;
                positionsReset = false;

                // AUDIO: Finish sound
                try { endSound.Play(); }
                catch { }

                rtbRaceResultsJkra.AppendText("=== Race " + nrOfRaces + " Completed ===\n");
                rtbRaceResultsJkra.AppendText(GetRandomStarWarsQuote() + "\n\n");
            }
        }

        /// <summary>
        /// Reset button - prepare for next race
        /// </summary>
        private void btnResetPositions_Click(object sender, EventArgs e)
        {
            ResetPositionsGest();
            ResetTrace();
            Refresh();
        }

        /// <summary>
        /// Reset all racers to starting positions
        /// </summary>
        private void ResetPositionsGest()
        {
            obRacerOne.racerFinished = false;
            obRacerTwo.racerFinished = false;
            obRacerThree.racerFinished = false;
            obRacerFour.racerFinished = false;

            lblRacerOneFinishedPosition.Text = "---";
            lblRacerTwoFinishedPosition.Text = "---";
            lblRacerThreeFinishedPosition.Text = "---";
            lblRacerFourFinishedPosition.Text = "---";

            lblRacerOneFinishedPosition.ForeColor = Color.White;
            lblRacerTwoFinishedPosition.ForeColor = Color.White;
            lblRacerThreeFinishedPosition.ForeColor = Color.White;
            lblRacerFourFinishedPosition.ForeColor = Color.White;

            obRacerOne.resetPosition(pnlGetSet.Left);
            obRacerTwo.resetPosition(pnlGetSet.Left);
            obRacerThree.resetPosition(pnlGetSet.Left);
            obRacerFour.resetPosition(pnlGetSet.Left);

            pbxRacerOneJkra.Left = pnlGetSet.Left;
            pbxRacerTwoJkra.Left = pnlGetSet.Left;
            pbxRacerThreeJkra.Left = pnlGetSet.Left;
            pbxRacerFourJkra.Left = pnlGetSet.Left;

            positionsReset = true;
            raceTime = 0;
        }

        /// <summary>
        /// Reset visual traces
        /// </summary>
        private void ResetTrace()
        {
            pbxRacerOneTrace.Width = 0;
            pbxRacerTwoTrace.Width = 0;
            pbxRacerThreeTrace.Width = 0;
            pbxRacerFourTrace.Width = 0;
        }

        // ==================== MULTIMEDIA: CANTINA MUSIC ====================

        /// <summary>
        /// Toggle Cantina music looping
        /// </summary>
        private void cbxCantinaMusicJkra_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxCantinaMusicJkra.Checked)
            {
                try
                {
                    string path = Application.StartupPath + "\\..\\..\\Properties\\Cantina_Music.mp3";
                    if (File.Exists(path))
                    {
                        cantinaOutDevice = new WaveOutEvent();
                        cantinaAudioFile = new AudioFileReader(path);
                        cantinaOutDevice.Init(cantinaAudioFile);
                        cantinaOutDevice.Play();

                        // Loop continuously
                        cantinaOutDevice.PlaybackStopped += (s, a) =>
                        {
                            if (cbxCantinaMusicJkra.Checked && cantinaAudioFile != null)
                            {
                                cantinaAudioFile.Position = 0;
                                cantinaOutDevice.Play();
                            }
                        };
                    }
                    else
                    {
                        MessageBox.Show("Cantina_Music.mp3 not found in Properties folder.", "Music Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        cbxCantinaMusicJkra.Checked = false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error playing Cantina music: " + ex.Message, "Audio Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cbxCantinaMusicJkra.Checked = false;
                }
            }
            else
            {
                if (cantinaOutDevice != null)
                {
                    cantinaOutDevice.Stop();
                    cantinaOutDevice.Dispose();
                    cantinaOutDevice = null;
                }
                if (cantinaAudioFile != null)
                {
                    cantinaAudioFile.Dispose();
                    cantinaAudioFile = null;
                }
            }
        }

        // ==================== FILE HANDLING ====================

        /// <summary>
        /// Save race results to file
        /// </summary>
        private void mspFileSaveAsJkra_Click(object sender, EventArgs e)
        {
            try
            {
                diaFileSave.FileName = "RaceResults_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".txt";
                diaFileSave.Filter = "Text file|*.txt|CSV file|*.csv|All files|*.*";

                if (diaFileSave.ShowDialog() == DialogResult.OK)
                {
                    string filepath = diaFileSave.FileName;
                    using (StreamWriter writer = new StreamWriter(filepath, false))
                    {
                        writer.WriteLine("=================================================");
                        writer.WriteLine("      GALACTIC RACE - RESULTS LOG");
                        writer.WriteLine("=================================================");
                        writer.WriteLine("Date: " + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                        writer.WriteLine("Total Races: " + nrOfRaces);
                        writer.WriteLine();
                        writer.WriteLine("----- RACER STATISTICS -----");
                        writer.WriteLine();
                        writer.WriteLine("Racer 1: " + obRacerOne.racerName);
                        writer.WriteLine("  Average Position: " + racerOnePrevAverage.ToString("F1"));
                        writer.WriteLine("  Last Speed: " + obRacerOne.GetTunedRacerSpeed);
                        writer.WriteLine();
                        writer.WriteLine("Racer 2: " + obRacerTwo.racerName);
                        writer.WriteLine("  Average Position: " + racerTwoPrevAverage.ToString("F1"));
                        writer.WriteLine("  Last Speed: " + obRacerTwo.GetTunedRacerSpeed);
                        writer.WriteLine();
                        writer.WriteLine("Racer 3: " + obRacerThree.racerName);
                        writer.WriteLine("  Average Position: " + racerThreePrevAverage.ToString("F1"));
                        writer.WriteLine("  Last Speed: " + obRacerThree.GetTunedRacerSpeed);
                        writer.WriteLine();
                        writer.WriteLine("Racer 4: " + obRacerFour.racerName);
                        writer.WriteLine("  Average Position: " + racerFourPrevAverage.ToString("F1"));
                        writer.WriteLine("  Last Speed: " + obRacerFour.GetTunedRacerSpeed);
                        writer.WriteLine();
                        writer.WriteLine("----- RACE SETTINGS -----");
                        writer.WriteLine("Track Speed: " + txbTrackSpeedJkra.Text);
                        writer.WriteLine("Min Speed: " + txbMinSpeedJkra.Text);
                        writer.WriteLine("Max Speed: " + txbMaxSpeedJkra.Text);
                        writer.WriteLine("Dynamic Speed: " + (cbxDynamicSpeed.Checked ? "Enabled" : "Disabled"));
                        writer.WriteLine();
                        writer.WriteLine("----- RACE LOG -----");
                        writer.WriteLine(rtbRaceResultsJkra.Text);
                        writer.WriteLine();
                        writer.WriteLine("=================================================");
                        writer.WriteLine(GetRandomStarWarsQuote());
                        writer.WriteLine("=================================================");
                    }

                    MessageBox.Show("Results saved successfully to:\n" + filepath, "Save Complete",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    rtbRaceResultsJkra.AppendText("💾 Results saved to file.\n");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving file: " + ex.Message, "Save Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Load race log from file
        /// </summary>
        private void mspFileOpenJkra_Click(object sender, EventArgs e)
        {
            try
            {
                diaFileOpen.Filter = "Text file|*.txt|CSV file|*.csv|All files|*.*";

                if (diaFileOpen.ShowDialog() == DialogResult.OK)
                {
                    string filepath = diaFileOpen.FileName;

                    if (File.Exists(filepath))
                    {
                        rtbRaceResultsJkra.Text = File.ReadAllText(filepath);
                        MessageBox.Show("File loaded successfully:\n" + filepath, "Load Complete",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("File not found.", "Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading file: " + ex.Message, "Load Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
