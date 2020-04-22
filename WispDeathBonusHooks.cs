﻿using RoR2;

namespace WispDeathBonus
{
    internal class WispDeathBonusHooks
    {
        internal static void Init()
        {
            On.EntityStates.Wisp1Monster.DeathState.OnEnter += WispDeathHook;
            On.RoR2.CharacterBody.RecalculateStats += WispBonusRecalculate;
        }

        private static void WispDeathHook(On.EntityStates.Wisp1Monster.DeathState.orig_OnEnter orig, EntityStates.Wisp1Monster.DeathState self)
        {
            orig(self);
            try
            {

            }
            catch { }
        }

        private static void WispBonusRecalculate(On.RoR2.CharacterBody.orig_RecalculateStats orig, CharacterBody self)
        {
            orig(self);
            try
            {

            }
            catch { }
        }
    }
}