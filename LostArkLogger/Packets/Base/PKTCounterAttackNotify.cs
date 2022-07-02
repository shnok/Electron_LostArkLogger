using LostArkLogger.Properties;
using System;
using System.Collections.Generic;
namespace LostArkLogger
{
    public class PKTCounterAttackNotify {
        // Fields
        public ulong SourceId;
        public ulong TargetId;
        public byte[] bytearray_0;
        public byte[] bytearray_1;
        public byte[] bytearray_2;

        // Methods
        public PKTCounterAttackNotify(BitReader reader) {
            if(Settings.Default.Region == Region.Steam) {
                this.SteamDecode(reader);
            }
            if(Settings.Default.Region == Region.Korea) {
                this.KoreaDecode(reader);
            }
        }

        public void KoreaDecode(BitReader reader) {
            this.bytearray_0 = reader.ReadBytes(6);
            this.SourceId = reader.ReadUInt64();
            this.bytearray_1 = reader.ReadBytes(0);
            this.TargetId = reader.ReadUInt64();
            this.bytearray_2 = reader.ReadBytes(0);
        }

        public void SteamDecode(BitReader reader) {
            this.bytearray_0 = reader.ReadBytes(4);
            this.TargetId = reader.ReadUInt64();
            this.bytearray_1 = reader.ReadBytes(3);
            this.SourceId = reader.ReadUInt64();
            this.bytearray_2 = reader.ReadBytes(0);
        }
    }
}
