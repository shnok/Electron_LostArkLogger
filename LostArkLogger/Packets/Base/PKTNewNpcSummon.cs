using LostArkLogger.Properties;
using System;
using System.Collections.Generic;
namespace LostArkLogger
{
    public class PKTNewNpcSummon {
        // Fields
        public ulong OwnerId;
        public NpcStruct npcStruct;
        public byte[] bytearray_0;
        public byte[] bytearray_1;
        public byte b;

        // Methods
        public PKTNewNpcSummon(BitReader reader) {
            if(Settings.Default.Region == Region.Steam) {
                this.SteamDecode(reader);
            }
            if(Settings.Default.Region == Region.Korea) {
                this.KoreaDecode(reader);
            }
        }

        public void KoreaDecode(BitReader reader) {
            this.npcStruct = reader.Read<NpcStruct>(0);
            this.bytearray_1 = reader.ReadBytes(0);
            this.OwnerId = reader.ReadUInt64();
            this.bytearray_0 = reader.ReadBytes(0x1f);
            this.b = reader.ReadByte();
        }

        public void SteamDecode(BitReader reader) {
            this.b = reader.ReadByte();
            this.bytearray_0 = reader.ReadBytes(0x17);
            this.OwnerId = reader.ReadUInt64();
            this.bytearray_1 = reader.ReadBytes(8);
            this.npcStruct = reader.Read<NpcStruct>(0);
        }
    }


    



}
