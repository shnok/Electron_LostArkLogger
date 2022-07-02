using LostArkLogger.Properties;
using System;
using System.Collections.Generic;
namespace LostArkLogger
{
    public class subPKTInitEnv5 {
        // Fields
        public List<List<byte>> blist_0 = new List<List<byte>>();
        public List<List<byte>> blist_1 = new List<List<byte>>();
        public List<List<byte>> blist_2 = new List<List<byte>>();
        public ushort num;

        // Methods
        public subPKTInitEnv5(BitReader reader) {
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
                this.blist_2.Add(reader.ReadList<byte>(0));
                this.blist_1.Add(reader.ReadList<byte>(0));
                this.blist_0.Add(reader.ReadList<byte>(0));
            }
        }

        public void SteamDecode(BitReader reader) {
            this.num = reader.ReadUInt16();
            for(int i = 0; i < this.num; i++) {
                this.blist_0.Add(reader.ReadList<byte>(0));
                this.blist_2.Add(reader.ReadList<byte>(0));
                this.blist_1.Add(reader.ReadList<byte>(0));
            }
        }
    }


    



}
