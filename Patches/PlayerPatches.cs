using HarmonyLib;
using Reptile;

namespace JustSitDown.Patches
{
    // TODO Review this file and update to your own requirements, or remove it altogether if not required

    /// <summary>
    /// Sample Harmony Patch class. Suggestion is to use one file per patched class
    /// though you can include multiple patch classes in one file.
    /// Below is included as an example, and should be replaced by classes and methods
    /// for your mod.
    /// </summary>
    [HarmonyPatch(typeof(Player))]
    internal class PlayerPatches
    {
        [HarmonyPatch(nameof(Player.Init))]
        [HarmonyPrefix]
        public static bool Awake_Prefix(Player __instance)
        {
            if (JustSitDownPlugin.player == null)
            {
                JustSitDownPlugin.player = __instance;
            }
            JustSitDownPlugin.Log.LogInfo("In Player Awake method Prefix.");
            return true;
        }

        [HarmonyPatch(nameof(Player.Awake))]
        [HarmonyPostfix]
        public static void Awake_Postfix(Player __instance)
        {
            
            //__instance.ActivateAbility(__instance.sitAbility);
            

            JustSitDownPlugin.Log.LogInfo("In Player Awake method Postfix.");
        }
    }
}