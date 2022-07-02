using LostArkLogger.Properties;
using System;
using System.Collections.Generic;
namespace LostArkLogger
{
    public class PKTSkillStageNotify {
        // Fields
        public ulong SourceId;
        public uint SkillId;
        public byte Stage;
        public byte[] bytearray_0;
        public byte[] bytearray_1;
        public byte[] bytearray_2;
        public byte[] bytearray_3;

        // Methods
        public PKTSkillStageNotify(BitReader reader) {
            if(Settings.Default.Region == Region.Steam) {
                this.SteamDecode(reader);
            }
            if(Settings.Default.Region == Region.Korea) {
                this.KoreaDecode(reader);
            }
        }

        public void KoreaDecode(BitReader reader) {
            this.bytearray_0 = reader.ReadBytes(0x16);
            this.SourceId = reader.ReadUInt64();
            this.bytearray_2 = reader.ReadBytes(1);
            this.Stage = reader.ReadByte();
            this.bytearray_3 = reader.ReadBytes(0);
            this.SkillId = reader.ReadUInt32();
            this.bytearray_1 = reader.ReadBytes(0x10);
        }

        public void SteamDecode(BitReader reader) {
            this.bytearray_3 = reader.ReadBytes(0);
            this.SourceId = reader.ReadUInt64();
            this.bytearray_2 = reader.ReadBytes(1);
            this.SkillId = reader.ReadUInt32();
            this.bytearray_0 = reader.ReadBytes(0x23);
            this.Stage = reader.ReadByte();
            this.bytearray_1 = reader.ReadBytes(4);
        }
    }


    



}
