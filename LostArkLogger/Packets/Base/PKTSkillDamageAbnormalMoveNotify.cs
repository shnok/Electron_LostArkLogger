using LostArkLogger.Properties;
using System;
using System.Collections.Generic;
namespace LostArkLogger
{
    public class PKTSkillDamageAbnormalMoveNotify {
        // Fields
        public ulong SourceId;
        public uint SkillEffectId;
        public uint SkillId;
        public List<SkillDamageMoveEvent> skillDamageMoveEvents;
        public uint u32;
        public byte b;

        // Methods
        public PKTSkillDamageAbnormalMoveNotify(BitReader reader) {
            if(Settings.Default.Region == Region.Steam) {
                this.SteamDecode(reader);
            }
            if(Settings.Default.Region == Region.Korea) {
                this.KoreaDecode(reader);
            }
        }

        public void KoreaDecode(BitReader reader) {
            this.SkillEffectId = reader.ReadUInt32();
            this.SkillId = reader.ReadUInt32();
            this.b = reader.ReadByte();
            this.skillDamageMoveEvents = reader.ReadList<SkillDamageMoveEvent>(0);
            this.SourceId = reader.ReadUInt64();
            this.u32 = reader.ReadUInt32();
        }

        public void SteamDecode(BitReader reader) {
            this.SourceId = reader.ReadUInt64();
            this.skillDamageMoveEvents = reader.ReadList<SkillDamageMoveEvent>(0);
            this.SkillEffectId = reader.ReadUInt32();
            this.u32 = reader.ReadUInt32();
            this.SkillId = reader.ReadUInt32();
            this.b = reader.ReadByte();
        }
    }


    



}
