# Creating Building Information Triggers in Unity VR

## Video Tutorial
For a detailed visual demonstration, watch the [screencast tutorial](https://go.screenpal.com/watch/cTnTVanhWsX).

*Follow these steps after completing the initial Unity VR setup and importing your SketchUp model*

## 1. Configure Input System

1. Go to Edit → Project Settings → Player
2. Find "Active Input Handling" under "Other Settings"
3. Change from "Both" to "Input System Package (New)"
4. Click "Apply" when prompted to restart Unity
5. Wait for Unity to restart

## 2. Create Scripts Folder

1. In Project window, right-click in Assets folder
2. Select Create → Folder
3. Name it "Scripts"
4. All scripts should be saved in this folder, not in Starter Assets folders

## 3. Create UI Elements

1. In Hierarchy, right-click → UI → Canvas
2. In Canvas, right-click → UI → Panel
3. In Panel, create two text elements:
   - Right-click → UI → Text - TextMeshPro (twice)
   - Name them "TitleText" and "DescriptionText"

## 4. Set Up Panel and Text

1. Select Panel in Hierarchy:
   - In Image component
   - Set Color to black (RGB: 0,0,0)
   - Set Alpha to 204 (80% opacity)

2. Position Canvas in scene:
   - Set to World Space
   - Scale: X: 0.001, Y: 0.001, Z: 0.001
   - Position: X: 0, Y: 1.7, Z: -3 (adjust relative to your building)

3. Adjust Text settings:
   - TitleText: Font Size 72, Position Y: 50
   - DescriptionText: Font Size 48, Position Y: -50

## 5. Create and Position Objects

1. For testing, position elements appropriately:
   - XR Origin: Position: X: 0, Y: 0, Z: -5
   - Main Camera (under Camera Offset): Y: 1.6 (eye level)
   - Building/Model: Position: X: 0, Y: 0, Z: 0
   - Canvas: Position: X: 0, Y: 1.7, Z: -3

2. Your final layout should be:
   - Player starts behind the trigger zone
   - Trigger zone is between player and building
   - Info panel appears at eye level when triggered

## 6. Create Trigger Zone

1. Create Empty GameObject:
   - Name it "BuildingTriggerZone"
   - Position: X: 0, Y: 1, Z: -2 (between camera and building)

2. Add Components to BuildingTriggerZone:
   - Add Box Collider
   - Check "Is Trigger"
   - Size: X: 2, Y: 2, Z: 2 (large enough to walk through)
   - Add Rigidbody
   - Check "Is Kinematic"
   - Uncheck "Use Gravity"

## 7. Set Up Main Camera

1. Find Main Camera under XR Origin/Camera Offset
2. Add Components:
   - Add Capsule Collider
   - Height: 1.6, Radius: 0.3
   - Add Rigidbody
   - Set Rigidbody to "Is Kinematic"
   - Uncheck "Use Gravity"
3. Set Tag to "Player"

## 8. Add BuildingTrigger Script

1. Create new script:
   - In Project window, navigate to your Scripts folder
   - Right-click → Create → C# Script
   - Name it "BuildingTrigger"
   - Copy the provided script code

2. Add script to BuildingTriggerZone:
   - Drag script onto BuildingTriggerZone
   - Or Add Component → Scripts → BuildingTrigger

## 9. Connect Everything

1. Select BuildingTriggerZone in Hierarchy
2. In BuildingTrigger component (Inspector):
   - Drag Panel to "Panel Object"
   - Drag TitleText to "Title Text Object"
   - Drag DescriptionText to "Description Text Object"
3. Fill in your building information:
   - Add building name
   - Add building description

## Testing Your Trigger

1. Keep all objects (Canvas, Panel, TitleText, DescriptionText) active
2. Build to Quest
3. When you walk into trigger zone:
   - Black panel should appear
   - Text should display your building information
4. Walking away should hide everything

## Adjusting for Your Building

Once the basic setup is working, adjust positions to fit your specific building:
- Place trigger zone in front of your building entrance or viewpoint
- Position Canvas near but not obscuring the building
- Ensure trigger zone is sized appropriately for your space

## Troubleshooting

- If script doesn't appear in components list:
  - Make sure it's saved in your Scripts folder (not Starter Assets)
  - Check Console for compilation errors
  - Try restarting Unity if issues persist

- If trigger doesn't work:
  - Verify Main Camera has "Player" tag
  - Check Box Collider is large enough
  - Ensure all script connections are made
  - Check Console for error messages

- If text is hard to read:
  - Adjust Panel opacity (Alpha value)
  - Change text size
