using LostArkLogger.Properties;
using System;
using System.Collections.Generic;
namespace LostArkLogger
{
    public class NpcStruct {
        // Fields
        public ulong NpcId;
        public uint NpcType;
        public subPKTNewNpc66 subPKTNewNpc66;
        public List<StatusEffectData> statusEffectDatas;
        public List<subPKTInitPC29> subPKTInitPC29s;
        public List<ulong> u64list;
        public List<byte[]> bytearraylist;
        public StatPair statPair;
        public ulong u64_0;
        public ulong u64_1;
        public uint u32_0;
        public uint u32_1;
        public uint u32_2;
        public uint u32_3;
        public uint u32_4;
        public uint u32_5;
        public ushort u16_0;
        public ushort u16_1;
        public ushort u16_2;
        public ushort u16_3;
        public byte b_0;
        public byte b_1;
        public byte b_2;
        public byte b_3;
        public byte b_4;
        public byte b_5;
        public byte b_6;
        public byte b_7;
        public byte b_8;
        public byte b_9;
        public byte b_10;
        public byte b_11;
        public byte b_12;
        public byte b_13;
        public byte b_14;
        public byte b_15;
        public byte b_16;
        public byte b_17;
        public byte b_18;
        public byte b_19;
        public byte b_20;
        public byte b_21;
        public byte b_22;
        public byte b_23;
        public byte b_24;
        public byte b_25;
        public byte b_26;
        public byte b_27;
        public byte b_28;
        public byte b_29;
        public byte b_30;

        // Methods
        public NpcStruct(BitReader reader) {
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
                this.b_1 = reader.ReadByte();
            }
            this.b_2 = reader.ReadByte();
            if(this.b_2 == 1) {
                this.b_3 = reader.ReadByte();
            }
            this.b_11 = reader.ReadByte();
            if(this.b_11 == 1) {
                this.u64list = reader.ReadList<ulong>(0);
            }
            this.b_20 = reader.ReadByte();
            if(this.b_20 == 1) {
                this.b_21 = reader.ReadByte();
            }
            this.b_24 = reader.ReadByte();
            if(this.b_24 == 1) {
                this.b_25 = reader.ReadByte();
            }
            this.b_26 = reader.ReadByte();
            if(this.b_26 == 1) {
                this.b_27 = reader.ReadByte();
            }
            this.b_28 = reader.ReadByte();
            if(this.b_28 == 1) {
                this.u32_5 = reader.ReadUInt32();
            }
            this.b_29 = reader.ReadByte();
            if(this.b_29 == 1) {
                this.u16_3 = reader.ReadUInt16();
            }
            this.b_30 = reader.ReadByte();
            this.b_4 = reader.ReadByte();
            this.b_5 = reader.ReadByte();
            if(this.b_5 == 1) {
                this.u32_0 = reader.ReadUInt32();
            }
            this.statPair = reader.Read<StatPair>(0);
            this.u16_0 = reader.ReadUInt16();
            this.b_6 = reader.ReadByte();
            if(this.b_6 == 1) {
                this.b_7 = reader.ReadByte();
            }
            this.b_8 = reader.ReadByte();
            if(this.b_8 == 1) {
                this.u32_1 = reader.ReadUInt32();
            }
            this.b_9 = reader.ReadByte();
            if(this.b_9 == 1) {
                this.u16_1 = reader.ReadUInt16();
            }
            this.b_10 = reader.ReadByte();
            if(this.b_10 == 1) {
                this.bytearraylist = reader.ReadList<byte[]>(12);
            }
            this.u16_2 = reader.ReadUInt16();
            this.u32_2 = reader.ReadUInt32();
            this.b_12 = reader.ReadByte();
            this.b_13 = reader.ReadByte();
            if(this.b_13 == 1) {
                this.u64_0 = reader.ReadUInt64();
            }
            this.NpcId = reader.ReadUInt64();
            this.b_14 = reader.ReadByte();
            if(this.b_14 == 1) {
                this.u32_3 = reader.ReadUInt32();
            }
            this.b_15 = reader.ReadByte();
            if(this.b_15 == 1) {
                this.b_16 = reader.ReadByte();
            }
            this.b_17 = reader.ReadByte();
            if(this.b_17 == 1) {
                this.u32_4 = reader.ReadUInt32();
            }
            this.u64_1 = reader.ReadUInt64();
            this.b_18 = reader.ReadByte();
            this.b_19 = reader.ReadByte();
            this.NpcType = reader.ReadUInt32();
            this.b_22 = reader.ReadByte();
            if(this.b_22 == 1) {
                this.subPKTNewNpc66 = reader.Read<subPKTNewNpc66>(0);
            }
            this.b_23 = reader.ReadByte();
            this.statusEffectDatas = reader.ReadList<StatusEffectData>(0);
        }

