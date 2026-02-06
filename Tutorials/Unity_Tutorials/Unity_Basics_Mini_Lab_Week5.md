# CSAS2000 — Unity Basics Mini-Lab (Week 5: Setup Day)

**Purpose**  
Set up Unity **together in class** and build confidence with the Unity editor.  
Today focuses on **orientation, navigation, and control**, not interactions.

You do **not** need prior Unity experience.

---

## What You Will Have by the End of Class
- A working **individual Unity sandbox project**
- A saved scene (any name)
- Two visible stand-in “buildings” (cubes) and a ground plane
- **Three materials** (two building colors, one ground color)
- Confidence navigating **Scene vs Game** view
- A screenshot to submit on Brightspace

---

## Part 0 — Create Your Unity Project (In Class)

Follow the **Unity Setup for West End Project** guide with your instructor.

Pause here until:
- Unity opens successfully
- **XR Origin** is visible in the Hierarchy
- You are inside *your own* project

If something does not look right, raise your hand **now**.

---

## Part 1 — Save Your Scene

1. Go to **File → Save Scene As**
2. Save the scene:
   - Location: anywhere in your project (you can move it later)
   - Name: **any clear name you choose**

> You are not combining scenes this term.  
> The exact scene name does **not** matter — saving does.

---

## Part 2 — Create Stand-In “Buildings”

We’ll use cubes today instead of real buildings.

1. In the **Hierarchy**:
   - Right-click → **3D Object → Cube**
2. Rename the cube:
   - Right-click on the name → **Rename**
   - Name it: `Test_Building_Cube`
3. Set **Transform** values:
   - Position: `X 0, Y 1, Z 0`
   - Scale: `X 2, Y 2, Z 2`
4. Duplicate the cube:
   - Right-click → **Duplicate** (or Ctrl/Cmd + D)
5. Rename the copy:
   - `Test_Building_Cube_02`
6. Move the second cube slightly to the side

---

## Part 3 — Create and Modify the Ground

1. In the **Hierarchy**:
   - Right-click → **3D Object → Plane**
2. Rename it:
   - Right-click the name → **Rename**
   - `Ground`
3. Resize the ground:
   - Select **Ground**
   - In the **Inspector**, set **Scale**:
     - X: **5**
     - Y: **1**
     - Z: **5**

> Scaling the ground gives you room to work and makes spatial relationships clearer.

---

## Part 3.5 — Moving Objects Through Other Objects (Important)

1. Select `Test_Building_Cube`
2. Choose the **Move tool** (press **W**)
3. Drag the **green (Y) arrow**:
   - Move the cube **down through** the ground
   - Move it **back up above** the ground

> Unity does not prevent objects from overlapping in the editor.  
> It is your job to place things correctly.

---

## Part 4 — Create and Apply Materials (Two Building Colors + One Ground Color)

You will create **three materials**.

1. In the **Project** window:
   - Click **Assets**
   - Create or open a folder named `Materials`

2. Create the first building material:
   - Right-click → **Create → Material**
   - Name it: `Mat_Building_01`
   - Select it and set a **bright Base Color**

3. Create the second building material:
   - Right-click → **Create → Material**
   - Name it: `Mat_Building_02`
   - Select it and set a **different bright Base Color**

4. Create the ground material:
   - Right-click → **Create → Material**
   - Name it: `Mat_Ground`
   - Select it and set a **neutral or contrasting Base Color**

5. Apply materials:
   - Drag `Mat_Building_01` onto `Test_Building_Cube`
   - Drag `Mat_Building_02` onto `Test_Building_Cube_02`
   - Drag `Mat_Ground` onto `Ground`

---

## Part 5 — Unity Navigation Basics (Scene View)

1. Click a cube in the Hierarchy
2. Press **F** to focus
3. Mouse navigation:
   - **Alt + Left Mouse** → orbit
   - **Alt + Right Mouse** → zoom
   - **Middle Mouse** → pan

### WASD (Scene Camera Only)
- Click inside the **Scene** tab
- **Right-click and hold**
- Use **W A S D** to move
- Use **Q / E** to move down / up

> WASD works only while holding right-click in the Scene view.

---

## Part 6 — Understanding Colliders (Observation Only)

1. Select `Test_Building_Cube`
2. In the **Inspector**, find **Box Collider**
3. Uncheck it, then re-check it

> Colliders control interaction and physics — we’ll use them later.

---

## Part 7 — Scene vs Game View and Play Mode

1. Select **XR Origin**
2. Set **Position Z = -2**
3. Click **Play**
4. While Play Mode is running:
   - Switch between **Scene** and **Game** tabs
5. Stop Play Mode:
   - Click the **Play** button again

> Scene view = editor camera  
> Game view = player camera

---

## Part 8 — Basic Project Organization

Inside **Assets**, you should see folders such as:
`Samples`, `Scenes`, `Settings`, `TMP`, `XR`, `XRI`

If they do not already exist, create:
- `Materials`
- `Models`
- `Scripts`

> Do not modify folders inside `Samples`, `XR`, or `XRI`.

---

## What to Submit (Screenshot)

Upload **one screenshot** showing:
- Unity editor open
- Hierarchy with:
  - `XR Origin`
  - Two building cubes
  - `Ground`
- Scene view with clearly **different colors** applied

---

## What We Are *Not* Doing Today
- No scripts
- No UI
- No trigger panels
- No VR builds

Those come **next class**.
