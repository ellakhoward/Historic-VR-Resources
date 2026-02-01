# Creating Building Information Triggers in Unity VR

## Video Tutorial (Optional)
For a detailed visual demonstration, watch the screencast tutorial below.  
This video follows the instructor’s Unity setup and is most useful if you are using the recommended Unity version.

📺 https://go.screenpal.com/watch/cTnTVanhWsX

*Follow these steps after completing the initial Unity VR setup and importing your SketchUp model.*  
*This tutorial is completed inside your **individual Unity sandbox project**, not a shared team project.*

---

## 1. Verify Input System (Skip if Already Enabled)

If you enabled the Input System during XR setup, this may already be configured correctly.  
Only complete this section if instructed or if your triggers are not working.

1. Go to **Edit → Project Settings → Player**
2. Find **Active Input Handling** under **Other Settings**
3. Set it to **Input System Package (New)**
4. Click **Apply** when prompted to restart Unity
5. Wait for Unity to restart

---

## 2. Create Scripts Folder

1. In the Project window, right-click in the **Assets** folder
2. Select **Create → Folder**
3. Name the folder **Scripts**
4. All scripts should be saved in this folder (not inside Starter Assets)

---

## 3. Create UI Elements

1. In the Hierarchy, right-click → **UI → Canvas**
2. In the Canvas, right-click → **UI → Panel**
3. In the Panel, create two text elements:
   - Right-click → **UI → Text - TextMeshPro** (twice)
   - Name them **TitleText** and **DescriptionText**

---

## 4. Set Up Panel and Text

1. Select **Panel** in the Hierarchy:
   - In the Image component:
     - Color: **Black (RGB 0,0,0)**
     - Alpha: **204** (about 80% opacity)

2. Position the Canvas in the scene:
   - Render Mode: **World Space**
   - Scale: **X 0.001, Y 0.001, Z 0.001**
   - Position: **X 0, Y 1.7, Z -3** (adjust relative to your building)

3. Adjust Text settings:
   - **TitleText**: Font Size **72**, Position Y **50**
   - **DescriptionText**: Font Size **48**, Position Y **-50**

---

## 5. Create and Position Objects

For testing, position elements approximately as follows:

- **XR Origin**: Position **X 0, Y 0, Z -5**
- **Main Camera** (under **XR Origin → Camera Offset**): Y **1.6**
- **Building / Model**: Position **X 0, Y 0, Z 0**
- **Canvas**: Position **X 0, Y 1.7, Z -3**

Your final layout should follow this logic:
- Player starts behind the trigger zone
- Trigger zone is between player and building
- Information panel appears at eye level when triggered

---

## 6. Create Trigger Zone

1. Create an empty GameObject:
   - Name it **BuildingTriggerZone**
   - Position: **X 0, Y 1, Z -2** (between camera and building)

2. Add the following components:
   - **Box Collider**
     - Check **Is Trigger**
     - Size: **X 2, Y 2, Z 2**
   - **Rigidbody**
     - Check **Is Kinematic**
     - Uncheck **Use Gravity**

---

## 7. Set Up Main Camera

1. Locate **Main Camera** under **XR Origin → Camera Offset**
2. Add components:
   - **Capsule Collider**
     - Height: **1.6**
     - Radius: **0.3**
   - **Rigidbody**
     - Set **Is Kinematic**
     - Uncheck **Use Gravity**
3. Set the Camera **Tag** to **Player**

---

## 8. Add BuildingTrigger Script

1. Create a new script:
   - In **Assets → Scripts**, right-click → **Create → C# Script**
   - Name it **BuildingTrigger**
   - Paste in the provided script code

2. Add the script to **BuildingTriggerZone**:
   - Drag the script onto the object  
   **or**
   - Use **Add Component → Scripts → BuildingTrigger**

---

## 9. Connect Everything

1. Select **BuildingTriggerZone** in the Hierarchy
2. In the **BuildingTrigger** component (Inspector):
   - Drag **Panel** to **Panel Object**
   - Drag **TitleText** to **Title Text Object**
   - Drag **DescriptionText** to **Description Text Object**
3. Enter your building information:
   - Building name
   - Building description

---

## Testing Your Trigger

1. Make sure all UI elements (Canvas, Panel, TitleText, DescriptionText) are **active**
2. Test in **Play Mode** (and/or Quest if available)
3. Walk into the trigger zone:
   - Panel should appear
   - Text should display your building information
4. Walk away:
   - Panel and text should disappear

> Your instructor will handle most Quest builds.  
> Focus on correct trigger behavior using **Play Mode**.

---

## Adjusting for Your Building

Once the basic setup works:
- Place trigger zones near entrances or viewpoints
- Adjust Canvas position so it does not block the building
- Resize trigger zones to fit the space

---

## Troubleshooting

**Script does not appear:**
- Confirm it is saved in **Assets/Scripts**
- Check the Console for errors
- Restart Unity if needed

**Trigger does not activate:**
- Confirm Main Camera is tagged **Player**
- Ensure the Box Collider is large enough
- Verify all Inspector references are assigned
- Check the Console for error messages

**Text is hard to read:**
- Increase panel opacity
- Increase font size