        public void SteamDecode(BitReader reader) {
            this.b_0 = reader.ReadByte();
            if(this.b_0 == 1) {
                this.bytearraylist = reader.ReadList<byte[]>(12);
            }
            this.b_1 = reader.ReadByte();
            this.b_10 = reader.ReadByte();
            this.b_22 = reader.ReadByte();
            if(this.b_22 == 1) {
                this.b_23 = reader.ReadByte();
            }
            this.statPair = reader.Read<StatPair>(0);
            this.b_25 = reader.ReadByte();
            if(this.b_25 == 1) {
                this.u16_3 = reader.ReadUInt16();
            }
            this.b_26 = reader.ReadByte();
            if(this.b_26 == 1) {
                this.u32_3 = reader.ReadUInt32();
            }
            this.b_27 = reader.ReadByte();
            if(this.b_27 == 1) {
                this.u32_4 = reader.ReadUInt32();
            }
            this.b_28 = reader.ReadByte();
            if(this.b_28 == 1) {
                this.b_29 = reader.ReadByte();
            }
            this.b_30 = reader.ReadByte();
            if(this.b_30 == 1) {
                this.u32_5 = reader.ReadUInt32();
            }
            this.u64_0 = reader.ReadUInt64();
            this.u16_0 = reader.ReadUInt16();
            this.u16_1 = reader.ReadUInt16();
            this.b_2 = reader.ReadByte();
            if(this.b_2 == 1) {
                this.b_3 = reader.ReadByte();
            }
            this.b_4 = reader.ReadByte();
            if(this.b_4 == 1) {
                this.b_5 = reader.ReadByte();
            }
            this.b_6 = reader.ReadByte();
            if(this.b_6 == 1) {
                this.b_7 = reader.ReadByte();
            }
            this.b_8 = reader.ReadByte();
            this.b_9 = reader.ReadByte();
            this.NpcType = reader.ReadUInt32();
            this.statusEffectDatas = reader.ReadList<StatusEffectData>(0);
            this.b_11 = reader.ReadByte();
            this.b_12 = reader.ReadByte();
            if(this.b_12 == 1) {
                this.b_13 = reader.ReadByte();
            }
            this.b_14 = reader.ReadByte();
            this.NpcId = reader.ReadUInt64();
            this.b_15 = reader.ReadByte();
            if(this.b_15 == 1) {
                this.u16_2 = reader.ReadUInt16();
            }
            this.b_16 = reader.ReadByte();
            if(this.b_16 == 1) {
                this.subPKTNewNpc66 = reader.Read<subPKTNewNpc66>(0);
            }
            this.b_17 = reader.ReadByte();
            if(this.b_17 == 1) {
                this.u64list = reader.ReadList<ulong>(0);
            }
            this.b_18 = reader.ReadByte();
            if(this.b_18 == 1) {
                this.u64_1 = reader.ReadUInt64();
            }
            this.b_19 = reader.ReadByte();
            if(this.b_19 == 1) {
                this.u32_0 = reader.ReadUInt32();
            }
            this.b_20 = reader.ReadByte();
            if(this.b_20 == 1) {
                this.b_21 = reader.ReadByte();
            }
            this.b_24 = reader.ReadByte();
            if(this.b_24 == 1) {
                this.u32_1 = reader.ReadUInt32();
            }
            this.u32_2 = reader.ReadUInt32();
            this.subPKTInitPC29s = reader.ReadList<subPKTInitPC29>(0);
        }
    }
}
