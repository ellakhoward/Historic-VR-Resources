# Guide: Textures and Historic Photo Facades

## Video Tutorial
For a detailed visual demonstration of last year's lab where we created textures and materials and applied them to .fbx models exported from SketchUp, watch the [screencast tutorial](https://go.screenpal.com/watch/cTn3nKnhL59).

---

# Part 1 — Applying a Texture Material to a Cube (URP)

## Objective
Learn how to:
- Import texture maps
- Create a URP material
- Apply it to geometry
- Adjust tiling for correct scale

---

## Step 1 — Create Test Geometry

1. In the **Hierarchy**:
   - Right-click → 3D Object → Cube
2. Rename the cube: `Brick_Test`
3. Set **Scale**:
   - X: 10  
   - Y: 5  
   - Z: 0.5  

---

## Step 2 — Organize the Project

In the **Project** window, create folders:

- `Materials`
- `Textures`
  - `Bricks`
  - `Wood`
  - `Facades`

---

## Step 3 — Import Texture Maps

Download a **1K** material set from AmbientCG.

Place files in:
`Textures → Bricks`

You should have:
- `_Color`
- `_NormalGL`
- `_Roughness`
- `_AmbientOcclusion`

---

## Step 4 — Create a Material

1. Go to `Materials` folder.
2. Right-click → Create → Material.
3. Name it: `Red_Brick_01`.

Select the material and configure:

**Shader:**  
`Universal Render Pipeline / Lit`

Assign:
- **Base Map** → `_Color`
- **Normal Map** → `_NormalGL`  
  (Click **Fix Now** if prompted)
- **Occlusion Map** → `_AmbientOcclusion`

Set:
- **Metallic = 0**
- Leave **Metallic Map empty**
- **Smoothness ≈ 0.15**

> Do not assign the Roughness map directly.

---

## Step 5 — Apply Material to Cube

Either:
- Drag material onto cube in Scene view  
OR  
- Select cube → Mesh Renderer → Assign material

---

## Step 6 — Adjust Tiling

Select the material.

Under **Tiling**:

Start with:
- X = 0.2
- Y = 0.2

Adjust until brick scale appears realistic.

---

# Part 2 — Applying a Historic Facade Image to a Quad

## Objective
Apply a historic building photo correctly to geometry using proper proportions.

---

## Step 1 — Import Facade Image

Place the processed façade image into:
`Textures → Facades`

Select the image in the Project window.

In Inspector:
- **Texture Type:** Default
- **sRGB:** Checked
- **Max Size:** 1024
- **Compression:** Normal

Click **Apply**.

---

## Step 2 — Create Facade Material

1. Go to `Materials` folder.
2. Create → Material.
3. Name it: `Facade_01`.

Configure:

**Shader:**  
`Universal Render Pipeline / Lit`

Assign:
- **Base Map** → façade image

Set:
- **Metallic = 0**
- **Smoothness = 0.1–0.2**

---

## Step 3 — Create Quad

1. Hierarchy → Right-click → 3D Object → Quad
2. Rename: `Facade_01`
3. Apply the façade material to the quad.

---

## Step 4 — Correct Aspect Ratio

Find image dimensions (example: `1536 × 1024`).

Calculate: Width ÷ Height

Example: 1536 ÷ 1024 = 1.5

Set quad scale so: X ÷ Y = aspect ratio

Examples:
- X = 1.5, Y = 1
- X = 7.5, Y = 5
- X = 15, Y = 10

> Do not distort the image.

---

## Step 5 — Align to Ground

Adjust **Position Y** so the bottom of the façade meets the ground plane.

---

# End-of-Class Requirements

Each student must:

1. Add one additional façade to the scene.
2. Correct its proportions.
3. Place it next to the demo building.
4. Take two screenshots:
   - Demo façade
   - Their added façade
5. Submit **5 sentences** explaining:
   - Which image they used
   - The source of the image
   - How they scaled it correctly
   - What adjustments they made
   - One observation about working with historic photos in 3D space







Remember: Quality materials can dramatically improve your building's appearance while maintaining good performance. Take time to adjust tiling values for realistic scale.
