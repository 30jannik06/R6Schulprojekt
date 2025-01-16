
# R6Schulprojekt -  Just a Simple Recoil Tool

R6Schulprojekt ist eine Windows Forms Anwendung in C#, die für Rainbow Six Siege entwickelt wurde. Die Anwendung simuliert einen Recoil Control Mechanismus, der den Mauszeiger basierend auf der gewählten Spielfigur (Operator) nach unten bewegt.

❗❗Edcuational Purposes only❗❗

❗❗It's your own fault if you get a ban.❗❗
## Features

- **Operator Auswahl:** Auswahl verschiedener Operatoren mit unterschiedlichen Rückstoßwerten.
- **Recoil Control:** Automatische Mausbewegung zur Kontrolle des Rückstoßes.
- **Custom Recoil:** Anpassbare Rückstoßwerte über einen Slider.
- **Fenstersteuerung:** Minimieren, Schließen und Dragging des Fensters über die Top-Bar


## Vorraussetzungen

- .NET Framework 4.8 oder höher
- Visual Studio


## Installation

1. **Repository klonen:**

```bash
  git clone https://github.com/30jannik06/R6Schulprojekt.git
```

2. **Projekt öffnen:**
- Öffne das Projekt in Visual Studio.

3. **Projekt kompilieren:**
- F5 zum Kompilieren und starten der Anwendung.
## Nutzung

1. **Starten der Anwendung:**
- Beim Start werden Operatoren geladen.

2. **Operator auswählen:**
- Wähle einen Operator aus der Dropdown-Liste aus.

3. **Recoil Control Aktivieren:**
- Check `Toggle Recoil` aktivieren.

4. **Custom Recoil:**
- Option `Custom Recoil` aktivieren und Slider anpassen.

5. **Schließen:
- Über den Close-Button oder `X` oben rechts.
## Code-Struktur

```bash
R6Schulprojekt/
├── Properties/               # Projekteinstellungen
├── Verweise/                 # Projektverweise
├── Forms/
│   └── BaseWindow.cs         # Haupt-UI und Recoil-Logik
├── Resources/                # Ressourcen (Icons, Bilder)
├── System/
│   └── Windows/              # Windows-spezifische Hilfsklassen
├── Utils/                    # Hilfsfunktionen für UI-Effekte
│   ├── ApplyBackground.cs
│   ├── FadeInAnimation.cs
│   └── RoundedCorners.cs
├── App.config                # Konfigurationsdatei
├── Logo.ico                  # Icon-Datei
├── Logo.png                  # Logo der Anwendung
├── Program.cs                # Einstiegspunkt der Anwendung
└── README.md                 # Diese Datei
```
## License
Dieses Projekt steht unter der MIT-Lizenz.  
[MIT](https://github.com/30jannik06/R6Schulprojekt/blob/master/LICENSE)


## Authors

Github  [@30jannik06](https://www.github.com/30jannik06)
| Discord [@.Jannik](https://discordapp.com/users/268084996235853824)

Viel Spaß beim Spielen! 🎮
## VirusTotal 

[LINK to Scan](https://www.virustotal.com/gui/file/6ad86f8dc5b59e07313108c78aae08c605d9237cbd39296af2c4170a3084d41a/detection)
