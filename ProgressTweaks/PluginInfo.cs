using System.Reflection;
using ProgressTweaks;

#region Assembly attributes

[assembly: AssemblyVersion(PluginInfo.PLUGIN_VERSION)]
[assembly: AssemblyTitle(PluginInfo.PLUGIN_NAME + " (" + PluginInfo.PLUGIN_ID + ")")]
[assembly: AssemblyProduct(PluginInfo.PLUGIN_NAME)]

#endregion

namespace ProgressTweaks {
    internal static class PluginInfo {
        public const string PLUGIN_NAME = "Progress Tweaks";
        
        public const string PLUGIN_ID = "com.flowndev.progresstweaks";

        public const string PLUGIN_VERSION = "1.0.0";
    }
}