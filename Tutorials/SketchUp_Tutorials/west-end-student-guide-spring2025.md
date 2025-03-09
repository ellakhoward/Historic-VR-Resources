# West End VR Modeling Project - Student Guide

## Video Tutorials
- [Map Scaling and Building Creation Tutorial](https://go.screenpal.com/watch/cTVu2CnfzUD)

## Team and Zone Assignments

Note: Initial block assignments are listed below. After the first round of modeling, teams may collaborate to redistribute blocks for more equitable workload distribution.

### Team Zones
- **Team 2**: Zone 2 Blocks: 148, 149, 150, 151, 152
- **Team 3**: Zone 3 Blocks: 122, 123, 124, 125, 155, 165, 166
- **Team 4**: Zone 4 Blocks: 153, 154, 156, 164
- **Team 5**: Zone 5 Blocks: 161B, 162B, 163, 169, 170, 170A, 171, 171A, 172
- **Team 6**: Zone 6 Blocks: 157, 158, 159, 160, 161A, 162A, 173, 174, 175, 176, 177A, 178

## Sprint Organization

Each team will have five sprints throughout the course, with each team member serving as Scrum Lead for one sprint.

## Immediate Actions Required:

1. Within your team (by next class):
   - Select a Scrum Lead for Sprint 1
   - Each team member should decide which blocks they will model

2. On the Brightspace sign-up sheet:
   - Write your selected Scrum Lead's name in the Sprint 1 slot
   - Sign up for your chosen blocks in your team's zone

3. Begin working on your assigned blocks:
   - Download and convert your zone map
   - Team should decide whose scaled map they will use—entire team is best off using same scaled map for ease of integration later
   - Start the SketchUp setup process
   - Basic building mass models are due February 3rd

## Initial Setup Process

### Base Map Setup

1. Locate and download your zone map from Brightspace
2. Convert the file to JPG or TIFF format (high resolution)
   - Can use Adobe, Photoshop, or online conversion tools
   - Ensure resolution quality is maintained
3. Import the map into SketchUp Pro
   - Select millimeters as the unit when creating the new model

### Map Scaling in SketchUp

1. Use the measuring tape tool to resize the model:
   - Find a line on the map with printed measurements
   - Click one end of the line with the measuring tape tool
   - Click the other end
   - Type the measurement in feet and inches (e.g., "45.6'")
   - Confirm the resize operation when prompted
2. Verify the scaling is correct
3. Share the properly scaled .SKP file with team members—team should use the same scaled map if possible

### Block Assignment

1. Access the block sign-up list in the same spreadsheet as the Scrum lead assignments
2. Each team member should sign up for their assigned block(s)

## Modeling Process

### Data Sources

- USB drives containing the database created by Sean Townsend
- OneDrive link (available on Brightspace) containing:
  - Building surveys
  - Reference photos

### Building Modeling Steps

1. Prepare the base layer:
   - Right click on the scaled map to select it
   - Make it a group
   - Lock it to prevent unwanted modifications

2. Create building models:
   - Trace building footprints
   - Use push/pull tool to create proper height
   - Focus on basic masses for now
   - Additional details will be discussed in class as workflow is finalized

3. Building organization:
   - Make each building a group
   - As you create a building, make it a group and name it
   - Name buildings using the convention: [block number].[parcel number]
   - Example: Block 152, Parcel 6 should be named "152.06"
   - Select all faces (triple-click) to ensure complete grouping

Note: Materials like brick textures will be added in Unity after import.

## SketchUp Technical Guide

### Basic Operations

1. Creating and Managing Groups:
   - Select all faces of an object by triple-clicking it
   - Right-click and select "Make Group" from the context menu
   - To edit a group: double-click it to enter group editing mode
   - To exit group editing mode: click outside the group
   - To unlock a locked group: right-click it and uncheck "Lock"

2. Naming Groups:
   - In the Outliner window (Window > Outliner)
   - Right-click the group
   - Select "Rename"
   - Use the block.parcel format (e.g., "152.06")
   - Groups must be named correctly for Unity import

3. Working with the Base Map:
   - After scaling your map, make it a group
   - Right-click and lock it to prevent accidental modifications
   - This ensures buildings won't accidentally attach to the map

### Building Heights

Three methods for determining building heights:

1. Using Historic Images:
   - Compare building heights in your reference photos
   - Use known heights of nearby buildings as reference
   - Count visible floors and multiply by typical floor height (10-12 feet per floor)

2. Floor Count Mathematical Approach:
   - Count the number of floors from historical data
   - Multiply by average floor height:
     - Residential floors: typically 10-12 feet
     - Ground floor retail: typically 12-15 feet
     - Example: 5-story residential building = 5 × 11' = 55' total height
   - In SketchUp, type the height when using Push/Pull tool (e.g., 55')

3. Photo Proportion Method:
   - If you have a photo of the building and know its width (from the map):
   - Measure the building's width and height in the photo (can use any units, like pixels or inches)
   - Use proportional math to calculate actual height:
     - Example: If in the photo the building is 2" wide and 3" tall,
     - And you know from the map the actual width is 25 feet,
     - Then: (3" × 25') ÷ 2" = 37.5' actual height
   - This works because: photo height/photo width = actual height/actual width

### Tips for Efficient Modeling

- Save frequently
- Keep groups organized and properly named
- Use the Outliner window to manage your groups
- Lock groups you're not currently editing to prevent accidents
- If a building gets "stuck" to another, undo and ensure you're working with proper groups
- Use the mouse scroll wheel to zoom in/out
- Middle mouse button to orbit (rotate view)
- Shift + middle mouse button to pan

## Communication and Support

### Contact Methods

- Instructor Email: howarde@wit.edu
- Drop-In Hours: Mondays 2:00-3:00 p.m.
- Office Location: Ira Allen 311
- Other meetings available by appointment

### Team Communication

- Team boards will be available on Brightspace this week for team coordination
- GitHub will be introduced next week for code management
- Teams should maintain regular communication through these channels

### Scrum Lead Responsibilities

1. Bring and use the team lanyard during meetings
2. Facilitate standup meetings (starting next week)
3. Ensure all team members participate in standups
4. Guide team check-ins regarding:
   - Current progress
   - Questions or blockers
   - Next steps

### Questions and Support

If you have questions or need clarification, you can:
- Email the instructor
- Raise issues during standup meetings
- Post questions on your team's Brightspace board
- Visit during drop-in hours
