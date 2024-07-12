using System;
using RimWorld;
using Verse;

namespace Valkyria
{
    public class HediffCompProperties_Valkyria : HediffCompProperties
    {
        public SongDef songDef;
        public HediffCompProperties_Valkyria() => this.compClass = typeof(HediffComp_Valkyria);

    }
}
