using LostArkLogger.Properties;
using System;
using System.Collections.Generic;
namespace LostArkLogger
{
    public class StatusEffectData {
        // Fields
        public byte[] Value;
        public ulong InstanceId;
        public ulong SourceId;
        public uint BuffId;
        public byte hasValue;
        public ulong s64;
        public List<byte[]> bytearraylist;
        public ulong u64;
        public uint u32_0;
        public uint u32_1;
        public byte b_0;
        public byte b_1;
        public byte b_2;

        // Methods
        public StatusEffectData(BitReader reader) {
            if(Settings.Default.Region == Region.Steam) {
                this.SteamDecode(reader);
            }
            if(Settings.Default.Region == Region.Korea) {
                this.KoreaDecode(reader);
            }
        }

        public void KoreaDecode(BitReader reader) {
            this.InstanceId = reader.ReadUInt64();
            this.s64 = reader.ReadSimpleInt();
            this.b_1 = reader.ReadByte();
            if(this.b_1 == 1) {
                this.SourceId = reader.ReadUInt64();
            }
            this.u32_0 = reader.ReadUInt32();
            this.bytearraylist = reader.ReadList<byte[]>(7);
            this.u64 = reader.ReadUInt64();
            this.BuffId = reader.ReadUInt32();
            this.hasValue = reader.ReadByte();
            if(this.hasValue == 1) {
                this.Value = reader.ReadBytes(0x10);
            }
            this.u32_1 = reader.ReadUInt32();
            this.b_2 = reader.ReadByte();
            this.b_0 = reader.ReadByte();
        }

        public void SteamDecode(BitReader reader) {
            this.u32_0 = reader.ReadUInt32();
            this.InstanceId = reader.ReadUInt64();
            this.SourceId = reader.ReadUInt64();
            this.bytearraylist = reader.ReadList<byte[]>(7);
            this.b_0 = reader.ReadByte();
            this.u32_1 = reader.ReadUInt32();
            this.b_1 = reader.ReadByte();
            this.hasValue = reader.ReadByte();
            if(this.hasValue == 1) {
                this.Value = reader.ReadBytes(0x10);
            }
            this.s64 = reader.ReadSimpleInt();
            this.b_2 = reader.ReadByte();
            if(this.b_2 == 1) {
                this.u64 = reader.ReadUInt64();
            }
            this.BuffId = reader.ReadUInt32();
        }
    }


    



}
