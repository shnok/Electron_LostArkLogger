using LostArkLogger.Properties;
using System;
using System.Collections.Generic;
namespace LostArkLogger
{
    public class SkillDamageEvent {
        // Fields
        public long CurrentHealth;
        public long Damage;
        public long MaxHealth;
        public ulong TargetId;
        public byte Modifier;
        public ushort u16;
        public byte b_0;
        public byte b_1;
        public byte b_2;

        // Methods
        public SkillDamageEvent(BitReader reader) {
            if(Settings.Default.Region == Region.Steam) {
                this.SteamDecode(reader);
            }
            if(Settings.Default.Region == Region.Korea) {
                this.KoreaDecode(reader);
            }
        }

        public void KoreaDecode(BitReader reader) {
            this.b_0 = reader.ReadByte();
            this.TargetId = reader.ReadUInt64();
            this.CurrentHealth = reader.ReadPackedInt();
            this.MaxHealth = reader.ReadPackedInt();
            this.u16 = reader.ReadUInt16();
            this.Modifier = reader.ReadByte();
            this.Damage = reader.ReadPackedInt();
            this.b_1 = reader.ReadByte();
            if(this.b_1 == 1) {
                this.b_2 = reader.ReadByte();
            }
        }

        public void SteamDecode(BitReader reader) {
            this.Modifier = reader.ReadByte();
            this.b_0 = reader.ReadByte();
            if(this.b_0 == 1) {
                this.b_1 = reader.ReadByte();
            }
            this.Damage = reader.ReadPackedInt();
            this.TargetId = reader.ReadUInt64();
            this.MaxHealth = reader.ReadPackedInt();
            this.CurrentHealth = reader.ReadPackedInt();
            this.u16 = reader.ReadUInt16();
            this.b_2 = reader.ReadByte();
        }
    }


    



}
