using LostArkLogger.Properties;
using System;
using System.Collections.Generic;
namespace LostArkLogger
{
    public class PKTNewPC {
        // Fields
        public subPKTNewPC33 subPKTNewPC33;
        public PCStruct pCStruct;
        public byte[] bytearray_0;
        public byte[] bytearray_1;
        public uint u32;
        public byte b_0;
        public byte b_1;
        public byte b_2;
        public byte b_3;
        public byte b_4;
        public byte b_5;

        // Methods
        public PKTNewPC(BitReader reader) {
            if(Settings.Default.Region == Region.Steam) {
                this.SteamDecode(reader);
            }
            if(Settings.Default.Region == Region.Korea) {
                this.KoreaDecode(reader);
            }
        }

        public void KoreaDecode(BitReader reader) {
            this.b_0 = reader.ReadByte();
            if(this.b_0 == 1) {
                this.u32 = reader.ReadUInt32();
            }
            this.b_1 = reader.ReadByte();
            if(this.b_1 == 1) {
                this.bytearray_1 = reader.ReadBytes(12);
            }
            this.pCStruct = reader.Read<PCStruct>(0);
            this.b_2 = reader.ReadByte();
            if(this.b_2 == 1) {
                this.subPKTNewPC33 = reader.Read<subPKTNewPC33>(0);
            }
            this.b_3 = reader.ReadByte();
            this.b_4 = reader.ReadByte();
            if(this.b_4 == 1) {
                this.bytearray_0 = reader.ReadBytes(20);
            }
            this.b_5 = reader.ReadByte();
        }

        public void SteamDecode(BitReader reader) {
            this.b_0 = reader.ReadByte();
            this.b_1 = reader.ReadByte();
            if(this.b_1 == 1) {
                this.subPKTNewPC33 = reader.Read<subPKTNewPC33>(0);
            }
            this.pCStruct = reader.Read<PCStruct>(0);
            this.b_2 = reader.ReadByte();
            if(this.b_2 == 1) {
                this.bytearray_0 = reader.ReadBytes(20);
            }
            this.b_3 = reader.ReadByte();
            this.b_4 = reader.ReadByte();
            if(this.b_4 == 1) {
                this.bytearray_1 = reader.ReadBytes(12);
            }
            this.b_5 = reader.ReadByte();
            if(this.b_5 == 1) {
                this.u32 = reader.ReadUInt32();
            }
        }
    }


    



}
