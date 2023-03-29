using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace LAMP.Classes.M2_Data
{
    public class Save
    {
        [JsonConstructor]
        public Save() {}

        public void setTilesetID(Tileset t)
        {
            TilesetUsed = Globals.Tilesets.IndexOf(t);

            TileGraphics = t.GfxOffset;
            MetatileData = Editor.GetMetaPointerFromTable(t.MetatileTable);
            MetatileTable = t.MetatileTable;
            CollisionData = Editor.GetCollisionPointerFromTable(t.CollisionTable);
            CollisionTable= t.CollisionTable;
            byte[] solidity = Editor.GetSolidityIndices(t.SolidityTable);
            SolidityTable = t.SolidityTable;

            SamusSolidity = solidity[0];
            EnemySolidity = solidity[1];
            ProjectileSolidity = solidity[2];
        }

        /// <summary>
        /// Writes all the data from the Save object to the specified ROM
        /// </summary>
        public void WriteToROM(Rom r)
        {
            //Samus' Position
            r.Write8(0x4E64, SamusY);
            r.Write8(0x4E65, SamusScreenY);
            r.Write8(0x4E66, SamusX);
            r.Write8(0x4E67, SamusScreenX);
            //Camera Position
            r.Write8(0x4E68, CamY);
            r.Write8(0x4E69, CamScreenY);
            r.Write8(0x4E6A, CamX);
            r.Write8(0x4E6B, CamScreenX);
            //Tileset Definitions
            r.Write16(0x4E6C, (ushort)SpriteGraphics.bOffset);
            r.Write8(0x4E6E, (byte)TileGraphics.Bank);
            r.Write16(0x4E6F, (ushort)TileGraphics.bOffset);
            r.Write16(0x4E71, (ushort)MetatileData.bOffset);
            r.Write16(0x4E73, (ushort)CollisionData.bOffset);
            r.Write8(0x4E75, (byte)(MapBank + 0x9));
            //Solidity Indices
            r.Write8(0x4E76, SamusSolidity);
            r.Write8(0x4E77, EnemySolidity);
            r.Write8(0x4E78, ProjectileSolidity);
            //Equipment
            r.Write8(0x4E79, Items);
            r.Write8(0x4E7A, Beam);
            r.Write8(0x4E7B, EnergyTanksAmount);
            r.Write8(0x4E7C, StartEnegery);
            r.Write8(0x4E7D, EnergyTanksFilled);
            r.Write16(0x4E7E, MaxMissiles);
            r.Write16(0x4E80, StartMissiles);
            //Misc.
            r.Write8(0x4E83, AcidDamage);
            r.Write8(0x4E84, SpikeDamage);
            r.Write8(0x4E85, RealMetroidCount);
            r.Write8(0x4E86, Music);
            r.Write8(0x4E87, IGTMinutes);
            r.Write8(0x4E88, IGTHours);
            r.Write8(0x4E89, MetroidCount);
        }

        /// <summary>
        /// Copies all values to another save
        /// </summary>
        public void CopyTo(Save s)
        {
            s.SamusScreenX = SamusScreenX;
            s.SamusScreenY = SamusScreenY;
            s.SamusX = SamusX;
            s.SamusY = SamusY;
            s.CamScreenX = CamScreenX;
            s.CamScreenY = CamScreenY;
            s.CamX = CamX;
            s.CamY = CamY;
            s.TilesetUsed = TilesetUsed;
            s.SpriteGraphics = SpriteGraphics;
            s.TileGraphics = TileGraphics;
            s.MetatileData = MetatileData;
            s.MetatileTable = MetatileTable;
            s.CollisionData = CollisionData;
            s.CollisionTable = CollisionTable;
            s.MapBank = MapBank;
            s.SolidityTable = SolidityTable;
            s.SamusSolidity = SamusSolidity;
            s.EnemySolidity = EnemySolidity;
            s.ProjectileSolidity = ProjectileSolidity;
            s.Items = Items;
            s.Beam = Beam;
            s.EnergyTanksAmount = EnergyTanksAmount;
            s.StartEnegery = StartEnegery;
            s.EnergyTanksFilled = EnergyTanksFilled;
            s.MaxMissiles = MaxMissiles;
            s.StartMissiles= StartMissiles;
            s.AcidDamage = AcidDamage;
            s.SpikeDamage = SpikeDamage;
            s.RealMetroidCount = RealMetroidCount;
            s.MetroidCount = MetroidCount;
            s.Music = Music;
            s.IGTHours = IGTHours;
            s.IGTMinutes = IGTMinutes;
        }

        #region Save Data

        //Position Data
        //Samus
        public byte SamusScreenX { get; set; } = 0x6;
        public byte SamusScreenY { get; set; } = 0x7;
        public byte SamusX { get; set; } = 0x48;
        public byte SamusY { get; set; } = 0xD4;

        //Camera
        public byte CamScreenX { get; set; } = 0x6;
        public byte CamScreenY { get; set; } = 0x7;
        public byte CamX { get; set; } = 0x40;
        public byte CamY { get; set; } = 0xC0;

        //Level and Graphics Data
        public int TilesetUsed { get; set; } = -1;
        public Pointer SpriteGraphics { get; set; } = new Pointer(6, 0x7520); //Sprite graphics are always in B6
        public Pointer TileGraphics { get; set; } = new Pointer(7, 0x6000);
        public Pointer MetatileData { get; set; } = new Pointer(8, 0x5280);
        public int MetatileTable { get; set; } = 4;
        public Pointer CollisionData { get; set; } = new Pointer(8, 0x4580);
        public int CollisionTable { get; set; } = 4;
        public byte MapBank { get; set; } = 0x6;
        public int SolidityTable { get; set; } = 0;
        public byte SamusSolidity { get; set; } = 0x64;
        public byte EnemySolidity { get; set; } = 0x64;
        public byte ProjectileSolidity { get; set; } = 0x64;

        //Equipment
        public byte Items { get; set; } = 0;
        public byte Beam { get; set; } = 0;
        public byte EnergyTanksAmount { get; set; } = 0;
        public byte StartEnegery { get; set; } = 0x99;
        public byte EnergyTanksFilled { get; set; } = 0;
        public ushort MaxMissiles { get; set; } = 0x30;
        public ushort StartMissiles { get; set; } = 0x30;

        //Misc
        public byte AcidDamage { get; set; } = 0x2;
        public byte SpikeDamage { get; set; } = 0x8;
        public byte RealMetroidCount { get; set; } = 0x47;
        public byte MetroidCount { get; set; } = 0x39;
        public byte Music { get; set; } = 0x4;
        public byte IGTMinutes { get; set; } = 0x00;
        public byte IGTHours { get; set; } = 0x00;
        #endregion
    }
}
