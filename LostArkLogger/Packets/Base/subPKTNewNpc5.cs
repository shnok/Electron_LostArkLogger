using LostArkLogger.Properties;
using System;
using System.Collections.Generic;
namespace LostArkLogger
{
    public class subPKTNewNpc5 {
        // Fields
        public uint num;
        public List<byte> b = new List<byte>();

        // Methods
        public subPKTNewNpc5(BitReader reader) {
            if(Settings.Default.Region == Region.Steam) {
                this.SteamDecode(reader);
            }
            if(Settings.Default.Region == Region.Korea) {
                this.KoreaDecode(reader);
            }
        }

        public void KoreaDecode(BitReader reader) {
            this.num = reader.ReadUInt32();
            for(int i = 0; i < this.num; i++) {
                this.b.Add(reader.ReadByte());
            }
        }

        public void SteamDecode(BitReader reader) {
            this.num = reader.ReadUInt32();
            for(int i = 0; i < this.num; i++) {
                this.b.Add(reader.ReadByte());
            }
        }
    }


    



}
