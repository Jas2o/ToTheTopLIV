using HarmonyLib;
using MelonLoader;

namespace ToTheTopLIV {
    [HarmonyPatch]
    public static class Patches {

        [HarmonyPostfix]
        [HarmonyPatch(typeof(TTTPlayerController), "Init")]
        private static void SetUpLiv(TTTPlayerController __instance) {
            MelonLogger.Msg("## Patches : Player-Init-SetUpLiv ##");
            ToTheTopLIVMod.OnPlayerReady();
        }
    }
}
