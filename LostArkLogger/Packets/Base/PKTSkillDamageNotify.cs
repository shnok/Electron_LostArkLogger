using LostArkLogger.Properties;
using System;
using System.Collections.Generic;
namespace LostArkLogger
{
    public class PKTSkillDamageNotify {
        // Fields
        public ulong SourceId;
        public uint SkillEffectId;
        public uint SkillId;
        public List<SkillDamageEvent> skillDamageEvents;
        public byte b;

        // Methods
        public PKTSkillDamageNotify(BitReader reader) {
            if(Settings.Default.Region == Region.Steam) {
                this.SteamDecode(reader);
            }
            if(Settings.Default.Region == Region.Korea) {
                this.KoreaDecode(reader);
            }
        }

        public void KoreaDecode(BitReader reader) {
            this.skillDamageEvents = reader.ReadList<SkillDamageEvent>(0);
            this.b = reader.ReadByte();
            this.SourceId = reader.ReadUInt64();
            this.SkillEffectId = reader.ReadUInt32();
            this.SkillId = reader.ReadUInt32();
        }

        public void SteamDecode(BitReader reader) {
            this.SkillId = reader.ReadUInt32();
            this.SkillEffectId = reader.ReadUInt32();
            this.skillDamageEvents = reader.ReadList<SkillDamageEvent>(0);
            this.b = reader.ReadByte();
            this.SourceId = reader.ReadUInt64();
        }
    }


    



}
