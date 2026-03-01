using System;
using System.Windows.Forms;

namespace APPR_TheRace_24SD_BPRJ_S2
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tmrMain = new System.Windows.Forms.Timer(this.components);
            this.diaFileSave = new System.Windows.Forms.SaveFileDialog();
            this.diaFileOpen = new System.Windows.Forms.OpenFileDialog();
            this.theRaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mspMainAboutJkra = new System.Windows.Forms.ToolStripMenuItem();
            this.msiTheRaceLocate = new System.Windows.Forms.ToolStripMenuItem();
            this.mspMainQuit = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mspFileSaveAsJkra = new System.Windows.Forms.ToolStripMenuItem();
            this.mspFileOpenJkra = new System.Windows.Forms.ToolStripMenuItem();
            this.mspFileSaveAsCsvJkra = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mspMainViewTheRaceJkra = new System.Windows.Forms.ToolStripMenuItem();
            this.mspMainViewLoggingJkra = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mspHelpUserManualJkra = new System.Windows.Forms.ToolStripMenuItem();
            this.mspMainJkra = new System.Windows.Forms.MenuStrip();
            this.tbpSetupAndStatisticsJkra = new System.Windows.Forms.TabPage();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblRacerFourRankUpDownJkra = new System.Windows.Forms.Label();
            this.lblRacerThreeRankUpDownJkra = new System.Windows.Forms.Label();
            this.lblRacerTwoRankUpDownJkra = new System.Windows.Forms.Label();
            this.lblRacerOneRankUpDownJkra = new System.Windows.Forms.Label();
            this.lblNrOfRacesJkra = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lblRacerFourAverageJkra = new System.Windows.Forms.Label();
            this.lblRacerOneAverageJkra = new System.Windows.Forms.Label();
            this.lblRacerTwoAverageJkra = new System.Windows.Forms.Label();
            this.lblRacerThreeAverageJkra = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnClearRaceResultsJkra = new System.Windows.Forms.Button();
            this.rtbRaceResultsJkra = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnUpdateNamesJkra = new System.Windows.Forms.Button();
            this.btnDefaultSetupJkra = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.btnSetUpRacersJkra = new System.Windows.Forms.Button();
            this.txbMaxSpeedJkra = new System.Windows.Forms.TextBox();
            this.lblRacerOneSpeedJkra = new System.Windows.Forms.Label();
            this.lblRacerTwoSpeedJkra = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.lblRacerFourStepJkra = new System.Windows.Forms.Label();
            this.lblRacerThreeSpeedJkra = new System.Windows.Forms.Label();
            this.txbMinSpeedJkra = new System.Windows.Forms.TextBox();
            this.lblRacerThreeStepJkra = new System.Windows.Forms.Label();
            this.lblRacerFourSpeedJkra = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.lblRacerTwoStepJkra = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblRacerOneStepJkra = new System.Windows.Forms.Label();
            this.cbxDynamicSpeed = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txbTrackSpeedJkra = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txbRacerOneNameJkra = new System.Windows.Forms.TextBox();
            this.txbRacerTwoNameJkra = new System.Windows.Forms.TextBox();
            this.txbRacerFourNameJkra = new System.Windows.Forms.TextBox();
            this.txbRacerThreeNameJkra = new System.Windows.Forms.TextBox();
            this.tbpTheRaceJkra = new System.Windows.Forms.TabPage();
            this.cbxCantinaMusicJkra = new System.Windows.Forms.CheckBox();
            this.lblRacerTwoName = new System.Windows.Forms.Label();
            this.lblRacerFourName = new System.Windows.Forms.Label();
            this.lblRacerOneName = new System.Windows.Forms.Label();
            this.lblRacerThreeName = new System.Windows.Forms.Label();
            this.btnResetPositionsJkra = new System.Windows.Forms.Button();
            this.lblRacerFourStepActual = new System.Windows.Forms.Label();
            this.lblRacerThreeStepActual = new System.Windows.Forms.Label();
            this.lblRacerTwoStepActual = new System.Windows.Forms.Label();
            this.lblRacerOneStepActual = new System.Windows.Forms.Label();
            this.pnlGetSet = new System.Windows.Forms.Panel();
            this.lblRaceTimeJkra = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblRacerFourFinishedPosition = new System.Windows.Forms.Label();
            this.lblRacerThreeFinishedPosition = new System.Windows.Forms.Label();
            this.lblRacerTwoFinishedPosition = new System.Windows.Forms.Label();
            this.lblRacerOneFinishedPosition = new System.Windows.Forms.Label();
            this.btnStartJkra = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlFinishLineJkra = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlStartPositionsJkra = new System.Windows.Forms.Panel();
            this.pbxRacerOneJkra = new System.Windows.Forms.PictureBox();
            this.pbxRacerFourJkra = new System.Windows.Forms.PictureBox();
            this.pbxRacerTwoJkra = new System.Windows.Forms.PictureBox();
            this.pbxRacerThreeJkra = new System.Windows.Forms.PictureBox();
            this.pbxRacerFourTrace = new System.Windows.Forms.PictureBox();
            this.pbxRacerThreeTrace = new System.Windows.Forms.PictureBox();
            this.pbxRacerTwoTrace = new System.Windows.Forms.PictureBox();
            this.pbxRacerOneTrace = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbpStartScreenJkra = new System.Windows.Forms.TabPage();
            this.tbcMainJkra = new System.Windows.Forms.TabControl();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.mspMainJkra.SuspendLayout();
            this.tbpSetupAndStatisticsJkra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tbpTheRaceJkra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxRacerOneJkra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxRacerFourJkra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxRacerTwoJkra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxRacerThreeJkra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxRacerFourTrace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxRacerThreeTrace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxRacerTwoTrace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxRacerOneTrace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tbcMainJkra.SuspendLayout();
            this.SuspendLayout();
            // 
            // tmrMain
            // 
            this.tmrMain.Tick += new System.EventHandler(this.tmrMain_Tick);
            // 
            // diaFileOpen
            // 
            this.diaFileOpen.FileName = "openFileDialog1";
            // 
            // theRaceToolStripMenuItem
            // 
            this.theRaceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mspMainAboutJkra,
            this.msiTheRaceLocate,
            this.mspMainQuit});
            this.theRaceToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.theRaceToolStripMenuItem.Name = "theRaceToolStripMenuItem";
            this.theRaceToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.theRaceToolStripMenuItem.Text = "The Race";
            // 
            // mspMainAboutJkra
            // 
            this.mspMainAboutJkra.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.mspMainAboutJkra.Name = "mspMainAboutJkra";
            this.mspMainAboutJkra.Size = new System.Drawing.Size(140, 22);
            this.mspMainAboutJkra.Text = "About..";
            this.mspMainAboutJkra.Click += new System.EventHandler(this.mspMainAboutJkra_Click);
            // 
            // msiTheRaceLocate
            // 
            this.msiTheRaceLocate.Name = "msiTheRaceLocate";
            this.msiTheRaceLocate.Size = new System.Drawing.Size(140, 22);
            this.msiTheRaceLocate.Text = "Locate";
            this.msiTheRaceLocate.Click += new System.EventHandler(this.msiTheRaceLocate_Click);
            // 
            // mspMainQuit
            // 
            this.mspMainQuit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.mspMainQuit.Name = "mspMainQuit";
            this.mspMainQuit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.mspMainQuit.Size = new System.Drawing.Size(140, 22);
            this.mspMainQuit.Text = "Quit";
            this.mspMainQuit.Click += new System.EventHandler(this.mspMainQuitGest_Click);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mspFileSaveAsJkra,
            this.mspFileOpenJkra,
            this.mspFileSaveAsCsvJkra});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // mspFileSaveAsJkra
            // 
            this.mspFileSaveAsJkra.Name = "mspFileSaveAsJkra";
            this.mspFileSaveAsJkra.Size = new System.Drawing.Size(121, 22);
            this.mspFileSaveAsJkra.Text = "Save..";
            this.mspFileSaveAsJkra.Click += new System.EventHandler(this.mspFileSaveAsJkra_Click);
            // 
            // mspFileOpenJkra
            // 
            this.mspFileOpenJkra.Name = "mspFileOpenJkra";
            this.mspFileOpenJkra.Size = new System.Drawing.Size(121, 22);
            this.mspFileOpenJkra.Text = "Open..";
            this.mspFileOpenJkra.Click += new System.EventHandler(this.mspFileOpenJkra_Click);
            // 
            // mspFileSaveAsCsvJkra
            // 
            this.mspFileSaveAsCsvJkra.Name = "mspFileSaveAsCsvJkra";
            this.mspFileSaveAsCsvJkra.Size = new System.Drawing.Size(121, 22);
            this.mspFileSaveAsCsvJkra.Text = "Save .csv";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mspMainViewTheRaceJkra,
            this.mspMainViewLoggingJkra});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // mspMainViewTheRaceJkra
            // 
            this.mspMainViewTheRaceJkra.Name = "mspMainViewTheRaceJkra";
            this.mspMainViewTheRaceJkra.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F1)));
            this.mspMainViewTheRaceJkra.Size = new System.Drawing.Size(178, 22);
            this.mspMainViewTheRaceJkra.Text = "The Race";
            this.mspMainViewTheRaceJkra.Click += new System.EventHandler(this.mspMainViewTheRaceGest_Click);
            // 
            // mspMainViewLoggingJkra
            // 
            this.mspMainViewLoggingJkra.Name = "mspMainViewLoggingJkra";
            this.mspMainViewLoggingJkra.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F2)));
            this.mspMainViewLoggingJkra.Size = new System.Drawing.Size(178, 22);
            this.mspMainViewLoggingJkra.Text = "Race Setup";
            this.mspMainViewLoggingJkra.Click += new System.EventHandler(this.mspMainViewLoggingGest_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mspHelpUserManualJkra});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F4)));
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // mspHelpUserManualJkra
            // 
            this.mspHelpUserManualJkra.Name = "mspHelpUserManualJkra";
            this.mspHelpUserManualJkra.Size = new System.Drawing.Size(140, 22);
            this.mspHelpUserManualJkra.Text = "User manual";
            this.mspHelpUserManualJkra.Click += new System.EventHandler(this.mspHelpUserManualJkra_Click);
            // 
            // mspMainJkra
            // 
            this.mspMainJkra.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mspMainJkra.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.theRaceToolStripMenuItem,
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.mspMainJkra.Location = new System.Drawing.Point(0, 0);
            this.mspMainJkra.Name = "mspMainJkra";
            this.mspMainJkra.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.mspMainJkra.Size = new System.Drawing.Size(895, 24);
            this.mspMainJkra.TabIndex = 1;
            this.mspMainJkra.Text = "menuStrip1";
            // 
            // tbpSetupAndStatisticsJkra
            // 
            this.tbpSetupAndStatisticsJkra.BackColor = System.Drawing.Color.Black;
            this.tbpSetupAndStatisticsJkra.Controls.Add(this.label19);
            this.tbpSetupAndStatisticsJkra.Controls.Add(this.label18);
            this.tbpSetupAndStatisticsJkra.Controls.Add(this.label3);
            this.tbpSetupAndStatisticsJkra.Controls.Add(this.pictureBox5);
            this.tbpSetupAndStatisticsJkra.Controls.Add(this.pictureBox4);
            this.tbpSetupAndStatisticsJkra.Controls.Add(this.pictureBox2);
            this.tbpSetupAndStatisticsJkra.Controls.Add(this.groupBox3);
            this.tbpSetupAndStatisticsJkra.Controls.Add(this.pictureBox3);
            this.tbpSetupAndStatisticsJkra.Controls.Add(this.groupBox2);
            this.tbpSetupAndStatisticsJkra.Controls.Add(this.groupBox1);
            this.tbpSetupAndStatisticsJkra.ForeColor = System.Drawing.Color.Black;
            this.tbpSetupAndStatisticsJkra.Location = new System.Drawing.Point(4, 22);
            this.tbpSetupAndStatisticsJkra.Margin = new System.Windows.Forms.Padding(2);
            this.tbpSetupAndStatisticsJkra.Name = "tbpSetupAndStatisticsJkra";
            this.tbpSetupAndStatisticsJkra.Size = new System.Drawing.Size(867, 378);
            this.tbpSetupAndStatisticsJkra.TabIndex = 4;
            this.tbpSetupAndStatisticsJkra.Text = "SetupAndStatistics";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Aurebesh", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.MediumBlue;
            this.label19.Location = new System.Drawing.Point(333, 318);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(406, 15);
            this.label19.TabIndex = 37;
            this.label19.Text = "Victory for the separatist alliance";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Aurebesh", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.OrangeRed;
            this.label18.Location = new System.Drawing.Point(196, 342);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(207, 15);
            this.label18.TabIndex = 36;
            this.label18.Text = "For the rebellion";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Aurebesh", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LightGray;
            this.label3.Location = new System.Drawing.Point(196, 293);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(246, 16);
            this.label3.TabIndex = 35;
            this.label3.Text = "Long live the empire";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox5.BackgroundImage")));
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox5.Location = new System.Drawing.Point(489, 161);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(100, 139);
            this.pictureBox5.TabIndex = 34;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(0, 277);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(181, 91);
            this.pictureBox4.TabIndex = 33;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.DimGray;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pictureBox2.Location = new System.Drawing.Point(362, 160);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(134, 120);
            this.pictureBox2.TabIndex = 31;
            this.pictureBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblRacerFourRankUpDownJkra);
            this.groupBox3.Controls.Add(this.lblRacerThreeRankUpDownJkra);
            this.groupBox3.Controls.Add(this.lblRacerTwoRankUpDownJkra);
            this.groupBox3.Controls.Add(this.lblRacerOneRankUpDownJkra);
            this.groupBox3.Controls.Add(this.lblNrOfRacesJkra);
            this.groupBox3.Controls.Add(this.label24);
            this.groupBox3.Controls.Add(this.label23);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.lblRacerFourAverageJkra);
            this.groupBox3.Controls.Add(this.lblRacerOneAverageJkra);
            this.groupBox3.Controls.Add(this.lblRacerTwoAverageJkra);
            this.groupBox3.Controls.Add(this.lblRacerThreeAverageJkra);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(362, 2);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(224, 154);
            this.groupBox3.TabIndex = 30;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Race statistics";
            // 
            // lblRacerFourRankUpDownJkra
            // 
            this.lblRacerFourRankUpDownJkra.AutoSize = true;
            this.lblRacerFourRankUpDownJkra.Location = new System.Drawing.Point(138, 132);
            this.lblRacerFourRankUpDownJkra.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRacerFourRankUpDownJkra.Name = "lblRacerFourRankUpDownJkra";
            this.lblRacerFourRankUpDownJkra.Size = new System.Drawing.Size(16, 13);
            this.lblRacerFourRankUpDownJkra.TabIndex = 29;
            this.lblRacerFourRankUpDownJkra.Text = "---";
            // 
            // lblRacerThreeRankUpDownJkra
            // 
            this.lblRacerThreeRankUpDownJkra.AutoSize = true;
            this.lblRacerThreeRankUpDownJkra.Location = new System.Drawing.Point(138, 109);
            this.lblRacerThreeRankUpDownJkra.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRacerThreeRankUpDownJkra.Name = "lblRacerThreeRankUpDownJkra";
            this.lblRacerThreeRankUpDownJkra.Size = new System.Drawing.Size(16, 13);
            this.lblRacerThreeRankUpDownJkra.TabIndex = 29;
            this.lblRacerThreeRankUpDownJkra.Text = "---";
            // 
            // lblRacerTwoRankUpDownJkra
            // 
            this.lblRacerTwoRankUpDownJkra.AutoSize = true;
            this.lblRacerTwoRankUpDownJkra.Location = new System.Drawing.Point(138, 85);
            this.lblRacerTwoRankUpDownJkra.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRacerTwoRankUpDownJkra.Name = "lblRacerTwoRankUpDownJkra";
            this.lblRacerTwoRankUpDownJkra.Size = new System.Drawing.Size(16, 13);
            this.lblRacerTwoRankUpDownJkra.TabIndex = 29;
            this.lblRacerTwoRankUpDownJkra.Text = "---";
            // 
            // lblRacerOneRankUpDownJkra
            // 
            this.lblRacerOneRankUpDownJkra.AutoSize = true;
            this.lblRacerOneRankUpDownJkra.Location = new System.Drawing.Point(138, 62);
            this.lblRacerOneRankUpDownJkra.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRacerOneRankUpDownJkra.Name = "lblRacerOneRankUpDownJkra";
            this.lblRacerOneRankUpDownJkra.Size = new System.Drawing.Size(16, 13);
            this.lblRacerOneRankUpDownJkra.TabIndex = 29;
            this.lblRacerOneRankUpDownJkra.Text = "---";
            // 
            // lblNrOfRacesJkra
            // 
            this.lblNrOfRacesJkra.AutoSize = true;
            this.lblNrOfRacesJkra.Location = new System.Drawing.Point(91, 18);
            this.lblNrOfRacesJkra.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNrOfRacesJkra.Name = "lblNrOfRacesJkra";
            this.lblNrOfRacesJkra.Size = new System.Drawing.Size(16, 13);
            this.lblNrOfRacesJkra.TabIndex = 28;
            this.lblNrOfRacesJkra.Text = "---";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(4, 18);
            this.label24.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(88, 13);
            this.label24.TabIndex = 27;
            this.label24.Text = "Number of races:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(138, 41);
            this.label23.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(74, 13);
            this.label23.TabIndex = 26;
            this.label23.Text = "up/down rank";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(52, 41);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(69, 13);
            this.label17.TabIndex = 25;
            this.label17.Text = "average pos.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 132);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Racer 4:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(4, 109);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(48, 13);
            this.label14.TabIndex = 13;
            this.label14.Text = "Racer 3:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(4, 85);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(48, 13);
            this.label15.TabIndex = 14;
            this.label15.Text = "Racer 2:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(4, 62);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(48, 13);
            this.label16.TabIndex = 15;
            this.label16.Text = "Racer 1:";
            // 
            // lblRacerFourAverageJkra
            // 
            this.lblRacerFourAverageJkra.AutoSize = true;
            this.lblRacerFourAverageJkra.Location = new System.Drawing.Point(52, 132);
            this.lblRacerFourAverageJkra.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRacerFourAverageJkra.Name = "lblRacerFourAverageJkra";
            this.lblRacerFourAverageJkra.Size = new System.Drawing.Size(16, 13);
            this.lblRacerFourAverageJkra.TabIndex = 24;
            this.lblRacerFourAverageJkra.Text = "---";
            // 
            // lblRacerOneAverageJkra
            // 
            this.lblRacerOneAverageJkra.AutoSize = true;
            this.lblRacerOneAverageJkra.Location = new System.Drawing.Point(52, 63);
            this.lblRacerOneAverageJkra.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRacerOneAverageJkra.Name = "lblRacerOneAverageJkra";
            this.lblRacerOneAverageJkra.Size = new System.Drawing.Size(16, 13);
            this.lblRacerOneAverageJkra.TabIndex = 24;
            this.lblRacerOneAverageJkra.Text = "---";
            // 
            // lblRacerTwoAverageJkra
            // 
            this.lblRacerTwoAverageJkra.AutoSize = true;
            this.lblRacerTwoAverageJkra.Location = new System.Drawing.Point(52, 87);
            this.lblRacerTwoAverageJkra.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRacerTwoAverageJkra.Name = "lblRacerTwoAverageJkra";
            this.lblRacerTwoAverageJkra.Size = new System.Drawing.Size(16, 13);
            this.lblRacerTwoAverageJkra.TabIndex = 24;
            this.lblRacerTwoAverageJkra.Text = "---";
            // 
            // lblRacerThreeAverageJkra
            // 
            this.lblRacerThreeAverageJkra.AutoSize = true;
            this.lblRacerThreeAverageJkra.Location = new System.Drawing.Point(52, 110);
            this.lblRacerThreeAverageJkra.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRacerThreeAverageJkra.Name = "lblRacerThreeAverageJkra";
            this.lblRacerThreeAverageJkra.Size = new System.Drawing.Size(16, 13);
            this.lblRacerThreeAverageJkra.TabIndex = 24;
            this.lblRacerThreeAverageJkra.Text = "---";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Location = new System.Drawing.Point(769, 258);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(88, 115);
            this.pictureBox3.TabIndex = 32;
            this.pictureBox3.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnClearRaceResultsJkra);
            this.groupBox2.Controls.Add(this.rtbRaceResultsJkra);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(590, 2);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(272, 278);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Race statistics logging";
            // 
            // btnClearRaceResultsJkra
            // 
            this.btnClearRaceResultsJkra.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnClearRaceResultsJkra.ForeColor = System.Drawing.Color.Silver;
            this.btnClearRaceResultsJkra.Location = new System.Drawing.Point(0, 255);
            this.btnClearRaceResultsJkra.Margin = new System.Windows.Forms.Padding(2);
            this.btnClearRaceResultsJkra.Name = "btnClearRaceResultsJkra";
            this.btnClearRaceResultsJkra.Size = new System.Drawing.Size(56, 23);
            this.btnClearRaceResultsJkra.TabIndex = 1;
            this.btnClearRaceResultsJkra.Text = "Clear";
            this.btnClearRaceResultsJkra.UseVisualStyleBackColor = false;
            this.btnClearRaceResultsJkra.Click += new System.EventHandler(this.btnClearRaceResultsJkra_Click);
            // 
            // rtbRaceResultsJkra
            // 
            this.rtbRaceResultsJkra.BackColor = System.Drawing.Color.Silver;
            this.rtbRaceResultsJkra.ForeColor = System.Drawing.Color.LawnGreen;
            this.rtbRaceResultsJkra.Location = new System.Drawing.Point(4, 19);
            this.rtbRaceResultsJkra.Margin = new System.Windows.Forms.Padding(2);
            this.rtbRaceResultsJkra.Name = "rtbRaceResultsJkra";
            this.rtbRaceResultsJkra.Size = new System.Drawing.Size(261, 232);
            this.rtbRaceResultsJkra.TabIndex = 0;
            this.rtbRaceResultsJkra.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnUpdateNamesJkra);
            this.groupBox1.Controls.Add(this.btnDefaultSetupJkra);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.btnSetUpRacersJkra);
            this.groupBox1.Controls.Add(this.txbMaxSpeedJkra);
            this.groupBox1.Controls.Add(this.lblRacerOneSpeedJkra);
            this.groupBox1.Controls.Add(this.lblRacerTwoSpeedJkra);
            this.groupBox1.Controls.Add(this.label22);
            this.groupBox1.Controls.Add(this.lblRacerFourStepJkra);
            this.groupBox1.Controls.Add(this.lblRacerThreeSpeedJkra);
            this.groupBox1.Controls.Add(this.txbMinSpeedJkra);
            this.groupBox1.Controls.Add(this.lblRacerThreeStepJkra);
            this.groupBox1.Controls.Add(this.lblRacerFourSpeedJkra);
            this.groupBox1.Controls.Add(this.label21);
            this.groupBox1.Controls.Add(this.lblRacerTwoStepJkra);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lblRacerOneStepJkra);
            this.groupBox1.Controls.Add(this.cbxDynamicSpeed);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txbTrackSpeedJkra);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txbRacerOneNameJkra);
            this.groupBox1.Controls.Add(this.txbRacerTwoNameJkra);
            this.groupBox1.Controls.Add(this.txbRacerFourNameJkra);
            this.groupBox1.Controls.Add(this.txbRacerThreeNameJkra);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(2, 2);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(355, 278);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Race setup";
            // 
            // btnUpdateNamesJkra
            // 
            this.btnUpdateNamesJkra.BackColor = System.Drawing.Color.Black;
            this.btnUpdateNamesJkra.ForeColor = System.Drawing.Color.Yellow;
            this.btnUpdateNamesJkra.Location = new System.Drawing.Point(70, 247);
            this.btnUpdateNamesJkra.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdateNamesJkra.Name = "btnUpdateNamesJkra";
            this.btnUpdateNamesJkra.Size = new System.Drawing.Size(75, 27);
            this.btnUpdateNamesJkra.TabIndex = 31;
            this.btnUpdateNamesJkra.Text = "update";
            this.btnUpdateNamesJkra.UseVisualStyleBackColor = false;
            this.btnUpdateNamesJkra.Click += new System.EventHandler(this.btnUpdateNames_Click);
            // 
            // btnDefaultSetupJkra
            // 
            this.btnDefaultSetupJkra.ForeColor = System.Drawing.Color.Yellow;
            this.btnDefaultSetupJkra.Location = new System.Drawing.Point(7, 87);
            this.btnDefaultSetupJkra.Margin = new System.Windows.Forms.Padding(2);
            this.btnDefaultSetupJkra.Name = "btnDefaultSetupJkra";
            this.btnDefaultSetupJkra.Size = new System.Drawing.Size(78, 21);
            this.btnDefaultSetupJkra.TabIndex = 30;
            this.btnDefaultSetupJkra.Text = "Default";
            this.btnDefaultSetupJkra.UseVisualStyleBackColor = false;
            this.btnDefaultSetupJkra.Click += new System.EventHandler(this.btnDefaultSetup_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Gold;
            this.label8.Location = new System.Drawing.Point(4, 132);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Number";
            // 
            // btnSetUpRacersJkra
            // 
            this.btnSetUpRacersJkra.BackColor = System.Drawing.Color.Black;
            this.btnSetUpRacersJkra.ForeColor = System.Drawing.Color.Yellow;
            this.btnSetUpRacersJkra.Location = new System.Drawing.Point(160, 247);
            this.btnSetUpRacersJkra.Margin = new System.Windows.Forms.Padding(2);
            this.btnSetUpRacersJkra.Name = "btnSetUpRacersJkra";
            this.btnSetUpRacersJkra.Size = new System.Drawing.Size(80, 27);
            this.btnSetUpRacersJkra.TabIndex = 7;
            this.btnSetUpRacersJkra.Text = "Setup Racers";
            this.btnSetUpRacersJkra.UseVisualStyleBackColor = false;
            this.btnSetUpRacersJkra.Click += new System.EventHandler(this.btnSetUpRacers_Click);
            // 
            // txbMaxSpeedJkra
            // 
            this.txbMaxSpeedJkra.Location = new System.Drawing.Point(119, 62);
            this.txbMaxSpeedJkra.Margin = new System.Windows.Forms.Padding(2);
            this.txbMaxSpeedJkra.Name = "txbMaxSpeedJkra";
            this.txbMaxSpeedJkra.Size = new System.Drawing.Size(76, 20);
            this.txbMaxSpeedJkra.TabIndex = 29;
            // 
            // lblRacerOneSpeedJkra
            // 
            this.lblRacerOneSpeedJkra.AutoSize = true;
            this.lblRacerOneSpeedJkra.Location = new System.Drawing.Point(158, 152);
            this.lblRacerOneSpeedJkra.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRacerOneSpeedJkra.Name = "lblRacerOneSpeedJkra";
            this.lblRacerOneSpeedJkra.Size = new System.Drawing.Size(16, 13);
            this.lblRacerOneSpeedJkra.TabIndex = 11;
            this.lblRacerOneSpeedJkra.Text = "---";
            // 
            // lblRacerTwoSpeedJkra
            // 
            this.lblRacerTwoSpeedJkra.AutoSize = true;
            this.lblRacerTwoSpeedJkra.Location = new System.Drawing.Point(158, 176);
            this.lblRacerTwoSpeedJkra.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRacerTwoSpeedJkra.Name = "lblRacerTwoSpeedJkra";
            this.lblRacerTwoSpeedJkra.Size = new System.Drawing.Size(16, 13);
            this.lblRacerTwoSpeedJkra.TabIndex = 10;
            this.lblRacerTwoSpeedJkra.Text = "---";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.ForeColor = System.Drawing.Color.Red;
            this.label22.Location = new System.Drawing.Point(4, 64);
            this.label22.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(97, 13);
            this.label22.TabIndex = 28;
            this.label22.Text = "max Engine Output";
            // 
            // lblRacerFourStepJkra
            // 
            this.lblRacerFourStepJkra.AutoSize = true;
            this.lblRacerFourStepJkra.Location = new System.Drawing.Point(236, 222);
            this.lblRacerFourStepJkra.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRacerFourStepJkra.Name = "lblRacerFourStepJkra";
            this.lblRacerFourStepJkra.Size = new System.Drawing.Size(16, 13);
            this.lblRacerFourStepJkra.TabIndex = 24;
            this.lblRacerFourStepJkra.Text = "---";
            // 
            // lblRacerThreeSpeedJkra
            // 
            this.lblRacerThreeSpeedJkra.AutoSize = true;
            this.lblRacerThreeSpeedJkra.Location = new System.Drawing.Point(158, 199);
            this.lblRacerThreeSpeedJkra.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRacerThreeSpeedJkra.Name = "lblRacerThreeSpeedJkra";
            this.lblRacerThreeSpeedJkra.Size = new System.Drawing.Size(16, 13);
            this.lblRacerThreeSpeedJkra.TabIndex = 9;
            this.lblRacerThreeSpeedJkra.Text = "---";
            // 
            // txbMinSpeedJkra
            // 
            this.txbMinSpeedJkra.Location = new System.Drawing.Point(119, 41);
            this.txbMinSpeedJkra.Margin = new System.Windows.Forms.Padding(2);
            this.txbMinSpeedJkra.Name = "txbMinSpeedJkra";
            this.txbMinSpeedJkra.Size = new System.Drawing.Size(76, 20);
            this.txbMinSpeedJkra.TabIndex = 29;
            // 
            // lblRacerThreeStepJkra
            // 
            this.lblRacerThreeStepJkra.AutoSize = true;
            this.lblRacerThreeStepJkra.Location = new System.Drawing.Point(236, 200);
            this.lblRacerThreeStepJkra.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRacerThreeStepJkra.Name = "lblRacerThreeStepJkra";
            this.lblRacerThreeStepJkra.Size = new System.Drawing.Size(16, 13);
            this.lblRacerThreeStepJkra.TabIndex = 24;
            this.lblRacerThreeStepJkra.Text = "---";
            // 
            // lblRacerFourSpeedJkra
            // 
            this.lblRacerFourSpeedJkra.AutoSize = true;
            this.lblRacerFourSpeedJkra.Location = new System.Drawing.Point(158, 223);
            this.lblRacerFourSpeedJkra.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRacerFourSpeedJkra.Name = "lblRacerFourSpeedJkra";
            this.lblRacerFourSpeedJkra.Size = new System.Drawing.Size(16, 13);
            this.lblRacerFourSpeedJkra.TabIndex = 8;
            this.lblRacerFourSpeedJkra.Text = "---";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.ForeColor = System.Drawing.Color.Red;
            this.label21.Location = new System.Drawing.Point(4, 41);
            this.label21.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(94, 13);
            this.label21.TabIndex = 28;
            this.label21.Text = "min Engine Output";
            // 
            // lblRacerTwoStepJkra
            // 
            this.lblRacerTwoStepJkra.AutoSize = true;
            this.lblRacerTwoStepJkra.Location = new System.Drawing.Point(236, 176);
            this.lblRacerTwoStepJkra.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRacerTwoStepJkra.Name = "lblRacerTwoStepJkra";
            this.lblRacerTwoStepJkra.Size = new System.Drawing.Size(16, 13);
            this.lblRacerTwoStepJkra.TabIndex = 24;
            this.lblRacerTwoStepJkra.Text = "---";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Khaki;
            this.label4.Location = new System.Drawing.Point(4, 153);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Racer 1:";
            // 
            // lblRacerOneStepJkra
            // 
            this.lblRacerOneStepJkra.AutoSize = true;
            this.lblRacerOneStepJkra.Location = new System.Drawing.Point(236, 153);
            this.lblRacerOneStepJkra.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRacerOneStepJkra.Name = "lblRacerOneStepJkra";
            this.lblRacerOneStepJkra.Size = new System.Drawing.Size(16, 13);
            this.lblRacerOneStepJkra.TabIndex = 24;
            this.lblRacerOneStepJkra.Text = "---";
            // 
            // cbxDynamicSpeed
            // 
            this.cbxDynamicSpeed.AutoSize = true;
            this.cbxDynamicSpeed.ForeColor = System.Drawing.Color.Red;
            this.cbxDynamicSpeed.Location = new System.Drawing.Point(218, 20);
            this.cbxDynamicSpeed.Margin = new System.Windows.Forms.Padding(2);
            this.cbxDynamicSpeed.Name = "cbxDynamicSpeed";
            this.cbxDynamicSpeed.Size = new System.Drawing.Size(113, 17);
            this.cbxDynamicSpeed.TabIndex = 27;
            this.cbxDynamicSpeed.Text = "Velocity Increment";
            this.cbxDynamicSpeed.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Gold;
            this.label5.Location = new System.Drawing.Point(4, 176);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Racer 2:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.LimeGreen;
            this.label11.Location = new System.Drawing.Point(236, 131);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(94, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "Velocity Increment";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Gold;
            this.label6.Location = new System.Drawing.Point(4, 200);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Racer 3:";
            // 
            // txbTrackSpeedJkra
            // 
            this.txbTrackSpeedJkra.Location = new System.Drawing.Point(119, 19);
            this.txbTrackSpeedJkra.Margin = new System.Windows.Forms.Padding(2);
            this.txbTrackSpeedJkra.Name = "txbTrackSpeedJkra";
            this.txbTrackSpeedJkra.Size = new System.Drawing.Size(76, 20);
            this.txbTrackSpeedJkra.TabIndex = 26;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Gold;
            this.label10.Location = new System.Drawing.Point(68, 131);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Name";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(4, 19);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(109, 13);
            this.label12.TabIndex = 25;
            this.label12.Text = "Hyperspace Constant";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Gold;
            this.label7.Location = new System.Drawing.Point(4, 223);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Racer 4:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.LimeGreen;
            this.label9.Location = new System.Drawing.Point(158, 131);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Pilot Skill Level";
            // 
            // txbRacerOneNameJkra
            // 
            this.txbRacerOneNameJkra.Location = new System.Drawing.Point(70, 152);
            this.txbRacerOneNameJkra.Margin = new System.Windows.Forms.Padding(2);
            this.txbRacerOneNameJkra.Name = "txbRacerOneNameJkra";
            this.txbRacerOneNameJkra.Size = new System.Drawing.Size(76, 20);
            this.txbRacerOneNameJkra.TabIndex = 19;
            // 
            // txbRacerTwoNameJkra
            // 
            this.txbRacerTwoNameJkra.Location = new System.Drawing.Point(70, 173);
            this.txbRacerTwoNameJkra.Margin = new System.Windows.Forms.Padding(2);
            this.txbRacerTwoNameJkra.Name = "txbRacerTwoNameJkra";
            this.txbRacerTwoNameJkra.Size = new System.Drawing.Size(76, 20);
            this.txbRacerTwoNameJkra.TabIndex = 18;
            // 
            // txbRacerFourNameJkra
            // 
            this.txbRacerFourNameJkra.Location = new System.Drawing.Point(70, 219);
            this.txbRacerFourNameJkra.Margin = new System.Windows.Forms.Padding(2);
            this.txbRacerFourNameJkra.Name = "txbRacerFourNameJkra";
            this.txbRacerFourNameJkra.Size = new System.Drawing.Size(76, 20);
            this.txbRacerFourNameJkra.TabIndex = 16;
            // 
            // txbRacerThreeNameJkra
            // 
            this.txbRacerThreeNameJkra.Location = new System.Drawing.Point(70, 196);
            this.txbRacerThreeNameJkra.Margin = new System.Windows.Forms.Padding(2);
            this.txbRacerThreeNameJkra.Name = "txbRacerThreeNameJkra";
            this.txbRacerThreeNameJkra.Size = new System.Drawing.Size(76, 20);
            this.txbRacerThreeNameJkra.TabIndex = 17;
            // 
            // tbpTheRaceJkra
            // 
            this.tbpTheRaceJkra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.tbpTheRaceJkra.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbpTheRaceJkra.BackgroundImage")));
            this.tbpTheRaceJkra.Controls.Add(this.cbxCantinaMusicJkra);
            this.tbpTheRaceJkra.Controls.Add(this.lblRacerTwoName);
            this.tbpTheRaceJkra.Controls.Add(this.lblRacerFourName);
            this.tbpTheRaceJkra.Controls.Add(this.lblRacerOneName);
            this.tbpTheRaceJkra.Controls.Add(this.lblRacerThreeName);
            this.tbpTheRaceJkra.Controls.Add(this.btnResetPositionsJkra);
            this.tbpTheRaceJkra.Controls.Add(this.lblRacerFourStepActual);
            this.tbpTheRaceJkra.Controls.Add(this.lblRacerThreeStepActual);
            this.tbpTheRaceJkra.Controls.Add(this.lblRacerTwoStepActual);
            this.tbpTheRaceJkra.Controls.Add(this.lblRacerOneStepActual);
            this.tbpTheRaceJkra.Controls.Add(this.pnlGetSet);
            this.tbpTheRaceJkra.Controls.Add(this.lblRaceTimeJkra);
            this.tbpTheRaceJkra.Controls.Add(this.label13);
            this.tbpTheRaceJkra.Controls.Add(this.lblRacerFourFinishedPosition);
            this.tbpTheRaceJkra.Controls.Add(this.lblRacerThreeFinishedPosition);
            this.tbpTheRaceJkra.Controls.Add(this.lblRacerTwoFinishedPosition);
            this.tbpTheRaceJkra.Controls.Add(this.lblRacerOneFinishedPosition);
            this.tbpTheRaceJkra.Controls.Add(this.btnStartJkra);
            this.tbpTheRaceJkra.Controls.Add(this.panel4);
            this.tbpTheRaceJkra.Controls.Add(this.panel3);
            this.tbpTheRaceJkra.Controls.Add(this.panel2);
            this.tbpTheRaceJkra.Controls.Add(this.panel1);
            this.tbpTheRaceJkra.Controls.Add(this.pnlFinishLineJkra);
            this.tbpTheRaceJkra.Controls.Add(this.label1);
            this.tbpTheRaceJkra.Controls.Add(this.pnlStartPositionsJkra);
            this.tbpTheRaceJkra.Controls.Add(this.pbxRacerOneJkra);
            this.tbpTheRaceJkra.Controls.Add(this.pbxRacerFourJkra);
            this.tbpTheRaceJkra.Controls.Add(this.pbxRacerTwoJkra);
            this.tbpTheRaceJkra.Controls.Add(this.pbxRacerThreeJkra);
            this.tbpTheRaceJkra.Controls.Add(this.pbxRacerFourTrace);
            this.tbpTheRaceJkra.Controls.Add(this.pbxRacerThreeTrace);
            this.tbpTheRaceJkra.Controls.Add(this.pbxRacerTwoTrace);
            this.tbpTheRaceJkra.Controls.Add(this.pbxRacerOneTrace);
            this.tbpTheRaceJkra.Controls.Add(this.pictureBox1);
            this.tbpTheRaceJkra.Location = new System.Drawing.Point(4, 22);
            this.tbpTheRaceJkra.Margin = new System.Windows.Forms.Padding(2);
            this.tbpTheRaceJkra.Name = "tbpTheRaceJkra";
            this.tbpTheRaceJkra.Padding = new System.Windows.Forms.Padding(2);
            this.tbpTheRaceJkra.Size = new System.Drawing.Size(867, 378);
            this.tbpTheRaceJkra.TabIndex = 0;
            this.tbpTheRaceJkra.Text = "The Race";
            // 
            // cbxCantinaMusicJkra
            // 
            this.cbxCantinaMusicJkra.AutoSize = true;
            this.cbxCantinaMusicJkra.BackColor = System.Drawing.Color.White;
            this.cbxCantinaMusicJkra.Font = new System.Drawing.Font("Aurebesh", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxCantinaMusicJkra.ForeColor = System.Drawing.Color.Black;
            this.cbxCantinaMusicJkra.Location = new System.Drawing.Point(4, 328);
            this.cbxCantinaMusicJkra.Name = "cbxCantinaMusicJkra";
            this.cbxCantinaMusicJkra.Size = new System.Drawing.Size(61, 15);
            this.cbxCantinaMusicJkra.TabIndex = 35;
            this.cbxCantinaMusicJkra.Text = "Music";
            this.cbxCantinaMusicJkra.UseVisualStyleBackColor = false;
            this.cbxCantinaMusicJkra.CheckedChanged += new System.EventHandler(this.cbxCantinaMusicJkra_CheckedChanged);
            // 
            // lblRacerTwoName
            // 
            this.lblRacerTwoName.AutoSize = true;
            this.lblRacerTwoName.BackColor = System.Drawing.Color.Transparent;
            this.lblRacerTwoName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblRacerTwoName.Location = new System.Drawing.Point(121, 139);
            this.lblRacerTwoName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRacerTwoName.Name = "lblRacerTwoName";
            this.lblRacerTwoName.Size = new System.Drawing.Size(16, 13);
            this.lblRacerTwoName.TabIndex = 33;
            this.lblRacerTwoName.Text = "---";
            // 
            // lblRacerFourName
            // 
            this.lblRacerFourName.AutoSize = true;
            this.lblRacerFourName.BackColor = System.Drawing.Color.Transparent;
            this.lblRacerFourName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblRacerFourName.Location = new System.Drawing.Point(121, 266);
            this.lblRacerFourName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRacerFourName.Name = "lblRacerFourName";
            this.lblRacerFourName.Size = new System.Drawing.Size(16, 13);
            this.lblRacerFourName.TabIndex = 34;
            this.lblRacerFourName.Text = "---";
            // 
            // lblRacerOneName
            // 
            this.lblRacerOneName.AutoSize = true;
            this.lblRacerOneName.BackColor = System.Drawing.Color.Transparent;
            this.lblRacerOneName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblRacerOneName.Location = new System.Drawing.Point(121, 66);
            this.lblRacerOneName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRacerOneName.Name = "lblRacerOneName";
            this.lblRacerOneName.Size = new System.Drawing.Size(16, 13);
            this.lblRacerOneName.TabIndex = 32;
            this.lblRacerOneName.Text = "---";
            // 
            // lblRacerThreeName
            // 
            this.lblRacerThreeName.AutoSize = true;
            this.lblRacerThreeName.BackColor = System.Drawing.Color.Transparent;
            this.lblRacerThreeName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblRacerThreeName.Location = new System.Drawing.Point(121, 193);
            this.lblRacerThreeName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRacerThreeName.Name = "lblRacerThreeName";
            this.lblRacerThreeName.Size = new System.Drawing.Size(16, 13);
            this.lblRacerThreeName.TabIndex = 34;
            this.lblRacerThreeName.Text = "---";
            // 
            // btnResetPositionsJkra
            // 
            this.btnResetPositionsJkra.Font = new System.Drawing.Font("Aurebesh", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetPositionsJkra.Location = new System.Drawing.Point(81, 294);
            this.btnResetPositionsJkra.Margin = new System.Windows.Forms.Padding(2);
            this.btnResetPositionsJkra.Name = "btnResetPositionsJkra";
            this.btnResetPositionsJkra.Size = new System.Drawing.Size(71, 29);
            this.btnResetPositionsJkra.TabIndex = 8;
            this.btnResetPositionsJkra.Text = "Reset";
            this.btnResetPositionsJkra.UseVisualStyleBackColor = true;
            this.btnResetPositionsJkra.Click += new System.EventHandler(this.btnResetPositions_Click);
            // 
            // lblRacerFourStepActual
            // 
            this.lblRacerFourStepActual.AutoSize = true;
            this.lblRacerFourStepActual.BackColor = System.Drawing.SystemColors.Desktop;
            this.lblRacerFourStepActual.ForeColor = System.Drawing.Color.White;
            this.lblRacerFourStepActual.Location = new System.Drawing.Point(10, 192);
            this.lblRacerFourStepActual.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRacerFourStepActual.Name = "lblRacerFourStepActual";
            this.lblRacerFourStepActual.Size = new System.Drawing.Size(16, 13);
            this.lblRacerFourStepActual.TabIndex = 25;
            this.lblRacerFourStepActual.Text = "---";
            // 
            // lblRacerThreeStepActual
            // 
            this.lblRacerThreeStepActual.AutoSize = true;
            this.lblRacerThreeStepActual.BackColor = System.Drawing.Color.Black;
            this.lblRacerThreeStepActual.ForeColor = System.Drawing.Color.White;
            this.lblRacerThreeStepActual.Location = new System.Drawing.Point(10, 146);
            this.lblRacerThreeStepActual.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRacerThreeStepActual.Name = "lblRacerThreeStepActual";
            this.lblRacerThreeStepActual.Size = new System.Drawing.Size(16, 13);
            this.lblRacerThreeStepActual.TabIndex = 26;
            this.lblRacerThreeStepActual.Text = "---";
            // 
            // lblRacerTwoStepActual
            // 
            this.lblRacerTwoStepActual.AutoSize = true;
            this.lblRacerTwoStepActual.BackColor = System.Drawing.Color.Black;
            this.lblRacerTwoStepActual.ForeColor = System.Drawing.Color.White;
            this.lblRacerTwoStepActual.Location = new System.Drawing.Point(10, 269);
            this.lblRacerTwoStepActual.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRacerTwoStepActual.Name = "lblRacerTwoStepActual";
            this.lblRacerTwoStepActual.Size = new System.Drawing.Size(16, 13);
            this.lblRacerTwoStepActual.TabIndex = 27;
            this.lblRacerTwoStepActual.Text = "---";
            // 
            // lblRacerOneStepActual
            // 
            this.lblRacerOneStepActual.AutoSize = true;
            this.lblRacerOneStepActual.BackColor = System.Drawing.Color.Black;
            this.lblRacerOneStepActual.ForeColor = System.Drawing.Color.White;
            this.lblRacerOneStepActual.Location = new System.Drawing.Point(10, 67);
            this.lblRacerOneStepActual.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRacerOneStepActual.Name = "lblRacerOneStepActual";
            this.lblRacerOneStepActual.Size = new System.Drawing.Size(16, 13);
            this.lblRacerOneStepActual.TabIndex = 28;
            this.lblRacerOneStepActual.Text = "---";
            // 
            // pnlGetSet
            // 
            this.pnlGetSet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlGetSet.Location = new System.Drawing.Point(4, 18);
            this.pnlGetSet.Margin = new System.Windows.Forms.Padding(2);
            this.pnlGetSet.Name = "pnlGetSet";
            this.pnlGetSet.Size = new System.Drawing.Size(2, 206);
            this.pnlGetSet.TabIndex = 3;
            // 
            // lblRaceTimeJkra
            // 
            this.lblRaceTimeJkra.AutoSize = true;
            this.lblRaceTimeJkra.BackColor = System.Drawing.Color.Black;
            this.lblRaceTimeJkra.ForeColor = System.Drawing.Color.White;
            this.lblRaceTimeJkra.Location = new System.Drawing.Point(215, 302);
            this.lblRaceTimeJkra.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRaceTimeJkra.Name = "lblRaceTimeJkra";
            this.lblRaceTimeJkra.Size = new System.Drawing.Size(16, 13);
            this.lblRaceTimeJkra.TabIndex = 7;
            this.lblRaceTimeJkra.Text = "---";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Black;
            this.label13.Font = new System.Drawing.Font("Aurebesh", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(163, 302);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(40, 11);
            this.label13.TabIndex = 6;
            this.label13.Text = "Time:";
            // 
            // lblRacerFourFinishedPosition
            // 
            this.lblRacerFourFinishedPosition.AutoSize = true;
            this.lblRacerFourFinishedPosition.BackColor = System.Drawing.Color.Transparent;
            this.lblRacerFourFinishedPosition.ForeColor = System.Drawing.Color.White;
            this.lblRacerFourFinishedPosition.Location = new System.Drawing.Point(830, 263);
            this.lblRacerFourFinishedPosition.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRacerFourFinishedPosition.Name = "lblRacerFourFinishedPosition";
            this.lblRacerFourFinishedPosition.Size = new System.Drawing.Size(16, 13);
            this.lblRacerFourFinishedPosition.TabIndex = 5;
            this.lblRacerFourFinishedPosition.Text = "---";
            // 
            // lblRacerThreeFinishedPosition
            // 
            this.lblRacerThreeFinishedPosition.AutoSize = true;
            this.lblRacerThreeFinishedPosition.BackColor = System.Drawing.Color.Transparent;
            this.lblRacerThreeFinishedPosition.ForeColor = System.Drawing.Color.White;
            this.lblRacerThreeFinishedPosition.Location = new System.Drawing.Point(830, 191);
            this.lblRacerThreeFinishedPosition.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRacerThreeFinishedPosition.Name = "lblRacerThreeFinishedPosition";
            this.lblRacerThreeFinishedPosition.Size = new System.Drawing.Size(16, 13);
            this.lblRacerThreeFinishedPosition.TabIndex = 5;
            this.lblRacerThreeFinishedPosition.Text = "---";
            // 
            // lblRacerTwoFinishedPosition
            // 
            this.lblRacerTwoFinishedPosition.AutoSize = true;
            this.lblRacerTwoFinishedPosition.BackColor = System.Drawing.Color.Transparent;
            this.lblRacerTwoFinishedPosition.ForeColor = System.Drawing.Color.White;
            this.lblRacerTwoFinishedPosition.Location = new System.Drawing.Point(830, 129);
            this.lblRacerTwoFinishedPosition.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRacerTwoFinishedPosition.Name = "lblRacerTwoFinishedPosition";
            this.lblRacerTwoFinishedPosition.Size = new System.Drawing.Size(16, 13);
            this.lblRacerTwoFinishedPosition.TabIndex = 5;
            this.lblRacerTwoFinishedPosition.Text = "---";
            // 
            // lblRacerOneFinishedPosition
            // 
            this.lblRacerOneFinishedPosition.AutoSize = true;
            this.lblRacerOneFinishedPosition.BackColor = System.Drawing.Color.Transparent;
            this.lblRacerOneFinishedPosition.ForeColor = System.Drawing.Color.White;
            this.lblRacerOneFinishedPosition.Location = new System.Drawing.Point(834, 55);
            this.lblRacerOneFinishedPosition.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRacerOneFinishedPosition.Name = "lblRacerOneFinishedPosition";
            this.lblRacerOneFinishedPosition.Size = new System.Drawing.Size(16, 13);
            this.lblRacerOneFinishedPosition.TabIndex = 5;
            this.lblRacerOneFinishedPosition.Text = "---";
            // 
            // btnStartJkra
            // 
            this.btnStartJkra.Font = new System.Drawing.Font("Aurebesh", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartJkra.Location = new System.Drawing.Point(2, 294);
            this.btnStartJkra.Margin = new System.Windows.Forms.Padding(2);
            this.btnStartJkra.Name = "btnStartJkra";
            this.btnStartJkra.Size = new System.Drawing.Size(71, 29);
            this.btnStartJkra.TabIndex = 4;
            this.btnStartJkra.Text = "START!";
            this.btnStartJkra.UseVisualStyleBackColor = true;
            this.btnStartJkra.Click += new System.EventHandler(this.btnStartJkra_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Location = new System.Drawing.Point(88, 202);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(658, 2);
            this.panel4.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(2, 280);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(822, 2);
            this.panel3.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(92, 141);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(658, 2);
            this.panel2.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(90, 67);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(658, 2);
            this.panel1.TabIndex = 3;
            // 
            // pnlFinishLineJkra
            // 
            this.pnlFinishLineJkra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlFinishLineJkra.Location = new System.Drawing.Point(750, 15);
            this.pnlFinishLineJkra.Margin = new System.Windows.Forms.Padding(2);
            this.pnlFinishLineJkra.Name = "pnlFinishLineJkra";
            this.pnlFinishLineJkra.Size = new System.Drawing.Size(10, 267);
            this.pnlFinishLineJkra.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(4, 2);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "The Race!";
            // 
            // pnlStartPositionsJkra
            // 
            this.pnlStartPositionsJkra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlStartPositionsJkra.Location = new System.Drawing.Point(109, 15);
            this.pnlStartPositionsJkra.Margin = new System.Windows.Forms.Padding(2);
            this.pnlStartPositionsJkra.Name = "pnlStartPositionsJkra";
            this.pnlStartPositionsJkra.Size = new System.Drawing.Size(8, 284);
            this.pnlStartPositionsJkra.TabIndex = 2;
            // 
            // pbxRacerOneJkra
            // 
            this.pbxRacerOneJkra.BackColor = System.Drawing.Color.Transparent;
            this.pbxRacerOneJkra.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbxRacerOneJkra.BackgroundImage")));
            this.pbxRacerOneJkra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxRacerOneJkra.Location = new System.Drawing.Point(2, 2);
            this.pbxRacerOneJkra.Margin = new System.Windows.Forms.Padding(2);
            this.pbxRacerOneJkra.Name = "pbxRacerOneJkra";
            this.pbxRacerOneJkra.Size = new System.Drawing.Size(107, 66);
            this.pbxRacerOneJkra.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxRacerOneJkra.TabIndex = 1;
            this.pbxRacerOneJkra.TabStop = false;
            // 
            // pbxRacerFourJkra
            // 
            this.pbxRacerFourJkra.BackColor = System.Drawing.Color.Transparent;
            this.pbxRacerFourJkra.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbxRacerFourJkra.BackgroundImage")));
            this.pbxRacerFourJkra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxRacerFourJkra.Location = new System.Drawing.Point(4, 209);
            this.pbxRacerFourJkra.Margin = new System.Windows.Forms.Padding(2);
            this.pbxRacerFourJkra.Name = "pbxRacerFourJkra";
            this.pbxRacerFourJkra.Size = new System.Drawing.Size(105, 58);
            this.pbxRacerFourJkra.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxRacerFourJkra.TabIndex = 1;
            this.pbxRacerFourJkra.TabStop = false;
            // 
            // pbxRacerTwoJkra
            // 
            this.pbxRacerTwoJkra.BackColor = System.Drawing.Color.Transparent;
            this.pbxRacerTwoJkra.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbxRacerTwoJkra.BackgroundImage")));
            this.pbxRacerTwoJkra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbxRacerTwoJkra.Location = new System.Drawing.Point(2, 72);
            this.pbxRacerTwoJkra.Margin = new System.Windows.Forms.Padding(2);
            this.pbxRacerTwoJkra.Name = "pbxRacerTwoJkra";
            this.pbxRacerTwoJkra.Size = new System.Drawing.Size(107, 70);
            this.pbxRacerTwoJkra.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxRacerTwoJkra.TabIndex = 1;
            this.pbxRacerTwoJkra.TabStop = false;
            // 
            // pbxRacerThreeJkra
            // 
            this.pbxRacerThreeJkra.BackColor = System.Drawing.Color.Blue;
            this.pbxRacerThreeJkra.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbxRacerThreeJkra.BackgroundImage")));
            this.pbxRacerThreeJkra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxRacerThreeJkra.Location = new System.Drawing.Point(-2, 144);
            this.pbxRacerThreeJkra.Margin = new System.Windows.Forms.Padding(2);
            this.pbxRacerThreeJkra.Name = "pbxRacerThreeJkra";
            this.pbxRacerThreeJkra.Size = new System.Drawing.Size(109, 58);
            this.pbxRacerThreeJkra.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxRacerThreeJkra.TabIndex = 1;
            this.pbxRacerThreeJkra.TabStop = false;
            // 
            // pbxRacerFourTrace
            // 
            this.pbxRacerFourTrace.BackColor = System.Drawing.Color.Black;
            this.pbxRacerFourTrace.Location = new System.Drawing.Point(126, 208);
            this.pbxRacerFourTrace.Margin = new System.Windows.Forms.Padding(2);
            this.pbxRacerFourTrace.Name = "pbxRacerFourTrace";
            this.pbxRacerFourTrace.Size = new System.Drawing.Size(26, 59);
            this.pbxRacerFourTrace.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxRacerFourTrace.TabIndex = 29;
            this.pbxRacerFourTrace.TabStop = false;
            // 
            // pbxRacerThreeTrace
            // 
            this.pbxRacerThreeTrace.BackColor = System.Drawing.Color.Black;
            this.pbxRacerThreeTrace.Location = new System.Drawing.Point(126, 141);
            this.pbxRacerThreeTrace.Margin = new System.Windows.Forms.Padding(2);
            this.pbxRacerThreeTrace.Name = "pbxRacerThreeTrace";
            this.pbxRacerThreeTrace.Size = new System.Drawing.Size(26, 61);
            this.pbxRacerThreeTrace.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxRacerThreeTrace.TabIndex = 29;
            this.pbxRacerThreeTrace.TabStop = false;
            // 
            // pbxRacerTwoTrace
            // 
            this.pbxRacerTwoTrace.BackColor = System.Drawing.SystemColors.Desktop;
            this.pbxRacerTwoTrace.Location = new System.Drawing.Point(126, 73);
            this.pbxRacerTwoTrace.Margin = new System.Windows.Forms.Padding(2);
            this.pbxRacerTwoTrace.Name = "pbxRacerTwoTrace";
            this.pbxRacerTwoTrace.Size = new System.Drawing.Size(26, 64);
            this.pbxRacerTwoTrace.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxRacerTwoTrace.TabIndex = 29;
            this.pbxRacerTwoTrace.TabStop = false;
            // 
            // pbxRacerOneTrace
            // 
            this.pbxRacerOneTrace.BackColor = System.Drawing.Color.Black;
            this.pbxRacerOneTrace.Location = new System.Drawing.Point(126, 8);
            this.pbxRacerOneTrace.Margin = new System.Windows.Forms.Padding(2);
            this.pbxRacerOneTrace.Name = "pbxRacerOneTrace";
            this.pbxRacerOneTrace.Size = new System.Drawing.Size(26, 56);
            this.pbxRacerOneTrace.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxRacerOneTrace.TabIndex = 29;
            this.pbxRacerOneTrace.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Desktop;
            this.pictureBox1.Location = new System.Drawing.Point(752, 8);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(107, 274);
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // tbpStartScreenJkra
            // 
            this.tbpStartScreenJkra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tbpStartScreenJkra.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbpStartScreenJkra.BackgroundImage")));
            this.tbpStartScreenJkra.Location = new System.Drawing.Point(4, 22);
            this.tbpStartScreenJkra.Margin = new System.Windows.Forms.Padding(2);
            this.tbpStartScreenJkra.Name = "tbpStartScreenJkra";
            this.tbpStartScreenJkra.Size = new System.Drawing.Size(867, 378);
            this.tbpStartScreenJkra.TabIndex = 3;
            this.tbpStartScreenJkra.Text = "StartScreen";
            // 
            // tbcMainJkra
            // 
            this.tbcMainJkra.Controls.Add(this.tbpStartScreenJkra);
            this.tbcMainJkra.Controls.Add(this.tbpTheRaceJkra);
            this.tbcMainJkra.Controls.Add(this.tbpSetupAndStatisticsJkra);
            this.tbcMainJkra.Location = new System.Drawing.Point(9, 26);
            this.tbcMainJkra.Margin = new System.Windows.Forms.Padding(2);
            this.tbcMainJkra.Name = "tbcMainJkra";
            this.tbcMainJkra.SelectedIndex = 0;
            this.tbcMainJkra.Size = new System.Drawing.Size(875, 404);
            this.tbcMainJkra.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(895, 441);
            this.Controls.Add(this.tbcMainJkra);
            this.Controls.Add(this.mspMainJkra);
            this.MainMenuStrip = this.mspMainJkra;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.mspMainJkra.ResumeLayout(false);
            this.mspMainJkra.PerformLayout();
            this.tbpSetupAndStatisticsJkra.ResumeLayout(false);
            this.tbpSetupAndStatisticsJkra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tbpTheRaceJkra.ResumeLayout(false);
            this.tbpTheRaceJkra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxRacerOneJkra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxRacerFourJkra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxRacerTwoJkra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxRacerThreeJkra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxRacerFourTrace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxRacerThreeTrace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxRacerTwoTrace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxRacerOneTrace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tbcMainJkra.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}


        private void btnClearRaceResultsJkra_Click(object sender, EventArgs e)
        {
            rtbRaceResultsJkra.Clear();
        }

        //private void rtbRaceResultsJkra_TextChanged(object sender, EventArgs e)
        //{
        //    throw new NotImplementedException();
        //}

        #endregion
        private System.Windows.Forms.Timer tmrMain;
		private System.Windows.Forms.SaveFileDialog diaFileSave;
		private System.Windows.Forms.OpenFileDialog diaFileOpen;
        private System.Windows.Forms.ToolStripMenuItem theRaceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mspMainAboutJkra;
        private System.Windows.Forms.ToolStripMenuItem msiTheRaceLocate;
        private System.Windows.Forms.ToolStripMenuItem mspMainQuit;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mspFileSaveAsJkra;
        private System.Windows.Forms.ToolStripMenuItem mspFileOpenJkra;
        private System.Windows.Forms.ToolStripMenuItem mspFileSaveAsCsvJkra;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mspMainViewTheRaceJkra;
        private System.Windows.Forms.ToolStripMenuItem mspMainViewLoggingJkra;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mspHelpUserManualJkra;
        private System.Windows.Forms.MenuStrip mspMainJkra;
        private System.Windows.Forms.TabPage tbpSetupAndStatisticsJkra;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblRacerFourRankUpDownJkra;
        private System.Windows.Forms.Label lblRacerThreeRankUpDownJkra;
        private System.Windows.Forms.Label lblRacerTwoRankUpDownJkra;
        private System.Windows.Forms.Label lblRacerOneRankUpDownJkra;
        private System.Windows.Forms.Label lblNrOfRacesJkra;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblRacerFourAverageJkra;
        private System.Windows.Forms.Label lblRacerOneAverageJkra;
        private System.Windows.Forms.Label lblRacerTwoAverageJkra;
        private System.Windows.Forms.Label lblRacerThreeAverageJkra;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnClearRaceResultsJkra;
        private System.Windows.Forms.RichTextBox rtbRaceResultsJkra;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnUpdateNamesJkra;
        private System.Windows.Forms.Button btnDefaultSetupJkra;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnSetUpRacersJkra;
        private System.Windows.Forms.TextBox txbMaxSpeedJkra;
        private System.Windows.Forms.Label lblRacerOneSpeedJkra;
        private System.Windows.Forms.Label lblRacerTwoSpeedJkra;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label lblRacerFourStepJkra;
        private System.Windows.Forms.Label lblRacerThreeSpeedJkra;
        private System.Windows.Forms.TextBox txbMinSpeedJkra;
        private System.Windows.Forms.Label lblRacerThreeStepJkra;
        private System.Windows.Forms.Label lblRacerFourSpeedJkra;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label lblRacerTwoStepJkra;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblRacerOneStepJkra;
        private System.Windows.Forms.CheckBox cbxDynamicSpeed;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbTrackSpeedJkra;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txbRacerOneNameJkra;
        private System.Windows.Forms.TextBox txbRacerTwoNameJkra;
        private System.Windows.Forms.TextBox txbRacerFourNameJkra;
        private System.Windows.Forms.TextBox txbRacerThreeNameJkra;
        private System.Windows.Forms.TabPage tbpTheRaceJkra;
        private System.Windows.Forms.Label lblRacerFourName;
        private System.Windows.Forms.Label lblRacerThreeName;
        private System.Windows.Forms.Label lblRacerTwoName;
        private System.Windows.Forms.Label lblRacerOneName;
        private System.Windows.Forms.Button btnResetPositionsJkra;
        private System.Windows.Forms.Label lblRacerFourStepActual;
        private System.Windows.Forms.Label lblRacerThreeStepActual;
        private System.Windows.Forms.Label lblRacerTwoStepActual;
        private System.Windows.Forms.Label lblRacerOneStepActual;
        private System.Windows.Forms.Panel pnlGetSet;
        private System.Windows.Forms.Label lblRaceTimeJkra;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblRacerFourFinishedPosition;
        private System.Windows.Forms.Label lblRacerThreeFinishedPosition;
        private System.Windows.Forms.Label lblRacerTwoFinishedPosition;
        private System.Windows.Forms.Label lblRacerOneFinishedPosition;
        private System.Windows.Forms.Button btnStartJkra;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlFinishLineJkra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlStartPositionsJkra;
        private System.Windows.Forms.PictureBox pbxRacerOneJkra;
        private System.Windows.Forms.PictureBox pbxRacerFourJkra;
        private System.Windows.Forms.PictureBox pbxRacerTwoJkra;
        private System.Windows.Forms.PictureBox pbxRacerThreeJkra;
        private System.Windows.Forms.PictureBox pbxRacerFourTrace;
        private System.Windows.Forms.PictureBox pbxRacerThreeTrace;
        private System.Windows.Forms.PictureBox pbxRacerTwoTrace;
        private System.Windows.Forms.PictureBox pbxRacerOneTrace;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabPage tbpStartScreenJkra;
        private System.Windows.Forms.TabControl tbcMainJkra;
        private System.Windows.Forms.PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private Label label3;
        private Label label19;
        private Label label18;
        private CheckBox cbxCantinaMusicJkra;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
