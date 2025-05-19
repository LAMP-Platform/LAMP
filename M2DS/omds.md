# Specification for the **Open Metroid 2 Data Specsheet**
#### Version 0.X - 06.01.2025

## Overview
The Open Metroid 2 Data Specsheet (OMDS) represents an advanced iteration of the LAMP Datafiles, originally designed to store all necessary data for compiling a Metroid 2 hack within the LAMP Editor.
OMDS introduces a layer of abstraction above the LAMP Datafiles, transitioning from their binary-like structure to a more human-readable format. The purpose of OMDS is to articulate the hack designer's vision for their project, emphasizing clarity and accessibility. 
A key objective of OMDS is to provide editor independence. This means that users have the flexibility to manually edit the files if desired, without relying on a specific tool or editor.

# Rooms
Rooms represent the highest data level in OMDS. They are a combination of many other datafiles.

### **tileset** - *(File)*
References the standard tile graphics that are supposed to be loaded in the room

### **sprites** - *(File)*
References the standard sprite graphics that are supposed to be loaded in the room

### ***music** - *(Integer)*
Standard music track to play in the room.

### ***spikes** - *(Integer)*
Standard damage of spikes in the room.

### ***acid** - *(Integer)*
Standard damage of acid in the room.

### ***states** - *(List\<States\>)*
Depending on the current Metroid count, different states of the room can be loaded. Each entry in the list defines one state.  
Each state must define at least:
- **metroids** - *(Integer)*  
The state gets loaded if the current Metroid counter is equal or less than the given value

And optionally:
- **tileset** - *(File)*
- **sprites** - *(File)*
- **music** - *(Integer)*
- **spikes** - *(Integer)*
- **acid** - *(Integer)*

### **screens** - *(List\<Screens\>)*
List of screens that get used in the room and their location in the room. Screens can be reused multiple times throughout a project.  
A screen must define the following:
- **screen** - *(File)*
- **position** - *(Integer, Integer)*

Optionally, camera constraints can be set:
- **camera** - *(Boolean, Boolean, Boolean, Boolean)*  
If set to true, camera is blocked in the directions: up, right, down, left

### ***objects** - *(List\<Sprites\>)*
Objects (sometimes referenced as Sprites) are defined through a list.  
Each entry must define:
- **id** - *(String)*  
id or name of the object
- **position** - *(Float, Float)*

Optionally, it can also be defined if an object is removed forever after destruction/collection:
- **remove** - *(Boolean)*