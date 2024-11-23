using HarmonyLib;
// ReSharper disable InconsistentNaming
// ReSharper disable RedundantAssignment

namespace ProgressTweaks.Patches {
    [HarmonyPatch(typeof(progressManager))]
    public static class progressManager_Patch {
        [HarmonyPatch("hasPlayerClickedBothExtras")]
        [HarmonyPostfix]
        public static void hasPlayerClickedBothExtras_Postfix(ref bool __result) {
            __result = true;
        }
        
        [HarmonyPatch("doesPlayerHaveLevelSelect")]
        [HarmonyPostfix]
        public static void doesPlayerHaveLevelSelect_Postfix(ref bool __result) {
            __result = true;
        }
        
        [HarmonyPatch("hasPlayerSeenHintPopup")]
        [HarmonyPostfix]
        public static void hasPlayerSeenHintPopup_Postfix(ref bool __result) {
            __result = true;
        }
    }
}