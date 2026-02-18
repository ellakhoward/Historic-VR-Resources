# Navigation and StoryCart in Unity

Build and compare two navigation models:

1. **User-driven navigation** (walking through space)  
2. **Designer-driven navigation** (content moves toward the user)

We are exploring movement as a storytelling decision.

---

# PART 1 — USER-DRIVEN NAVIGATION (Walking)

## Step 1 — Import XR Device Simulator

1. Window → **Package Manager**  
2. Select **XR Interaction Toolkit**  
3. Click the **Samples** tab  
4. Expand:
   - **XR Interaction Toolkit**
   - **(current Version)**
   - **XR Device Simulator**
5. Click **Import**

---

## Step 2 — Add XR Device Simulator to the Scene

In the Project window:

Samples → XR Interaction Toolkit → (version) → XR Device Simulator

Drag the **XR Device Simulator prefab** into the **Hierarchy**.

---

## Step 3 — Standardize Player Orientation

Select **XR Origin (XR Rig)**.

Set Transform:
- Position: **(0, 1.6, 0)**
- Rotation: **(0, 180, 0)**

> Rotation Y = 180 ensures you face toward the cubes (negative Z direction).

---

## Step 4 — Create Ground Plane

Hierarchy → Right-click → **3D Object → Plane**

Rename: `Ground`

Set:
- Position: **(0, 0, -10)**
- Scale: **(5, 1, 5)**

---

## Step 5 — Add Landmark Cubes

### Cube_A
- Position: **(0, 0.5, -5)**

### Cube_B
- Position: **(2, 0.5, -10)**

### Cube_C
- Position: **(-2, 0.5, -15)**

These give visible reference points for movement.

---

## Step 6 — Test Walking (Desktop)

Press **Play**.

Click inside the **Game** view so it has focus.

Use:
- **W A S D** to move
- Move the **mouse** to rotate your view

Look for the cubes and walk toward them.

**Observation:**  
You move. The world stays still.  
This is user-driven navigation.

---

## STOP PLAY

Click the big **Play** button again to exit Play mode.  
Do not build new objects while still in Play mode.

---

# PART 2 — DESIGNER-DRIVEN NAVIGATION  
**Content Moves Toward the User**

Now we reverse the model:

The user stays still.  
The content approaches.

Useful for:
- Archival storytelling
- Guided interpretation
- Accessibility
- Seated or “arcade cabinet” experiences

---

# Step 1 — Create the StoryCart Container

Hierarchy → Right-click → **Create Empty**

Rename: `StoryCart`

Set:
- Position: **(0, 0, -20)**

> StoryCart is a container. It moves multiple objects together as one unit.

---

# Step 2 — Add a Facade (Visual Surface)

Right-click StoryCart → **3D Object → Cube**

Rename: `Facade`

Set:
- Position: **(0, 1.5, 0)**
- Scale: **(6, 3, 0.2)**

**Facade = physical surface**  
Later it could be:
- A Quad with a historic photo texture
- A map excerpt
- A building façade
- A projection surface

---

# Step 3 — Add a Canvas (Text Layer)

Right-click StoryCart → **UI → Canvas**

Select Canvas:
- Render Mode: **World Space**
- Scale: **(0.01, 0.01, 0.01)**
- Position: **(0, 2.5, 0.3)**

Inside Canvas:

Right-click → UI → **Text (TextMeshPro)**

Set text: 1955 Demolition Begins


### If the text appears backwards:
Select the **Text** object and set:
- Rotation Y = **180**

**Facade = object**  
**Canvas = interpretive label**

---

# Step 4 — Create the Movement Script

In Project window:

Create Folder → `Scripts`

Inside Scripts:

Right-click → Create → **C# Script**

Name: `StoryCartMover_Simple`

Replace contents with:

```csharp
using UnityEngine;

public class StoryCartMover_Simple : MonoBehaviour
{
    public float startZ = -20f;
    public float endZ = -12f;
    public float durationSeconds = 8f;

    Vector3 startPos;
    Vector3 endPos;
    float t;

    void Start()
    {
        startPos = new Vector3(transform.position.x, transform.position.y, startZ);
        endPos   = new Vector3(transform.position.x, transform.position.y, endZ);

        transform.position = startPos;
        t = 0f;
    }

    void Update()
    {
        if (durationSeconds <= 0f) return;

        t += Time.deltaTime / durationSeconds;
        t = Mathf.Clamp01(t);

        transform.position = Vector3.Lerp(startPos, endPos, t);
    }
}
```
## Step 5 — Attach the Script

1. Select `StoryCart`.
2. Drag `StoryCartMover_Simple` onto it.

Set the following values in the Inspector:

- `startZ = -20`
- `endZ = -12`
- `durationSeconds = 8`

> **Note:**  
> `endZ` controls how close the panel stops.  
> You can manually position `StoryCart` in Scene view to find a comfortable stopping distance, then use that Z value here.

---

## Step 6 — Test Guided Motion

1. Press **Play**.
2. Do not move.

Observe:

- The panel begins at a distance.
- It approaches.
- It stops in front of you.

If the panel appears behind you:

- Confirm `XR Origin` Rotation Y = `180`.

---

# Comparing the Two Navigation Models

## Walking Model

- User agency  
- Exploration  
- Spatial continuity  

## Guided Approach Model

- Controlled pacing  
- Directed attention  
- Reduced locomotion  
- Strong for interpretive storytelling  

Both are valid design decisions.

Navigation shapes interpretation.

---

# Adapting and Expanding the StoryCart

The StoryCart pattern is flexible. It is not just a moving cube.

---

## 1. Moving Image Panels

Replace the `Facade` with a **Quad** and apply a historic image texture.

This becomes a moving archival photo panel.

---

## 2. Text-Only Narrative Cards

Remove the `Facade` and use only the Canvas + Text.

This creates moving chapter headings or story beats.

---

## 3. Conveyor Belt of Archives

Create multiple StoryCarts or reuse one cart while swapping images and text.

This creates:

- A demolition timeline  
- A strip of primary sources  
- A seated “arcade-style” experience where scenes approach the viewer  

---

## 4. Triggered StoryCart

Instead of starting automatically on Play, you could:

- Trigger movement when the user enters a doorway  
- Trigger movement with a button press  

This blends exploration with guided narrative moments.

---

## 5. Relation to Splines

StoryCart is conceptually related to splines.

- Both choreograph movement in space  
- Splines allow curved paths and complex motion  
- StoryCart uses straight-line motion for beginner simplicity  

You can later evolve this into spline-based sequences.

---

# End of Lab Outcome

By the end of this lab you should have:

- Walkable desktop navigation (WASD)  
- A guided moving interpretive panel  
- An understanding that navigation is a design decision  

Navigation is not just mechanics.  
It is interpretation.
