# Unity Setup for West End Project

## Video Tutorial
For a visual walkthrough of this setup process, watch the [screencast tutorial](https://go.screenpal.com/watch/cTnhXmnfW0v).

## Initial Setup
1. Download and install Unity Hub
2. Install Unity 2022.3.57f1 LTS 

## Create New Project
1. Open Unity Hub
2. Click "New Project"
3. Select Unity 2022.3.XX LTS
4. Choose "3D Core" template
5. Name your project: "West_End_[YourName]"
6. Choose location (not in OneDrive)
7. Uncheck both "Connect to Unity Cloud" and "Use Unity Version Control"
8. Click "Create Project"
9. Wait for Unity to open

## Add VR Support
1. Window → Package Manager
2. Click "+" in top left
3. Choose "Add package by name"
4. Type: "com.unity.xr.interaction.toolkit"
5. Click "Add"
6. When prompted about input system, click "Yes" to enable and restart
7. After restart, in Package Manager: 
   - Find "XR Interaction Toolkit"
   - Click "Samples"
   - Click "Import" next to "Starter Assets"
   - Click "Fix All" for any prompts
8. Close Package Manager

## Configure VR Settings
1. Edit → Project Settings 
2. Click on XR Plugin Management (non-hyphenated version)
3. Click "Install XR Plugin Management" button
4. Click on XR Plug-in Management (hyphenated version)
5. In Android tab: 
   - Check "Initialize XR on Startup"
   - Check "Oculus"

## Set Up VR Scene
1. Delete Main Camera from Hierarchy
2. In Project window navigate to: Assets → Samples → XR Interaction Toolkit → [version] → Starter Assets → Prefabs
3. Drag "XR Origin (XR Rig)" into Hierarchy
4. Back in Starter Assets folder: 
   - Select "XRI Default Input Actions"
   - In Inspector, click "Assign as the project-wide input actions"
5. Position XR Origin for testing: 
   - Select XR Origin in Hierarchy
   - Set Position Y to 1.6

## Save Scene
File → Save Scene As → "WestEnd_Main"

## Working in Unity (Desktop)
You can do these tasks on your laptop:

### 1. Navigate Scene View
- Alt + Left Mouse = Orbit around objects
- Alt + Right Mouse = Zoom in/out
- Middle Mouse = Pan
- Select object + F key = Focus on object

### 2. Import and Set Up Models
- Import FBX models (Scale Factor = 100)
- Add materials and textures 
- Position buildings
- Add colliders
- Set up trigger zones for interactions

### 3. Test in Game View
- Press Play to see camera view
- Cannot teleport or use VR controls
- Use Scene view to check different angles
- Position XR Origin to test different viewpoints

### 4. Add VR Components
- Add Teleportation Area to ground surfaces
- Set up interaction points
- Add historical information triggers

Your instructor will do periodic VR builds so you can test in the headset. Focus on getting your buildings, materials, and interactions set up correctly using the Scene and Game views for testing.
