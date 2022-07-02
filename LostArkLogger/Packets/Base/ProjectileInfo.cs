using LostArkLogger.Properties;
using System;
using System.Collections.Generic;
namespace LostArkLogger
{
    public class ProjectileInfo {
        // Fields
        public ulong OwnerId;
        public ulong ProjectileId;
        public uint SkillEffect;
        public uint SkillId;
        public byte[] Tripods;
        public byte SkillLevel;
        public List<ulong> u64list;
        public ulong u64_0;
        public ulong u64_1;
        public ulong u64_2;
        public byte[] bytearray;
        public uint u32_0;
        public uint u32_1;
        public uint u32_2;
        public uint u32_3;
        public uint u32_4;
        public ushort u16_0;
        public ushort u16_1;
        public byte b_0;
        public byte b_1;
        public byte b_2;
        public byte b_3;

        // Methods
        public ProjectileInfo(BitReader reader) {
            if(Settings.Default.Region == Region.Steam) {
                this.SteamDecode(reader);
            }
            if(Settings.Default.Region == Region.Korea) {
                this.KoreaDecode(reader);
            }
        }

        public void KoreaDecode(BitReader reader) {
            this.u64_0 = reader.ReadUInt64();
            this.OwnerId = reader.ReadUInt64();
            this.u32_4 = reader.ReadUInt32();
            this.u64_2 = reader.ReadUInt64();
            this.bytearray = reader.ReadBytes(6);
            this.SkillLevel = reader.ReadByte();
            this.SkillId = reader.ReadUInt32();
            this.u16_1 = reader.ReadUInt16();
            this.u32_0 = reader.ReadUInt32();
            this.Tripods = reader.ReadBytes(3);
            this.u16_0 = reader.ReadUInt16();
            this.u32_1 = reader.ReadUInt32();
            this.b_0 = reader.ReadByte();
            if(this.b_0 == 1) {
                this.u64_1 = reader.ReadUInt64();
            }
            this.b_1 = reader.ReadByte();
            if(this.b_1 == 1) {
                this.u64list = reader.ReadList<ulong>(0);
            }
            this.b_2 = reader.ReadByte();
            if(this.b_2 == 1) {
                this.u32_2 = reader.ReadUInt32();
            }
            this.b_3 = reader.ReadByte();
            this.u32_3 = reader.ReadUInt32();
            this.ProjectileId = reader.ReadUInt64();
            this.SkillEffect = reader.ReadUInt32();
        }

        public void SteamDecode(BitReader reader) {
            this.u32_0 = reader.ReadUInt32();
            this.SkillId = reader.ReadUInt32();
            this.b_1 = reader.ReadByte();
            if(this.b_1 == 1) {
                this.u64list = reader.ReadList<ulong>(0);
            }
            this.u32_2 = reader.ReadUInt32();
            this.b_2 = reader.ReadByte();
            this.bytearray = reader.ReadBytes(6);
            this.SkillLevel = reader.ReadByte();
            this.u32_3 = reader.ReadUInt32();
            this.b_3 = reader.ReadByte();
            if(this.b_3 == 1) {
                this.u32_4 = reader.ReadUInt32();
            }
            this.SkillEffect = reader.ReadUInt32();
            this.u64_0 = reader.ReadUInt64();
            this.u16_0 = reader.ReadUInt16();
            this.b_0 = reader.ReadByte();
            this.ProjectileId = reader.ReadUInt64();
            this.u64_1 = reader.ReadUInt64();
            this.u32_1 = reader.ReadUInt32();
            this.u64_2 = reader.ReadUInt64();
            this.OwnerId = reader.ReadUInt64();
            this.u16_1 = reader.ReadUInt16();
            this.Tripods = reader.ReadBytes(3);
        }
    }


    



}
