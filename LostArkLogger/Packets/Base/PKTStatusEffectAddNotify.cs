using LostArkLogger.Properties;
using System;
using System.Collections.Generic;
namespace LostArkLogger
{
    public class PKTStatusEffectAddNotify {
        // Fields
        public ulong ObjectId;
        public byte New;
        public StatusEffectData statusEffectData;
        public ulong u64;

        // Methods
        public PKTStatusEffectAddNotify(BitReader reader) {
            if(Settings.Default.Region == Region.Steam) {
                this.SteamDecode(reader);
            }
            if(Settings.Default.Region == Region.Korea) {
                this.KoreaDecode(reader);
            }
        }

        public void KoreaDecode(BitReader reader) {
            this.u64 = reader.ReadUInt64();
            this.New = reader.ReadByte();
            this.statusEffectData = reader.Read<StatusEffectData>(0);
            this.ObjectId = reader.ReadUInt64();
        }

        public void SteamDecode(BitReader reader) {
            this.ObjectId = reader.ReadUInt64();
            this.New = reader.ReadByte();
            this.u64 = reader.ReadUInt64();
            this.statusEffectData = reader.Read<StatusEffectData>(0);
        }
    }


    



}
