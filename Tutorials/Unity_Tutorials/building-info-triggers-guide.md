# CSAS2000 — Unity Sandbox Lab: Building Information Triggers  
**Unity 6.3 | Interaction First, Meaning First**

This lab takes place in an individual Unity sandbox project.  
We are proving that **historical information can appear in space through interaction**.

We are *not* aiming for visual polish yet.

---

## Starting Point (Already Completed)

You should already have:
- An **XR Origin (XR Rig)** in the scene
- A **ground plane**
- **Two cubes** acting as stand-in buildings
- Basic materials applied

---

## Step 0 — Make a Copy of the Scene (Required)

We will duplicate the current scene so we can experiment safely.

1. In the **Project** window, locate your current scene file
2. Right-click → **Duplicate**
3. Rename the copy:
4. Double-click the duplicated scene to open it

You should still see:
- XR Origin
- Ground plane
- Two cubes
- Light / Volume (if present)

---

## Learning Goal

By the end of this lab, you will have:
- A player that can approach a building
- An information panel that appears when the player gets close
- Readable text displayed in the scene

---

## Part 1 — Player Setup

1. Select **XR Origin (XR Rig)** in the Hierarchy
2. In the Inspector:
- Set **Tag → Player**
3. Set Transform:
- Position: **X 0, Y 0, Z -10**

If the building feels very close at first, that is okay.  
We will fix staging later.

---

## Part 2 — Prepare One Test Building

1. Select **one cube**
2. Rename it:
3. Set Transform:
- Position: **X 0, Y 0, Z 0**
- Scale: **X 6, Y 6, Z 6**
- Position **Y = 3** (half the height, so it sits on the ground)

This cube represents the mass of a building.

---

## Part 3 — Create a World-Space Canvas

> **Unity 6.3 note:** The menu is **UI (Canvas)**

1. Hierarchy → Right-click → **UI (Canvas) → Canvas**
2. Rename:
3. In the Inspector:
- **Render Mode:** World Space
- **Scale:**  
  - X **0.001**  
  - Y **0.001**  
  - Z **0.001**
- **Position:**  
  - X **0**  
  - Y **1.7**  
  - Z **-4**
- **Rotation:**  
  - X 0  
  - Y **180**  
  - Z 0

The panel may be hard to see at first. This is normal.

---

## Part 4 — Create the Panel

1. Right-click **BuildingInfoCanvas**
→ **UI (Canvas) → Panel**
2. Leave the name as **Panel**

### Panel Settings
- Anchor Preset: **Middle Center**
- Width: **600**
- Height: **300**

**Image Component**
- Color: Black
- Alpha: **204** (semi-transparent)

---

## Part 5 — Add Text

### Title Text
1. Right-click **Panel**
→ **UI (Canvas) → Text – TextMeshPro**
2. Rename:
3. Rect Transform:
- Width: **560**
- Height: **80**
- Pos Y: **50**
4. Text:
- Font Size: **72**
- Alignment: Center
- Text:
  ```
  Historic Building
  ```

---

### Description Text
1. Right-click **Panel**
→ **UI (Canvas) → Text – TextMeshPro**
2. Rename:
3. Rect Transform:
- Width: **560**
- Height: **160**
- Pos Y: **-50**
4. Text:
- Font Size: **48**
- Alignment: Top Center
- Text:
  ```
  Information about this building appears when you approach.
  ```

---

## Part 6 — Create the Trigger Zone (Important)

The trigger zone detects when the player is close to the building.

### 6.1 Create the Trigger Object
1. Hierarchy → Right-click → **Create Empty**
2. Rename:
3. Set Transform:
- Position: **X 0, Y 1, Z -6**

---

### 6.2 Add a Box Collider
1. Add **Box Collider**
2. Check:
- **Is Trigger**
3. Size:
- X **2**
- Y **2**
- Z **2**

**What this does:**  
The collider defines the detection space.  
Because it is a trigger, it does *not* block movement.

---

### 6.3 Add a Rigidbody (Why This Matters)
1. Add **Rigidbody**
2. Set:
- **Is Kinematic** ✔
- **Use Gravity** ✘

**Why we add a Rigidbody:**  
Unity requires at least one object in a trigger interaction to have a Rigidbody.

**What “Is Kinematic” means:**  
- Unity tracks the object
- Physics are disabled
- The object exists only for detection, not movement

---

## Part 7 — Create the Script

1. In **Assets**, create a folder named:
2. Open the folder
3. Right-click → **Create → Scripting → Empty C# Script**
4. Name:
5. Open the script and replace all contents with the **BuildingTrigger** script provided in class
6. Save the script

### Attach the Script
1. Select **BuildingTriggerZone**
2. Drag **BuildingTrigger.cs** onto the Inspector

### Assign References
In the **BuildingTrigger** component:
- Panel Object → **Panel**
- Title Text Object → **TitleText**
- Description Text Object → **DescriptionText**

---

## Part 8 — Test in Play Mode

1. Press **Play**
2. Switch to the **Game** tab
3. Select **XR Origin**
4. Adjust Position Z:
- **-10** → building may feel very close
- **-6** → trigger activates, panel appears

If the text appears backwards:
- Select **BuildingInfoCanvas**
- Change **Rotation Y** to **0** or **180** (whichever reads correctly)

---

## Part 9 — Fix the Staging (Expected)

World-space UI behaves like physical objects and often needs adjustment.

1. Select **BuildingInfoCanvas**
2. Move it **to the side**:
- X **4**
- Y **1.7**
- Z **-6**
3. If needed, increase scale slightly:
- **0.002, 0.002, 0.002**

---

## What to Submit

### 1. Screenshot
Submit **one screenshot** showing:
- A cube
- A readable information panel with the title **“Historic Building”**

---

### 2. Written Component (Classwork / Homework)

#### A. Panel Text (Public-Facing)
Choose **one building** from the West End project files.

- **Title:** 5–10 words  
- **Description:** **100–150 words**

This text should read like a museum or historical marker.

---

#### B. Interpretation Explanation (Reflection)
Write **150–250 words** answering:
- Why did you choose this building?
- What makes it historically significant?
- What information did you include, and why?
- What did you leave out?
- What additional research or information would you want to make this panel more meaningful?

---

## Key Takeaway

Today you proved that **interaction creates meaning**.  
Visual refinement will come later.

