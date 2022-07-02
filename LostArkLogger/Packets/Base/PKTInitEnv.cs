using LostArkLogger.Properties;
using System;
using System.Collections.Generic;
namespace LostArkLogger
{
    public class PKTInitEnv {
        // Fields
        public ulong PlayerId;
        public ulong s64;
        public List<byte> blist;
        public subPKTInitEnv5 subPKTInitEnv5;
        public ulong u64;
        public uint u32_0;
        public uint u32_1;
        public byte b;

        // Methods
        public PKTInitEnv(BitReader reader) {
            if(Settings.Default.Region == Region.Steam) {
                this.SteamDecode(reader);
            }
            if(Settings.Default.Region == Region.Korea) {
                this.KoreaDecode(reader);
            }
        }

        public void KoreaDecode(BitReader reader) {
            this.subPKTInitEnv5 = reader.Read<subPKTInitEnv5>(0);
            this.PlayerId = reader.ReadUInt64();
            this.s64 = reader.ReadSimpleInt();
            this.b = reader.ReadByte();
            this.u32_0 = reader.ReadUInt32();
            this.blist = reader.ReadList<byte>(0);
            this.u64 = reader.ReadUInt64();
            this.u32_1 = reader.ReadUInt32();
        }

        public void SteamDecode(BitReader reader) {
            this.u32_0 = reader.ReadUInt32();
            this.s64 = reader.ReadSimpleInt();
            this.u32_1 = reader.ReadUInt32();
            this.u64 = reader.ReadUInt64();
            this.b = reader.ReadByte();
            this.PlayerId = reader.ReadUInt64();
            this.blist = reader.ReadList<byte>(0);
            this.subPKTInitEnv5 = reader.Read<subPKTInitEnv5>(0);
        }
    }


    



}
