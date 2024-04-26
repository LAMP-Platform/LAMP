# TODOS

## 'til next release
* Finish Graphics Editor

## Feature Ideas
* Add more Undo/Redo capabilities by capsulating code in Actions
* Go through Transition
* Screen preview in screen settings
* Screen placing tool
* Unique screen view
* better object displaying
* Compile to IPS

## Outside Editor things
* write a more helpful readme.md
* add more wiki documentation
* add more code documentation (please someone do this for me D: )


# BRAINSTORMING

## Increasing the amount of (theoretically) possible Tilesets
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

Due to the limits of 8 bit shifting, the highest possible index is now **only** $7F (127), which should be more than enough tilesets. However, with more code changes this limit could also be raised.  
Lastly, all transitions will have to be updated because the opcodes for graphics loading now use more bytes.

To allow for an almost infinite amount of tilesets, we could either use the unused nybble to reference a source bank 
or add yet another byte to allow for every bank to be reached.  
For the former idea it would probably make sense to have the bank value as a relative offset, since the banks $0-$F are already used up and this way each table type could have up to $F unique banks assigned.

## Increasing the amount of total Areas usable
*Todo*

## Transition editor, opcode syntax edit
Right now all the opcodes are hardcoded into LAMP. In the future, however, people might want to alter
the data that the editor writes in order to comply with their custom code. Because of this I will
try to implement an opcode "programming" language.

Examples:
* `(1)Select metatile table, ()Table ID`
* `(4)Warp, ()Bank, ()Screen Y, ()Screen X`
* `[90]If, []Metroids Alive <=, {}Goto Transition`

Rules:  
Each line represents 1 Opcode.  
Opcodes are split into parts by commas.  
A part can consist of text and a data template.  
Possible data templates:  
* `()` - The next Nybble  
* `[]` - The next Byte
* `{}` - The next Pointer (2 Bytes)  

Each part can only have 1 data template.  
Each part can have one string. (Before or after the data template, order does not matter)  
The first part in each opcode will be the title.  
Each part after the first one will be considered a parameter.  
The first data template will not be displayed.   
A data template may have a predefined value.  
A predefined value will not be displayed.  
A data template may not contain text.  

### Alternative language
Examples:
* `Warp [0](4), to Bank [1], X [3], Y [2]`
* `If [0;1](90), Metroids Alive <= [2], Goto Transition [3;4]`
  * [x;y] - Indicates that the value is for the Nybbles from x through y
  * (x) - Predefines a value for the last data template

### Another Alternative language
For some reason the earlier implementations are very complicated to understand?  
In hinsight they are pretty dumb to setup.

**Rules:**  
A opcode is defined by a single string, split into parts by commas.  
Each part will get represented as a single line in LAMP.  
The first part is the header.  
**The header consists out of:**
- Opcode ID - **(REQUIRED)**
- Parameter
- Name - **(REQUIRED)**

Parameters can be defined by using an identifier. Repeating the same indentifier increases the range of values.  
The location of the identifier inside the header affects the final location of the parameter in ROM.  

Example:  
* `"4b yx: Warp"`
* `"E0 bb gg: Load Palette"`

The character groups `[A-F][1-9]` are reserved for the Opcode ID.  
The character groups `[a-z][G-Z]` can be used as parameter identifiers.  
After the header, the parts can be used to specify information about the parameter.  
A parameter can be given a name, by writing the parameter identifier at the beginning of a line, followed by a `:`. Everything after `:` will be displayed as the name.  

Example:
* `"4b yx: Warp, b: Bank, x: Screen X, y: Screen Y"`
* `"E0 bb oo: Load Palette, b: Background Palette, o: Object Palette"`

It is possible define the "data type" of the parameter. In the end it will all be converted into a number, but for the user experience this might help.  
Possible data types:
- Number -> Implicit datatype, can be omitted
- Pointer -> Stores result as little endian
- Transition -> Stores the selected index in a list of all Transitions
- List(X) -> Stores the selected index in a list with X numbered elements
- [option1, option2, ...] -> Stores the selected index in a list with labeled options

Example:
* `"90 nn tttt: Branch, if, Number n: Metroid Count <=, Transition t: to Transition"`
* `"1x: Load Metatile Table, List(A) x: Table"`
* `"Bs bb xxxx: Load Graphics Page, [Background Graphics, Sprite Graphics] s: Load, b: From Bank, Pointer x: at Address"`

## Compiling straight to IPS
Currently, LAMP only supports compilation to a ROM. However, for hack distribution this is not the most
optimal file format. While it might not take a long time, it is still an slightly convoluted process to first
compile a ROM and then use a third party tool to create a patch.

Technically, LAMP can detect the difference between the changes in the data files and the base ROM used in LAMP.
The only problem with this approach is that it is possible to use a different, non vanilla, M2 ROM as the base in LAMP. When a patch gets created through LAMP, this would lead to the patch only containing the changes from the data files and not any potential changes in the base ROM. Any resulting patched ROM would then be missing data. Obviously this could be avoided, if people stopped using different base ROMs, but this as well is not possible right now since a lot of the ASM patches are applied using the source code and LAMP is currently still lacking proper ways to edit many aspects surrounding graphics and collision.

Due to all these complications, it is unlikely that an option to compile to a patch is worth the effort.