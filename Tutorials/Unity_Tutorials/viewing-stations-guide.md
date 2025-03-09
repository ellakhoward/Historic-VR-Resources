# Creating Viewing Stations in VR

This guide walks you through creating viewing stations that show present-day views of Boston's West End within your historical reconstruction.

## Finding Historical-to-Present Locations

1. **Use Atlascope to identify locations**:
   * Go to atlascope.org
   * Navigate to Boston's West End area
   * View the 1938 Sanborn maps overlaid on current geography
   * Identify significant buildings or locations in your zone

2. **Find precise coordinates**:
   * Open Google Maps in another browser window
   * Navigate to the same location you identified in Atlascope
   * Right-click the exact spot and select "What's here?"
   * Record the coordinates that appear (e.g., 42.361954, -71.067584)

3. **Document the location's significance**:
   * Note what historically existed at this spot
   * Note what currently exists there
   * Record why this location shows an important transformation

## Creating Your Viewing Station Content

### For Edge/Perimeter Locations (Skybox Panoramas)

1. **Capture 360° panorama**:
   * Navigate to your chosen location in Google Maps Street View
   * Install the "Street View Download 360" browser extension
   * Open Street View at your chosen location
   * Click the extension icon
   * Paste the URL from Google Maps Street View
   * Save the JPG file with a descriptive name

2. **Record audio narration** (optional):
   * Write a brief script about the location's history and transformation
   * Record using any audio recording software (Audacity, Voice Recorder, etc.)
   * Keep length to 30-45 seconds for best user experience
   * Save as MP3 format
   * Recommended settings: 44.1kHz, 128kbps, mono

### For Interior Locations (Framed Photos)

1. **Capture directional screenshots**:
   * In Google Maps Street View, navigate to your location
   * Take screenshots of specific views in different directions
   * Capture what would be visible from that specific spot
   * Save images as JPG or PNG files

2. **Prepare caption information**:
   * Write brief text explaining what the viewer is seeing
   * Include dates, building names, and significant changes

## Implementing in Unity

### For Skybox Panoramas

1. **Import the panorama image**:
   * Drag your downloaded JPG into your Unity Project panel
   * In the Inspector, set:
      * Texture Type: Default
      * Texture Shape: 2D
      * Check "sRGB (Color Texture)"
      * Set Alpha: "Input Texture"
      * Apply these settings

2. **Create a skybox material**:
   * Right-click in Project panel → Create → Material
   * Name it "PanoramaView_[Location]"
   * Set Shader to "Skybox/Panoramic"
   * Configure settings:
      * Exposure: 1
      * Rotation: 0
      * Click selector next to "Spherical HDR" and select your panorama image
      * Mapping: Latitude Longitude
      * Image Type: 360 Degrees

3. **Import audio** (if using):
   * Drag your MP3 file into your Unity Project panel
   * In Inspector, ensure:
      * Force To Mono: checked (for spatial audio)
      * Load In Background: checked
      * Compression Format: Vorbis
      * Quality: 70% (good balance of quality/size)

4. **Create viewing station marker**:
   * Create a cylinder: GameObject → 3D Object → Cylinder
   * Name it "ViewingStation_[Location]"
   * Set Transform:
      * Scale X: 1.5, Y: 0.01, Z: 1.5 (flat disc)
      * Position at ground level where your historical location was
   * Add material:
      * Create a new material with a distinctive color
      * Add texture or pattern to make it noticeable

5. **Add required components**:
   * Box Collider:
      * Add Component → Physics → Box Collider
      * Check "Is Trigger"
      * Size: X: 1.5, Y: 1, Z: 1.5 (tall enough to detect player)
   * Audio Source (if using audio):
      * Add Component → Audio → Audio Source
      * Uncheck "Play On Awake"
      * Spatial Blend: 1 (fully 3D)
      * Volume: 1
      * Assign your audio clip

6. **Add the ViewingStationTrigger script**:
   * Create new script: Right-click in Project → Create → C# Script
   * Name it "ViewingStationTrigger"
   * Double-click to open and paste the code from the Scripts folder
   * Save the script
   * Add Component → Scripts → ViewingStationTrigger
   * Assign your panorama material to "Present Day Skybox"
   * If using audio, drag your audio clip to "Location Audio"

## Testing Your Viewing Stations

1. **Make sure the player has the correct tag**:
   * Select your XR Origin or player object
   * Set its Tag to "Player"

2. **Play test in editor**:
   * Walk onto the viewing station marker
   * Check if view changes to the present-day panorama
   * Move away to see if it reverts to the historical view
   * Verify audio plays correctly if implemented

3. **Adjust as needed**:
   * Fine-tune positions, collider sizes, and trigger distances
   * Adjust audio volume and panorama exposure
   * Make sure viewing stations are discoverable but not obtrusive