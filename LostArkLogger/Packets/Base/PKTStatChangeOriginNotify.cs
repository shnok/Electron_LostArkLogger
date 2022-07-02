using LostArkLogger.Properties;
using System;
using System.Collections.Generic;
namespace LostArkLogger
{
    public class PKTStatChangeOriginNotify {
        // Fields
        public StatPair StatPairChangedList;
        public StatPair StatPairList;
        public ulong ObjectId;
        public uint u32;
        public byte b_0;
        public byte b_1;

        // Methods
        public PKTStatChangeOriginNotify(BitReader reader) {
            if(Settings.Default.Region == Region.Steam) {
                this.SteamDecode(reader);
            }
            if(Settings.Default.Region == Region.Korea) {
                this.KoreaDecode(reader);
            }
        }

        public void KoreaDecode(BitReader reader) {
            this.b_0 = reader.ReadByte();
            this.ObjectId = reader.ReadUInt64();
            this.StatPairList = reader.Read<StatPair>(0);
            this.b_1 = reader.ReadByte();
            if(this.b_1 == 1) {
                this.u32 = reader.ReadUInt32();
            }
            this.StatPairChangedList = reader.Read<StatPair>(0);
        }

        public void SteamDecode(BitReader reader) {
            this.ObjectId = reader.ReadUInt64();
            this.b_0 = reader.ReadByte();
            if(this.b_0 == 1) {
                this.u32 = reader.ReadUInt32();
            }
            this.StatPairChangedList = reader.Read<StatPair>(0);
            this.b_1 = reader.ReadByte();
            this.StatPairList = reader.Read<StatPair>(0);
        }
    }


    



}
