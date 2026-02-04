# Unity Setup for West End Project (Unity 6.3)

This setup creates an individual Unity sandbox project for learning Unity basics and building trigger-based interactions. Unity DevOps / Unity Version Control is not used in this course.

---

## Initial Setup

1. Download and install **Unity Hub**
2. Install **Unity 6000.3.6f1 LTS**

---

## Create New Project

1. Open **Unity Hub**
2. Click **New Project**
3. Select **6000.3.6f1**
4. Choose **Universal 3D Core (URP)** template
5. Name your project: `West_End_[YourName]`
6. Choose a project location **not in OneDrive**
7. Uncheck:
   * Connect to Unity Cloud
   * Use Unity Version Control (Unity DevOps is not used in this course)
8. Click **Create Project**
9. Wait for Unity to open

---

## Add VR Support

### Install XR Interaction Toolkit

1. Go to **Window → Package Manager**
   * (In Unity 6.3, this may appear as: Window → Package Management → Package Manager)
2. Click the **+** button (top left)
3. Select **Add package by name**
4. Enter:
```
   com.unity.xr.interaction.toolkit
```
5. Click **Install**
6. Wait for the package to download and import

> **Note:** In Unity 6.3, you typically will not get an Input System prompt because it's already enabled by default.

### Import Starter Assets

1. In the **Package Manager** window, select **XR Interaction Toolkit** from the list
2. Look for the **Samples** section on the right
3. Click **Import** next to **Starter Assets**
4. When prompted, click **Fix All** to resolve validation issues
   * If **TextMeshPro Essentials** doesn't auto-fix:
     * Go to **Window → TextMeshPro → Import TMP Essential Resources**
     * Click **Import** in the popup window
5. Close the **Package Manager** window

---

## Add Android Build Support

Before configuring VR settings, you need to add Android as a build platform for Meta Quest/Oculus support.

1. Go to **File → Build Profiles** (this replaces "Build Settings" in older Unity versions)
2. You should see **Android** in the platform list with a status message
3. If Android shows **"No module loaded"**:
   * Click **Install with Unity Hub**
   * Unity Hub will open automatically
   * Check all dependencies:
     * OpenJDK
     * Android SDK & NDK Tools
   * Click **Install** (this may show as "12 updates" or similar)
   * Wait for installation to complete (10-20 minutes depending on internet speed)
4. Close Unity Hub and **reopen your project** from Unity Hub
5. Go to **File → Build Profiles** again
6. Click **Enable** next to Android
7. Click **Switch Platform** (not Android XR, just Android)
8. Wait for platform switch to complete (a few minutes)

---

## Configure VR Settings

1. Go to **Edit → Project Settings**
2. In the left sidebar, click **XR Plugin Management** (non-hyphenated)
3. Click **Install XR Plugin Management**
4. After installation, click **XR Plug-in Management** (hyphenated) in the left sidebar
5. You should now see platform tabs at the top
6. Click the **Android, Android XR** tab (the one with two robot icons)
7. Check the following boxes:
   * **Initialize XR on Startup**
   * **Oculus**
8. Leave the other options (Google ARCore, OpenXR, Unity Mock HMD) unchecked

---

## Set Up VR Scene

### Delete Default Camera

1. In the **Hierarchy** window, right-click **Main Camera**
2. Select **Delete**

### Add XR Origin

1. In the **Project** window, navigate to:
```
   Assets → Samples → XR Interaction Toolkit → [version] → Starter Assets → Prefabs
```
   * The version number will be something like "3.0.5" or similar
2. Drag **XR Origin (XR Rig)** (or just "XR Origin") into the **Hierarchy**

### Configure Input Actions

1. In the **Project** window, navigate to:
```
   Assets → Samples → XR Interaction Toolkit → [version] → Starter Assets
```
2. Select **XRI Default Input Actions** (blue icon)
3. In the **Inspector**, click **Assign as project-wide input actions**

### Position XR Origin for Testing

1. Select **XR Origin** in the Hierarchy
2. In the **Inspector**, find the **Transform** component
3. Set **Position Y = 1.6** (eye height in meters for standing VR)

---

## Save Scene

1. Go to **File → Save** (or Save As)
2. Save in the **Scenes** folder
3. Name your scene: `WestEnd_Main`

> **Important:** Never save your own work in the **Assets → Samples** folder. This folder is managed by the Package Manager and your files could be overwritten during package updates.

---

## License

These resources are provided for educational purposes. Please credit if using in your own projects.

---

## Contact

For questions or assistance, contact Professor Ella Howard, School of Sciences and Humanities at Wentworth Institute of Technology (howarde@wit.edu) or open an issue in this repository.
