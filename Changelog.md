# Version R 1.0
### Released: XX.XX.202X
**Changes:**
* Transition Editor rework
* Transitions can be named
* Added error messages if too many objects or transitions exist
* Tileset Editor redesign
* Added Graphics & Metatile Editor
* Added Solidity Editor
* Added Collision Editor
* Tilesets can be exported and imported
* Transitions can be exported and imported
* Object settings are now part of the main window
* Added button to automatically assign object number
* Project specific base ROMs
* The project path on the recent files screen can now be opened in explorer
* Added a value converter tool
* LAMP now starts in fullscreen if closed in fullscreen
* Tile displays now highlight tiles that can not currently be displayed by LAMP
* Removed redundant data from the project files
* Added special options to the Save Editor
* Added a Data Chunk Manager
* Added the ability to clear an entire area
* Added the ability to replace tiles with a different tile
 
**Fixes:** 
* Objects: Empty screens might not be compiled as empty
* Objects: When optimizing objects no empty set is written
* TestROM: Tilesets with an index >= 10 cause an exception
* TestROM: Missile values are capped at 0xFF
* TestROM: Wrong math on the energy value
* TestROM: Player sometimes spawns at the bottom of the screen
* Room Editor: Zooming out with the hotkey enables the zoom out button even though it shouldnt
* Room Editor: Zooming in with the hotkey can zoom past the limit
* Tileset Editor: Combobox for Tileset is not properly sized to fit the names

# Version B 4.0
### Released: 02.06.2023
**Changes:**
* Main Window layout redesign
  * Room View and Data View resizeable
  * "View" tab removed
* Slight Save Editor layout changes
* Recent Files
* Data Viewer
  * Basic Hex Viewer of the ROM Data, practically useles
* Header Buttons
  * Show Objects
  * Show Scrolls
* Toolbar for every tile based display
* Zooming
  * Every tile based display can be zoomed
* Copy & Paste
  * Copy and paste the seleted tiles
  * Works between instances of LAMP
* More object alignments
  * Shift - Tile center
  * Alt - Tile corner
  * Shift & Alt - Tile center, edge and corner
* Compilation Settings  

**Fixes:**
* Controls all appear at once now when loading a project
* Selected tiles in the room no longer continuously reselect
* Predefined tilesets now come with predefined collision values


# Version B 3.1
### Released: 01.04.2023  
**Fixes:**
* TestROM now actually works with modified data


# Version B 3.0
### Released: 30.03.2023
**Changes:**
* Test ROM
  * Game can now be tested from anywhere
* Save File editing
  * Initial Savegame can be changed
* Help button
  * Access to Wiki
  * Report Bugs
* Automatic Update Checking


# Version B 2.0
### Released: 16.02.2023
**Changes:**
* Tileset Editor
  * Tilesets can be predefined
  * Tilesets can be used instead of direct offsets
  * All standard Tilesets included by default
* Added project settings
* Added app settings
* New offset interpretation
  * Prefix can be chosen
  * Display offsets as Bank:Offset or direct Offset
* Scroll boundaries can be displayed
  * F4 Hotkey  

**Fixes:**
* F5 Hotkey should now work all the time
* Scroll bars reset when switching Area banks


# Version B 1.0
### Released: 24.08.2022
**Changes:**
* Initial Release