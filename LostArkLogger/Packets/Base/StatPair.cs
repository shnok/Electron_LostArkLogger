using LostArkLogger.Properties;
using System;
using System.Collections.Generic;
namespace LostArkLogger
{
    public class StatPair {
        // Fields
        public List<long> Value = new List<long>();
        public List<byte> StatType = new List<byte>();
        public ushort num;

        // Methods
        public StatPair(BitReader reader) {
            if(Settings.Default.Region == Region.Steam) {
                this.SteamDecode(reader);
            }
            if(Settings.Default.Region == Region.Korea) {
                this.KoreaDecode(reader);
            }
        }

        public void KoreaDecode(BitReader reader) {
            this.num = reader.ReadUInt16();
            for(int i = 0; i < this.num; i++) {
                this.StatType.Add(reader.ReadByte());
                this.Value.Add(reader.ReadPackedInt());
            }
        }

        public void SteamDecode(BitReader reader) {
            this.num = reader.ReadUInt16();
            for(int i = 0; i < this.num; i++) {
                this.StatType.Add(reader.ReadByte());
                this.Value.Add(reader.ReadPackedInt());
            }
        }
    }


    



}
