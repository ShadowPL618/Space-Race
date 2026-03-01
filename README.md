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
<img width="911" height="482" alt="Screenshot 2026-03-01 144246" src="https://github.com/user-attachments/assets/48ce4731-e30f-4443-a268-e4cedb864bb7" />
<img width="916" height="483" alt="Screenshot 2026-03-01 144233" src="https://github.com/user-attachments/assets/7cec0629-3147-4539-a941-6ee78ad9926c" />
<img width="915" height="480" alt="Screenshot 2026-03-01 144240" src="https://github.com/user-attachments/assets/d4be0bbb-39c9-483d-a50d-b5f5172bc76f" />



Launch Screen
The immersive entry point to the Galactic Race.

🚦 How to Use
Configure: Navigate to the SetupAndStatistics tab to enter racer names and set the min/max engine output.

Initialize: Click Setup Racers to calculate step sizes and prepare the ships.

Race: Go to The Race tab and hit START!.

Reset: After a winner is crowned, click Reset to return ships to the starting gate.

Save: Use the File > Save As menu to export your race results log to a .txt file.
