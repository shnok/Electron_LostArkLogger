using LostArkLogger.Properties;
using System;
using System.Collections.Generic;
namespace LostArkLogger
{
    public class PKTNewProjectile {
        // Fields
        public ProjectileInfo projectileInfo;

        // Methods
        public PKTNewProjectile(BitReader reader) {
            if(Settings.Default.Region == Region.Steam) {
                this.SteamDecode(reader);
            }
            if(Settings.Default.Region == Region.Korea) {
                this.KoreaDecode(reader);
            }
        }

        public void KoreaDecode(BitReader reader) {
            this.projectileInfo = reader.Read<ProjectileInfo>(0);
        }

        public void SteamDecode(BitReader reader) {
            this.projectileInfo = reader.Read<ProjectileInfo>(0);
        }
    }


    



}
