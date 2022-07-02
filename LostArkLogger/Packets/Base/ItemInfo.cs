using LostArkLogger.Properties;
using System;
using System.Collections.Generic;
namespace LostArkLogger
{
    public class ItemInfo {
        // Fields
        public ushort Level;
        public ulong s64;
        public List<byte[]> bytearraylist;
        public uint u32;
        public ushort u16;
        public byte b_0;
        public byte b_1;

        // Methods
        public ItemInfo(BitReader reader) {
            if(Settings.Default.Region == Region.Steam) {
                this.SteamDecode(reader);
            }
            if(Settings.Default.Region == Region.Korea) {
                this.KoreaDecode(reader);
            }
        }

        public void KoreaDecode(BitReader reader) {
            this.u32 = reader.ReadUInt32();
            this.u16 = reader.ReadUInt16();
            this.b_0 = reader.ReadByte();
            if(this.b_0 == 1) {
                this.b_1 = reader.ReadByte();
            }
            this.bytearraylist = reader.ReadList<byte[]>(14);
            this.s64 = reader.ReadSimpleInt();
            this.Level = reader.ReadUInt16();
        }

        public void SteamDecode(BitReader reader) {
            this.u16 = reader.ReadUInt16();
            this.bytearraylist = reader.ReadList<byte[]>(14);
            this.s64 = reader.ReadSimpleInt();
            this.b_0 = reader.ReadByte();
            if(this.b_0 == 1) {
                this.b_1 = reader.ReadByte();
            }
            this.u32 = reader.ReadUInt32();
            this.Level = reader.ReadUInt16();
        }
    }
}
