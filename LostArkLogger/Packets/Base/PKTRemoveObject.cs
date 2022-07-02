using LostArkLogger.Properties;
using System;
using System.Collections.Generic;
namespace LostArkLogger
{
    public class PKTRemoveObject {
        // Fields
        public List<byte> blist;

        // Methods
        public PKTRemoveObject(BitReader reader) {
            if(Settings.Default.Region == Region.Steam) {
                this.SteamDecode(reader);
            }
            if(Settings.Default.Region == Region.Korea) {
                this.KoreaDecode(reader);
            }
        }

        public void KoreaDecode(BitReader reader) {
            this.blist = reader.ReadList<byte>(0);
        }

        public void SteamDecode(BitReader reader) {
            this.blist = reader.ReadList<byte>(0);
        }
    }


    



}
