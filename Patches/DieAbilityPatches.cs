using HarmonyLib;
using Reptile;
using JustSitDown;

namespace JustSitDown.Patches
{

    [HarmonyPatch(typeof(DieAbility))]
    internal class DieAbilityPatches
    {
        [HarmonyPatch(nameof(DieAbility.Init))]
        [HarmonyPostfix]
        public static void Init_Postfix(DieAbility __instance)
        {
            JustSitDownPlugin.dieAbility = __instance;
        }
    }
}