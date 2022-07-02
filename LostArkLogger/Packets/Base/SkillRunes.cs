using LostArkLogger.Properties;
using System;
using System.Collections.Generic;
namespace LostArkLogger
{
    public class SkillRunes {
        // Fields
        public List<List<uint>> u32list = new List<List<uint>>();
        public List<uint> u32 = new List<uint>();
        public ushort num;

        // Methods
        public SkillRunes(BitReader reader) {
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
                this.u32.Add(reader.ReadUInt32());
                this.u32list.Add(reader.ReadList<uint>(0));
            }
        }

        public void SteamDecode(BitReader reader) {
            this.num = reader.ReadUInt16();
            for(int i = 0; i < this.num; i++) {
                this.u32list.Add(reader.ReadList<uint>(0));
                this.u32.Add(reader.ReadUInt32());
            }
        }
    }


    



}
