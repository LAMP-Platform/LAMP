# Feature Ideas
 * Undo / Redo
 * Go through Transition
 * Graphics Editor
 * Tileset Editor
 * Screen placing tool
 * Unique screen view
 * Clear screen / area data
 * better object displaying
 * Tweaks Editor

# Outside Editor things
 * write a more helpful readme.md
 * add more wiki documentation
 * add more code documentation (please someone do this for me D: )

# Increasing the amount of (theoretically) possible Tilesets
From what I have seen so far, being able to allow for more tilesets seems to be pretty simple.
GFX can already be loaded from any Bank.
The goal now would be to put the metatiles and collisions in seperate banks.
Solidity indices can be grouped together with the collisions

```
Bank $10
  ROM10:4000    Collision 00
  ROM10:4100    Collision 01
  ROM10:4200    Collision 02
  .
  .
  .
  ROM10:5F00    Collision 31
  
  ROM10:6000    Solidity Indices
  ROM10:6080    Collision Pointers

-----------------------------------

Bank $11
  ROM11:4000    Metatile table 00
  ROM11:4200    Metatile table 01
  ROM11:4400    Metatile table 02
  .
  .
  .
  ROM11:7C00    Metatile table 30

  ROM11:7E00    Metatile Pointers
```

The game already switches banks when loading a metatile set, collisions or solidity so we can just change up that byte.
* Metatile Bank `ROM0:282B 08 -> ??`
* Collision Bank `ROM0:285A 08 -> ??`
* Solidity Bank `ROM0:243B 08 -> ??`

After that the pointer to the pointer table would need to be adjusted as well
* Metatile pointer table `ROM0:283C 1A 7F -> ?? ??`
* Collision pointer table `ROM0:286B EA 7E -> ?? ??`
* Solditiy table `ROM0: 2443 FA 7E -> ?? ??`

Then its only a matter of actually moving the data in their respective banks.
The benefit of this approach is that it does not move any data around but just overwrites it.
A shortcoming here is that the screen transition command for loading a table only uses a single byte,
which means that the table index is the lower nybble and therefore only 16 sets can be reached.
The transition interpretation would need to be adjusted to read a whole second byte to allow for the full range.