using LostArkLogger.Properties;
using System;
using System.Collections.Generic;
namespace LostArkLogger
{
    public class PKTNewNpc {
        // Fields
        public NpcStruct npcStruct;
        public ulong u64;
        public byte b_0;
        public byte b_1;
        public byte b_2;
        public byte b_3;

        // Methods
        public PKTNewNpc(BitReader reader) {
            if(Settings.Default.Region == Region.Steam) {
                this.SteamDecode(reader);
            }
            if(Settings.Default.Region == Region.Korea) {
                this.KoreaDecode(reader);
            }
        }

        public void KoreaDecode(BitReader reader) {
            this.b_0 = reader.ReadByte();
            if(this.b_0 == 1) {
                this.u64 = reader.ReadUInt64();
            }
            this.b_1 = reader.ReadByte();
            this.npcStruct = reader.Read<NpcStruct>(0);
            this.b_2 = reader.ReadByte();
            if(this.b_2 == 1) {
                this.b_3 = reader.ReadByte();
            }
        }

        public void SteamDecode(BitReader reader) {
            this.b_0 = reader.ReadByte();
            if(this.b_0 == 1) {
                this.u64 = reader.ReadUInt64();
            }
            this.b_1 = reader.ReadByte();
            if(this.b_1 == 1) {
                this.b_2 = reader.ReadByte();
            }
            this.b_3 = reader.ReadByte();
            this.npcStruct = reader.Read<NpcStruct>(0);
        }
    }


    



}
