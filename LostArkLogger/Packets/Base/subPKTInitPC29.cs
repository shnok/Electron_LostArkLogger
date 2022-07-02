using LostArkLogger.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LostArkLogger {
    public class subPKTInitPC29 {
        // Fields
        public long p64_0;
        public long p64_1;
        public ulong u64;
        public ushort u16;
        public byte b_0;
        public byte b_1;
        public byte b_2;

        // Methods
        public subPKTInitPC29(BitReader reader) {
            if(Settings.Default.Region == Region.Steam) {
                this.SteamDecode(reader);
            }
            if(Settings.Default.Region == Region.Korea) {
                this.KoreaDecode(reader);
            }
        }

        public void KoreaDecode(BitReader reader) {
            this.u64 = reader.ReadUInt64();
            this.p64_0 = reader.ReadPackedInt();
            this.u16 = reader.ReadUInt16();
            this.b_0 = reader.ReadByte();
            this.b_1 = reader.ReadByte();
            this.b_2 = reader.ReadByte();
            this.p64_1 = reader.ReadPackedInt();
        }

        public void SteamDecode(BitReader reader) {
            this.u64 = reader.ReadUInt64();
            this.p64_0 = reader.ReadPackedInt();
            this.u16 = reader.ReadUInt16();
            this.b_0 = reader.ReadByte();
            this.b_1 = reader.ReadByte();
            this.b_2 = reader.ReadByte();
            this.p64_1 = reader.ReadPackedInt();
        }
    }


    




}
