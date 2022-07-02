using System;
namespace LostArkLogger
{
    public enum OpCodes_Steam : ushort {
        PKTAuthTokenResult = 0x401c,
        PKTCounterAttackNotify = 0xc679,
        PKTDeathNotify = 0x950a,
        PKTInitEnv = 0xea55,
        PKTInitPC = 0x8f3a,
        PKTNewNpc = 0x368e,
        PKTNewNpcSummon = 0x3dc,
        PKTNewPC = 0x8159,
        PKTNewProjectile = 0x2213,
        PKTRaidBossKillNotify = 0x7233,
        PKTRaidResult = 0x3a8,
        PKTRemoveObject = 0x174d,
        PKTSkillDamageAbnormalMoveNotify = 0x5395,
        PKTSkillDamageNotify = 0xa17a,
        PKTSkillStageNotify = 0xcf8d,
        PKTSkillStartNotify = 0xc373,
        PKTStatChangeOriginNotify = 0x32da,
        PKTStatusEffectAddNotify = 0x42a5,
        PKTTriggerBossBattleStatus = 0x76e0
    }
}
