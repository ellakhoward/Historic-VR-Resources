# Unity Setup for West End Project

> This setup creates an **individual Unity sandbox project** for learning Unity basics and building trigger-based interactions.  
> **Unity DevOps / Unity Version Control is not used in this course.**

---

## Video Tutorial (Optional)
For a visual walkthrough of this setup process, watch the screencast tutorial below.  
This video follows the **recommended beginner version** of Unity used by the instructor.

📺 https://go.screenpal.com/watch/cTnhXmnfW0v

---

## Initial Setup
1. Download and install **Unity Hub**
2. Install **Unity 2022 LTS**

> **Recommended for beginners:** Unity **2022.3.57f1 LTS** (matches instructor tutorials exactly)  
> **Advanced users:** You may use another **Unity 2022 LTS** version if you are comfortable adapting instructions

---

## Create New Project
1. Open **Unity Hub**
2. Click **New Project**
3. Select a **Unity 2022 LTS** version  
   - Beginners: **2022.3.57f1 LTS**  
   - Advanced users: another 2022 LTS version is acceptable
4. Choose **Universal 3D Core (URP)** template
5. Name your project:  
   **West_End_[YourName]**
6. Choose a project location **not in OneDrive**
7. Uncheck:
   - **Connect to Unity Cloud**
   - **Use Unity Version Control**  
   *(Unity DevOps is not used in this course)*
8. Click **Create Project**
9. Wait for Unity to open

---

## Add VR Support
1. Go to **Window → Package Manager**
2. Click the **+** button (top left)
3. Select **Add package by name**
4. Enter:
   ```
   com.unity.xr.interaction.toolkit
   ```
5. Click **Add**
6. When prompted about the Input System, click **Yes** to enable and restart Unity
7. After restart, in Package Manager:
   - Find **XR Interaction Toolkit**
   - Open **Samples**
   - Click **Import** next to **Starter Assets**
   - Click **Fix All** for any prompts
8. Close Package Manager

---

## Configure VR Settings
1. Go to **Edit → Project Settings**
2. Select **XR Plugin Management** (non-hyphenated)
3. Click **Install XR Plugin Management**
4. Select **XR Plug-in Management** (hyphenated)
5. Open the **Android** tab:
   - Check **Initialize XR on Startup**
   - Check **Oculus**

> If you do not see the **Android** tab, go to  
> **File → Build Settings → Switch Platform to Android** first.

---

## Set Up VR Scene
1. Delete the **Main Camera** from the Hierarchy
2. In the Project window, navigate to:  
   ```
   Assets → Samples → XR Interaction Toolkit → [version] → Starter Assets → Prefabs
   ```
3. Drag **XR Origin (XR Rig)** into the Hierarchy
4. In the Starter Assets folder:
   - Select **XRI Default Input Actions**
   - In the Inspector, click **Assign as project-wide input actions**
5. Position XR Origin for testing:
   - Select **XR Origin**
   - Set **Position Y = 1.6**

---

## Save Scene
Go to **File → Save Scene As**  
Name your scene:
```
WestEnd_Main
```

---

## Working in Unity (Desktop)

You can complete the following tasks on your laptop without a headset.

### 1. Navigate Scene View
- **Alt + Left Mouse** – Orbit
- **Alt + Right Mouse** – Zoom
- **Middle Mouse** – Pan
- **Select object + F** – Focus

### 2. Import and Set Up Models
- Import FBX models (**Scale Factor = 100**)
- Add materials and textures
- Position buildings
- Add colliders
- Set up trigger zones for interactions

### 3. Test in Game View
- Press **Play** to view the camera
- VR controls will not function
- Use Scene view to adjust placement
- Move XR Origin to test viewpoints

### 4. Add VR Components
- Add Teleportation Areas to ground surfaces
- Set up interaction points
- Add historical information trigger panels

---

Your instructor will do periodic VR builds so you can test in the headset.  
Focus on setting up your scene, materials, and trigger interactions correctly using **Scene** and **Game** views.
