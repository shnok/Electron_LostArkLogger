using LostArkLogger.Properties;
using System;
using System.Collections.Generic;
namespace LostArkLogger
{
    public class PKTDeathNotify {
        // Fields
        public ulong SourceId;
        public ulong TargetId;
        public ulong u64;
        public uint u32;
        public ushort u16;
        public byte b_0;
        public byte b_1;
        public byte b_2;
        public byte b_3;
        public byte b_4;
        public byte b_5;
        public byte b_6;

        // Methods
        public PKTDeathNotify(BitReader reader) {
            if(Settings.Default.Region == Region.Steam) {
                this.SteamDecode(reader);
            }
            if(Settings.Default.Region == Region.Korea) {
                this.KoreaDecode(reader);
            }
        }

        public void KoreaDecode(BitReader reader) {
            this.u64 = reader.ReadUInt64();
            this.u32 = reader.ReadUInt32();
            this.b_0 = reader.ReadByte();
            if(this.b_0 == 1) {
                this.b_1 = reader.ReadByte();
            }
            this.SourceId = reader.ReadUInt64();
            this.b_2 = reader.ReadByte();
            if(this.b_2 == 1) {
                this.b_3 = reader.ReadByte();
            }
            this.b_4 = reader.ReadByte();
            if(this.b_4 == 1) {
                this.b_5 = reader.ReadByte();
            }
            this.b_6 = reader.ReadByte();
            this.u16 = reader.ReadUInt16();
            this.TargetId = reader.ReadUInt64();
        }

        public void SteamDecode(BitReader reader) {
            this.b_0 = reader.ReadByte();
            if(this.b_0 == 1) {
                this.b_1 = reader.ReadByte();
            }
            this.b_2 = reader.ReadByte();
            this.u64 = reader.ReadUInt64();
            this.b_3 = reader.ReadByte();
            if(this.b_3 == 1) {
                this.b_4 = reader.ReadByte();
            }
            this.SourceId = reader.ReadUInt64();
            this.TargetId = reader.ReadUInt64();
            this.b_5 = reader.ReadByte();
            if(this.b_5 == 1) {
                this.b_6 = reader.ReadByte();
            }
            this.u32 = reader.ReadUInt32();
            this.u16 = reader.ReadUInt16();
        }
    }


    



}
