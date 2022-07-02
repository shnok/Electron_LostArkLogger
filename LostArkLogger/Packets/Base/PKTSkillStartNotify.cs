using LostArkLogger.Properties;
using System;
using System.Collections.Generic;
namespace LostArkLogger
{
    public class PKTSkillStartNotify {
        // Fields
        public ulong SourceId;
        public uint SkillId;
        public List<object> packed;
        public ulong u64_0;
        public ulong u64_1;
        public ulong u64_2;
        public uint u32_0;
        public uint u32_1;
        public ushort u16_0;
        public ushort u16_1;
        public ushort u16_2;
        public byte b_0;
        public byte b_1;
        public byte b_2;
        public byte b_3;

        // Methods
        public PKTSkillStartNotify(BitReader reader) {
            if(Settings.Default.Region == Region.Steam) {
                this.SteamDecode(reader);
            }
            if(Settings.Default.Region == Region.Korea) {
                this.KoreaDecode(reader);
            }
        }

        public void KoreaDecode(BitReader reader) {
            this.b_0 = reader.ReadByte();
            this.SourceId = reader.ReadUInt64();
            this.b_1 = reader.ReadByte();
            if(this.b_1 == 1) {
                this.u32_0 = reader.ReadUInt32();
            }
            this.u64_1 = reader.ReadUInt64();
            this.u16_0 = reader.ReadUInt16();
            this.b_2 = reader.ReadByte();
            if(this.b_2 == 1) {
                this.u16_1 = reader.ReadUInt16();
            }
            int[] sizes = new int[] { 1, 1, 4, 4, 4, 3, 6 };
            this.packed = reader.ReadPackedValues(sizes);
            this.b_3 = reader.ReadByte();
            if(this.b_3 == 1) {
                this.u32_1 = reader.ReadUInt32();
            }
            this.u16_2 = reader.ReadUInt16();
            this.u64_2 = reader.ReadUInt64();
            this.SkillId = reader.ReadUInt32();
            this.u64_0 = reader.ReadUInt64();
        }

        public void SteamDecode(BitReader reader) {
            this.u64_0 = reader.ReadUInt64();
            this.b_0 = reader.ReadByte();
            if(this.b_0 == 1) {
                this.u16_0 = reader.ReadUInt16();
            }
            this.b_2 = reader.ReadByte();
            if(this.b_2 == 1) {
                this.u32_1 = reader.ReadUInt32();
            }
            this.u16_1 = reader.ReadUInt16();
            this.u64_2 = reader.ReadUInt64();
            int[] sizes = new int[] { 1, 1, 4, 4, 4, 3, 6 };
            this.packed = reader.ReadPackedValues(sizes);
            this.SkillId = reader.ReadUInt32();
            this.u16_2 = reader.ReadUInt16();
            this.SourceId = reader.ReadUInt64();
            this.b_3 = reader.ReadByte();
            this.b_1 = reader.ReadByte();
            if(this.b_1 == 1) {
                this.u32_0 = reader.ReadUInt32();
            }
            this.u64_1 = reader.ReadUInt64();
        }
    }


    



}
