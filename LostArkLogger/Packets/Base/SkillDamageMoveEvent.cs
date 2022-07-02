using LostArkLogger.Properties;
using System;
using System.Collections.Generic;
namespace LostArkLogger
{
    public class SkillDamageMoveEvent {
        // Fields
        public SkillDamageEvent skillDamageEvent;
        public ulong flag;
        public ulong u64_0;
        public ulong u64_1;
        public ulong u64_2;
        public ushort u16_0;
        public ushort u16_1;
        public ushort u16_2;
        public byte b;

        // Methods
        public SkillDamageMoveEvent(BitReader reader) {
            if(Settings.Default.Region == Region.Steam) {
                this.SteamDecode(reader);
            }
            if(Settings.Default.Region == Region.Korea) {
                this.KoreaDecode(reader);
            }
        }

        public void KoreaDecode(BitReader reader) {
            this.u64_0 = reader.ReadUInt64();
            this.flag = reader.ReadFlag();
            this.u16_0 = reader.ReadUInt16();
            this.b = reader.ReadByte();
            this.u16_1 = reader.ReadUInt16();
            this.u64_1 = reader.ReadUInt64();
            this.u64_2 = reader.ReadUInt64();
            this.u16_2 = reader.ReadUInt16();
            this.skillDamageEvent = reader.Read<SkillDamageEvent>(0);
        }

        public void SteamDecode(BitReader reader) {
            this.u16_0 = reader.ReadUInt16();
            this.u64_0 = reader.ReadUInt64();
            this.u16_1 = reader.ReadUInt16();
            this.flag = reader.ReadFlag();
            this.u16_2 = reader.ReadUInt16();
            this.u64_1 = reader.ReadUInt64();
            this.skillDamageEvent = reader.Read<SkillDamageEvent>(0);
            this.u64_2 = reader.ReadUInt64();
            this.b = reader.ReadByte();
        }
    }


    



}
