# Guide: Applying Materials to Architectural Models in Unity

## Video Tutorial
For a detailed visual demonstration, watch the [screencast tutorial](https://go.screenpal.com/watch/cTn3nKnhL59).

## Initial Setup and Organization

1. Export your model from SketchUp as an FBX file

2. Select and Download Materials:
   - Visit Ambient CG or similar site
   - We don't want to overwhelm the model, so teams should decide on around 5 brick textures and 5 wood textures
   - Download 1K resolution packages
   - Each texture package includes: Color, Normal, Roughness, and Ambient Occlusion maps

## Unity Project Organization

1. Create folders in Project window:
   - Right-click → Create → Folder
   - Make two folders:
     - Materials
     - Textures
       - Create Bricks and Wood subfolders

2. Import texture files:
   - Drag and drop texture packages into appropriate Textures subfolder
   - Keep organized within Bricks and Wood folders

## Creating Materials

1. Create new material:
   - In Project window, go to Materials folder
   - Right-click → Create → Material
   - Name it clearly (e.g., "Red_Brick_01", "Dark_Wood_01")

2. Set up the material:
   - Select your new material
   - In Inspector, set Shader to "Universal Render Pipeline/Lit"
   - Assign textures using circle selector for each:
     - Base Map: Select _Color.jpg
     - Normal Map: Select _NormalGL.jpg
     - Metallic Map: Select _Roughness.jpg
     - Occlusion Map: Select _AmbientOcclusion.jpg

## Applying Materials

1. In Scene view, select your FBX model
2. In Inspector, find Material section
3. Either:
   - Drag material from Project window onto model
   - Or use material selector in Inspector

## Adjusting Scale

1. Select material in Project window
2. In Inspector, find Tiling under Surface Inputs
3. Start with these values:
   - X: 0.02 (horizontal)
   - Y: 0.03 (vertical)
4. Adjust until texture looks correct scale for your building

## Sharing with Team

1. After creating materials you want to share:
   - Save your materials and texture files
   - Upload them to your team's GitHub directory
   - Let team members know what tiling values worked well

2. When using shared materials:
   - Download materials and textures from GitHub
   - Import them into your Unity project's folders

## Troubleshooting

If texture appears solid color:
- Verify all texture maps are correctly assigned
- Check tiling values (if too high, texture appears solid)
- Ensure scene has adequate lighting
- Try creating fresh material if issues persist

## Tips for Success

- Preview materials on test object before applying to building
- Keep consistent 1K texture resolution for performance
- Use clear, descriptive material names
- Document successful tiling values
- Check with team before downloading new materials

Remember: Quality materials can dramatically improve your building's appearance while maintaining good performance. Take time to adjust tiling values for realistic scale.
