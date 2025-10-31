# AR Solar System 🪐

An educational Augmented Reality (AR) application for Android, built with Unity 6 and Vuforia. Point your device's camera at a printed marker image to display an interactive 3D solar system. This project was developed as a final submission for the **CCS4361 — Immersive Technology Development** course.

!(https://github.com/tharukanandasiri/AR_SolarSystem/blob/main/readme-images/AR%20Solar%20System%20Image.png?raw=true)

---

## ✨ Features

* **Marker-Based AR** — Uses the Vuforia Engine to recognize a physical image marker and anchor the 3D scene.
* **Interactive 3D Solar System** — Renders Sun and planets in 3D.
* **Toggleable Planetary Orbits** — UI button to start/stop planetary orbits.
* **Realistic Relative Speeds** — Each planet orbits and rotates at a unique, scaled speed to reflect relative celestial motion.
* **URP Graphics** — Uses Unity’s Universal Render Pipeline (URP) for improved visuals.

---

## 🛠️ Technologies Used

* **Engine:** Unity 6
* **AR Framework:** Vuforia Engine
* **Render Pipeline:** Universal Render Pipeline (URP)
* **Platform:** Android

---

## 🚀 Getting Started

### Prerequisites

* Unity Hub and Unity Editor (Version 6 or newer).
* Android Build Support installed in your Unity Editor (including SDK, NDK, and OpenJDK).
* Git and **Git LFS** installed on your machine.

> ⚠️ **Important:** This repository uses Git LFS for large 3D model files. Install Git LFS before cloning so large files download correctly.

### Install Git LFS

Open your terminal / Git Bash and run:

```bash
# Install Git LFS (one-time)
git lfs install
```

Refer to the official Git LFS docs for OS-specific installers if needed.

---

### Clone the Repository

```bash
git clone https://github.com/tharukanandasiri/AR_SolarSystem.git
```

(When cloning, Git LFS will automatically fetch tracked large files.)

---

## How to Use the Project

1. Open **Unity Hub**, click **Add** and select the cloned project folder.
2. Launch the project using the Unity Editor (use the same Unity version used to create the project, or a compatible one).
3. Open the main scene: `Assets/Scenes/AR Solar System.unity`.
4. Press **Play** in the editor to test with your webcam (Vuforia will use the default webcam).
5. Print or display the AR marker image (see below) and show it to your webcam to trigger the AR solar system.

---

## AR Marker

You must print or display the marker image to trigger the AR experience. For best results, use a matte (non-glossy) print.

!(https://github.com/tharukanandasiri/AR_SolarSystem/blob/main/readme-images/AR%20Marker.png?raw=true)

> Replace the image link above with your actual marker image (or upload a higher-resolution version). For a nicer demo, replace the preview screenshot with a GIF showing the working app.

---

## Building for Android

1. In Unity, go to **File > Build Settings**.
2. Select **Android** and click **Switch Platform** (if not already active).
3. Ensure your scene (`AR Solar System`) is the only one checked in the **Scenes In Build** list.
4. Configure Player Settings as needed (package name, min SDK, target SDK, graphics settings).
5. Click **Build** (or **Build And Run**) to generate the `.apk` (or `.aab`) file.
6. Transfer the generated `.apk` to your Android device and install it (enable installation from unknown sources if required).

---

## Troubleshooting

* **AR marker not recognized:** Ensure good lighting, flat matte print, and that the marker is not reflective or distorted.
* **Webcam testing in Editor:** Some webcams require allowing access or selecting the correct device in Vuforia/Webcam settings.
* **Large file issues when cloning:** Confirm Git LFS was installed prior to cloning; otherwise re-clone after installing Git LFS.
* **Build errors on Android:** Verify Android Build Support (SDK/NDK/OpenJDK) is installed and check Player Settings for correct package ID and minimum API level.

---

## Contributing

If you want to improve this project (fixes, optimizations, or new features), feel free to open an issue or submit a pull request. Please keep large binary changes tracked with Git LFS.

---

## Contact

Created by Tharuka Nandasiri — feel free to open an issue on the repository or contact me for questions or collaboration.

---

Enjoy exploring the AR Solar System! 🚀
