using HarmonyLib;
using Verse;
using System.Collections.Generic;
namespace Valkyria
{
    [HarmonyPatch]
    public static class Patch_AddNotifyOnGeneration
    {
        [HarmonyPatch(typeof(PawnGenerator), "GenerateGenes")]
        [HarmonyPostfix]
        public static void PawnGenerator_GenerateGenes_Postfix(Pawn pawn)
        {
            //if (pawn.genes == null)
            //    return;
            //foreach (Gene gene in pawn.genes.GenesListForReading)
            //{
            //    if (gene is Gene_Valkyria gene_Valkyria)
            //        if (pawn.gender != Gender.Female)
            //        {
            //            pawn.genes.RemoveGene(gene_Valkyria);
            //        }
            //}
        }
    }
}
