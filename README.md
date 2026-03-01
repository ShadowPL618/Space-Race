# Space-Race
Galactic Race is a Windows Forms-based racing simulation that brings the thrill of Star Wars podracing to your desktop. Users can configure up to four legendary racers, adjust track dynamics, and watch them compete in a real-time race with authentic sound effects and dynamic speed shifts.

✨ Features
Real-time Racing Simulation: Watch four racers (defaulting to Baron Soontir Fel, Anakin, Luke, and Han Solo) compete across the track.

Dynamic Speed Logic: Toggle the "Velocity Increment" feature to simulate mid-race engine shifts and pilot skill adjustments.

Authentic Star Wars Atmosphere:

Cantina Music: Loop the iconic Cantina band theme during your session.

Sound Effects: Custom ship start sounds and finish line fanfares.

Lore-friendly Quotes: Post-race logs feature randomized quotes from Yoda, Han Solo, and more.

Detailed Statistics & Logging:

Track average positions across multiple races.

Automatic "up/down rank" indicators.

Full race result logging with export-to-file capability.

User Manual Integration: Accessible PDF manual directly from the Help menu.

🛠️ Technical Stack
Language: C#

Framework: .NET Framework (Windows Forms)

Audio Library: NAudio (for MP3/WAV playback and UI-thread-safe audio management)

Architecture: Object-Oriented Design using a csRacerBase class to handle physics and positioning.

📸 Screenshots
Setup and Statistics
Configure your racers, adjust the "Hyperspace Constant" (track speed), and view historical performance.

Launch Screen
The immersive entry point to the Galactic Race.

🚦 How to Use
Configure: Navigate to the SetupAndStatistics tab to enter racer names and set the min/max engine output.

Initialize: Click Setup Racers to calculate step sizes and prepare the ships.

Race: Go to The Race tab and hit START!.

Reset: After a winner is crowned, click Reset to return ships to the starting gate.

Save: Use the File > Save As menu to export your race results log to a .txt file.

📁 Project Structure
Form1.cs: The main UI logic and race controller.

csRacerBase.cs: The logic for racer movement, speed calculation, and finish-line detection.

Properties/: Contains the required audio assets (Cantina_Music.mp3, Ship_Start.mp3, finish.wav).

doc/: Contains the Manual.pdf user documentation.
