using HarmonyLib;
using RimWorld;
using System.Reflection;
using Verse;
namespace Valkyria
{
    [StaticConstructorOnStartup]
    internal static class HarmonyInit
    {
        static HarmonyInit()
        {
            Harmony harmony = new Harmony("Valkyria");
            harmony.PatchAll();
        }
    }

}
