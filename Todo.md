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
We can change the game code to read 2 bytes per table load instead of 1 though. The second byte will then be
the table index.

Read second byte for Metatile table: `ROM0:2832 2A E5 E6 0F -> 23 2A E5 00`
Read second byte for Collision table: `ROM0:2861 2A E5 E6 0F -> 23 2A E5 00`
Read second byte for Solidity table: `ROM0:242F 2A E5 E6 0F -> 23 2A E5 00`

The syntax for the metatile table is now `10 XX` where `XX` is the table index < $7F
It is similar with the other tables.

Due to the limits of 8 bit shifting, the highest possible index is now **only** $7F (127), which should be more than enough
tilesets. However, with more code changes this limit could also be raised.
Lastly, all transitions will have to be updated because the opcodes for graphics loading now use more bytes.

To allow for an almost infinite amount of tilesets, we could either use the unused nybble to reference a source bank 
or add yet another byte to allow for every bank to be reached.
For the former idea it would probably make sense to have the bank value as a relative offset, since the banks $0-$F are already
used up and this way each table type could have up to $F unique banks assigned.

# Increasing the amount of total Areas usable