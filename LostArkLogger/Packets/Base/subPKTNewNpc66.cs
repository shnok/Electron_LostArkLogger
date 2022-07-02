using LostArkLogger.Properties;
using System;
using System.Collections.Generic;
namespace LostArkLogger
{
    public class subPKTNewNpc66 {
        // Fields
        public string str;
        public List<ItemInfo> itemInfos;
        public subPKTNewNpc5 subPKTNewNpc5;
        public ulong u64;
        public ushort u16;
        public byte b_0;
        public byte b_1;
        public byte b_2;

        // Methods
        public subPKTNewNpc66(BitReader reader) {
            if(Settings.Default.Region == Region.Steam) {
                this.SteamDecode(reader);
            }
            if(Settings.Default.Region == Region.Korea) {
                this.KoreaDecode(reader);
            }
        }

        public void KoreaDecode(BitReader reader) {
            this.b_0 = reader.ReadByte();
            this.b_1 = reader.ReadByte();
            this.b_2 = reader.ReadByte();
            this.itemInfos = reader.ReadList<ItemInfo>(0);
            this.subPKTNewNpc5 = reader.Read<subPKTNewNpc5>(0);
            this.u16 = reader.ReadUInt16();
            this.u64 = reader.ReadUInt64();
            this.str = reader.ReadString();
        }

        public void SteamDecode(BitReader reader) {
            this.b_0 = reader.ReadByte();
            this.itemInfos = reader.ReadList<ItemInfo>(0);
            this.b_1 = reader.ReadByte();
            this.subPKTNewNpc5 = reader.Read<subPKTNewNpc5>(0);
            this.u64 = reader.ReadUInt64();
            this.str = reader.ReadString();
            this.b_2 = reader.ReadByte();
            this.u16 = reader.ReadUInt16();
        }
    }


    



}
