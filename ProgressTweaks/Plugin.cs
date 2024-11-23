using BepInEx;
using HarmonyLib;

namespace ProgressTweaks {
    [BepInPlugin(PluginInfo.PLUGIN_ID, PluginInfo.PLUGIN_NAME, PluginInfo.PLUGIN_VERSION)]
    public class Plugin : BaseUnityPlugin {
        private Harmony _harmony;
        
        private void Awake() {
            _harmony = new Harmony(PluginInfo.PLUGIN_ID);
            _harmony.PatchAll();
        }
    }
}