using LostArkLogger.Properties;
using System;
using System.Collections.Generic;
namespace LostArkLogger
{
    public class PCStruct {
        // Fields
        public string Name;
        public List<ItemInfo> EquippedItems;
        public ulong PlayerId;
        public uint GearLevel;
        public ushort ClassId;
        public ushort Level;
        public string str;
        public List<StatusEffectData> statusEffectDatas;
        public List<subPKTInitPC29> subPKTInitPC29s;
        public List<ItemInfo> itemInfos;
        public List<uint> u32list;
        public subPKTNewNpc5 subPKTNewNpc5;
        public StatPair statPair;
        public SkillRunes skillRunes;
        public byte[] bytearray_0;
        public byte[] bytearray_1;
        public ulong u64_0;
        public ulong u64_1;
        public byte[] bytearray_2;
        public uint u32_0;
        public uint u32_1;
        public uint u32_2;
        public uint u32_3;
        public uint u32_4;
        public uint u32_5;
        public uint u32_6;
        public uint u32_7;
        public uint u32_8;
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

        // Methods
        public PCStruct(BitReader reader) {
            if(Settings.Default.Region == Region.Steam) {
                this.SteamDecode(reader);
            }
            if(Settings.Default.Region == Region.Korea) {
                this.KoreaDecode(reader);
            }
        }

        public void KoreaDecode(BitReader reader) {
            this.Name = reader.ReadString();
            this.b_0 = reader.ReadByte();
            this.b_6 = reader.ReadByte();
            this.u32list = reader.ReadList<uint>(0);
            this.u32_4 = reader.ReadUInt32();
            this.u32_6 = reader.ReadUInt32();
            this.b_12 = reader.ReadByte();
            this.u32_7 = reader.ReadUInt32();
            this.u32_8 = reader.ReadUInt32();
            this.b_1 = reader.ReadByte();
            this.b_2 = reader.ReadByte();
            if(this.b_2 == 1) {
                this.bytearray_1 = reader.ReadBytes(12);
            }
            this.b_3 = reader.ReadByte();
            this.b_4 = reader.ReadByte();
            this.itemInfos = reader.ReadList<ItemInfo>(0);
            this.u16_0 = reader.ReadUInt16();
            this.statusEffectDatas = reader.ReadList<StatusEffectData>(0);
            this.u16_1 = reader.ReadUInt16();
            this.subPKTNewNpc5 = reader.Read<subPKTNewNpc5>(0);
            this.b_5 = reader.ReadByte();
            this.u16_2 = reader.ReadUInt16();
            this.Level = reader.ReadUInt16();
            this.b_7 = reader.ReadByte();
            this.u32_0 = reader.ReadUInt32();
            this.u32_1 = reader.ReadUInt32();
            this.skillRunes = reader.Read<SkillRunes>(0);
            this.u32_2 = reader.ReadUInt32();
            this.u64_0 = reader.ReadUInt64();
            this.u32_3 = reader.ReadUInt32();
            this.b_8 = reader.ReadByte();
            this.b_9 = reader.ReadByte();
            this.ClassId = reader.ReadUInt16();
            this.bytearray_0 = reader.ReadBytes(0x19);
            this.statPair = reader.Read<StatPair>(0);
            this.b_10 = reader.ReadByte();
            this.u64_1 = reader.ReadUInt64();
            this.GearLevel = reader.ReadUInt32();
            this.EquippedItems = reader.ReadList<ItemInfo>(0);
            this.bytearray_2 = reader.ReadBytes(5);
            this.u32_5 = reader.ReadUInt32();
            this.PlayerId = reader.ReadUInt64();
            this.u16_3 = reader.ReadUInt16();
            this.b_11 = reader.ReadByte();
        }

        public void SteamDecode(BitReader reader) {
            this.subPKTInitPC29s = reader.ReadList<subPKTInitPC29>(0);
            this.u64_0 = reader.ReadUInt64();
            this.u32_3 = reader.ReadUInt32();
            this.u32_5 = reader.ReadUInt32();
            this.u16_3 = reader.ReadUInt16();
            this.GearLevel = reader.ReadUInt32();
            this.bytearray_0 = reader.ReadBytes(0x19);
            this.u32_8 = reader.ReadUInt32();
            this.b_12 = reader.ReadByte();
            this.itemInfos = reader.ReadList<ItemInfo>(0);
            this.b_0 = reader.ReadByte();
            this.b_1 = reader.ReadByte();
            this.u32_0 = reader.ReadUInt32();
            this.u32_1 = reader.ReadUInt32();
            this.statPair = reader.Read<StatPair>(0);
            this.b_2 = reader.ReadByte();
            this.str = reader.ReadString();
            this.u16_0 = reader.ReadUInt16();
            this.u64_1 = reader.ReadUInt64();
            this.u32_2 = reader.ReadUInt32();
            this.statusEffectDatas = reader.ReadList<StatusEffectData>(0);
            this.u16_1 = reader.ReadUInt16();
            this.u32_4 = reader.ReadUInt32();
            this.b_3 = reader.ReadByte();
            this.u32list = reader.ReadList<uint>(0);
            this.b_4 = reader.ReadByte();
            this.u16_2 = reader.ReadUInt16();
            this.b_5 = reader.ReadByte();
            this.b_6 = reader.ReadByte();
            this.subPKTNewNpc5 = reader.Read<subPKTNewNpc5>(0);
            this.u32_6 = reader.ReadUInt32();
            this.skillRunes = reader.Read<SkillRunes>(0);
            this.b_7 = reader.ReadByte();
            this.PlayerId = reader.ReadUInt64();
            this.ClassId = reader.ReadUInt16();
            this.Level = reader.ReadUInt16();
            this.EquippedItems = reader.ReadList<ItemInfo>(0);
            this.b_8 = reader.ReadByte();
            this.b_9 = reader.ReadByte();
            this.b_10 = reader.ReadByte();
            this.bytearray_2 = reader.ReadBytes(5);
            this.b_11 = reader.ReadByte();
            if(this.b_11 == 1) {
                this.bytearray_1 = reader.ReadBytes(12);
            }
            this.u32_7 = reader.ReadUInt32();
            this.Name = reader.ReadString();
        }
    }
}
