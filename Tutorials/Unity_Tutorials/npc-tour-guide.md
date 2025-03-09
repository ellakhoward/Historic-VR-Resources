# Step-by-Step Guide: Setting Up a VR Tour Guide NPC in Unity

## Video Tutorial
For a detailed visual demonstration, watch the [screencast tutorial](https://go.screenpal.com/watch/cTenYrn1F6k).

Follow these instructions to create an interactive NPC that walks back and forth, stops when approached, displays information text, and plays audio narration.

## 1. Set Up the NPC Character

1. **Create the NPC container:**
   - Right-click in Hierarchy → Create Empty
   - Name it "WestEndNPC"
   - Position: X: 0, Y: 0, Z: -3

2. **Create the paper doll character:**
   - Right-click in Hierarchy → 3D Object → Quad
   - Name it "PaperDollImage"
   - Make it a child of WestEndNPC (drag onto WestEndNPC)
   - Position: X: 0, Y: 1, Z: 0
   - Scale: X: 1, Y: 1.7, Z: 1

3. **Set up your character image:**
   - Import your 1950s character PNG with transparency
   - Create a material: Right-click in Project → Create → Material → name it "PaperDollMaterial"
   - Set the material Shader to "Universal Render Pipeline/Lit"
   - Set Surface Type to "Transparent"
   - Drag your PNG into the Base Map slot
   - Apply the material by dragging it onto PaperDollImage

4. **Create walking points:**
   - Right-click in Hierarchy → Create Empty → name it "WalkPoint_A"
   - Position: X: -3, Y: 0, Z: -3
   - Right-click in Hierarchy → Create Empty → name it "WalkPoint_B"
   - Position: X: 3, Y: 0, Z: -3

## 2. Create the Dialogue UI

1. **Create a canvas:**
   - Right-click on WestEndNPC → UI → Canvas
   - Name it "DialogueCanvas"
   - In the Canvas component:
     - Set Render Mode to "World Space"
     - Scale: X: 0.01, Y: 0.01, Z: 0.01
   - **Important:** Uncheck the canvas to make it inactive initially

2. **Add a panel:**
   - Right-click on DialogueCanvas → UI → Panel
   - Set color to black with Alpha around 200
   - Size: Width: 500, Height: 250
   - Make sure it's checked (active)

3. **Add text:**
   - Right-click on Panel → UI → Text - TextMeshPro
   - Configure the text:
     - Font Size: 48
     - Color: White
     - Alignment: Center
     - Make sure it's checked (active)

## 3. Add Audio Support

1. **Add an AudioSource:**
   - Select WestEndNPC
   - Add Component → Audio → Audio Source
   - Uncheck "Play On Awake"
   - Set Spatial Blend to 1 (3D)

2. **Import your audio narration clip** to your Assets folder

## 4. Add Required Scripts

1. **Create and add the NPCWalking script:**
   - Create a new C# script named "NPCWalking"
   - Copy the complete script code
   - Add the script to WestEndNPC
   - Assign references:
     - Drag WalkPoint_A to Point A
     - Drag WalkPoint_B to Point B
     - Set Walk Speed to 0.7

2. **Create and add the NPCDialogueManager script:**
   - Create a new C# script named "NPCDialogueManager"
   - Copy the complete script code
   - Add the script to WestEndNPC
   - Assign references:
     - Drag DialogueCanvas to Dialogue Canvas
     - Drag the TextMeshPro to Dialogue Text
     - Set Detection Radius to 3
     - Enter your tour guide text in the Dialogue Content field
     - Drag the AudioSource to Audio Source
     - Drag your audio clip to Dialogue Audio

3. **Create and add the DialogueCanvasHelper script:**
   - Create a new C# script named "DialogueCanvasHelper"
   - Copy the complete script code
   - Add the script to DialogueCanvas

## 5. Final Check

1. **Verify hierarchy:**
   - WestEndNPC (active)
     - PaperDollImage (active)
     - DialogueCanvas (inactive)
       - Panel (active)
         - TextMeshPro (active)

2. **Verify components and references:**
   - WestEndNPC has NPCWalking and NPCDialogueManager scripts
   - All script references are properly assigned
   - DialogueCanvas has DialogueCanvasHelper script

3. **Test in Play mode:**
   - The NPC should walk back and forth between points
   - Approaching within 3 meters should stop the NPC
   - The dialogue panel should appear with text
   - Audio should play when close

When you build for VR, the NPC will function as a tour guide that walks back and forth until approached, then stops to provide information through both text and audio before resuming walking when the player moves away.
