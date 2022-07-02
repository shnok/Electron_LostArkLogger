using LostArkLogger.Properties;
using System;
using System.Collections.Generic;
namespace LostArkLogger
{
    public class subPKTNewPC33 {
        // Fields
        public byte[] bytearray_0;
        public byte[] bytearray_1;
        public uint u32_0;
        public uint u32_1;
        public byte b;

        // Methods
        public subPKTNewPC33(BitReader reader) {
            if(Settings.Default.Region == Region.Steam) {
                this.SteamDecode(reader);
            }
            if(Settings.Default.Region == Region.Korea) {
                this.KoreaDecode(reader);
            }
        }

        public void KoreaDecode(BitReader reader) {
            this.bytearray_0 = reader.ReadBytes(12);
            this.u32_0 = reader.ReadUInt32();
            this.b = reader.ReadByte();
            if(this.b == 1) {
                this.bytearray_1 = reader.ReadBytes(12);
            }
            this.u32_1 = reader.ReadUInt32();
        }

        public void SteamDecode(BitReader reader) {
            this.b = reader.ReadByte();
            if(this.b == 1) {
                this.bytearray_0 = reader.ReadBytes(12);
            }
            this.u32_0 = reader.ReadUInt32();
            this.bytearray_1 = reader.ReadBytes(12);
            this.u32_1 = reader.ReadUInt32();
        }
    }


    



}
