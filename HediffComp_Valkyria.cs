using System;
using RimWorld;
using UnityEngine;
using Verse;

namespace Valkyria
{
    public class HediffComp_Valkyria : HediffComp
    {
        public static readonly Color forcedHairColor = new Color(0.9019607f, 0.9450980f, 0.94117647f);
        public Color cacheHairColor;
        public HediffCompProperties_Valkyria Props => (HediffCompProperties_Valkyria)this.props;
        public override void CompPostMake()
        {
            base.CompPostMake();
            cacheHairColor = this.Pawn.story.HairColor;
            this.Pawn.story.HairColor = forcedHairColor;
            this.Pawn.Drawer.renderer.SetAllGraphicsDirty();
            MusicManagerPlay musicManagerPlay = Find.MusicManagerPlay;
            musicManagerPlay.ForcePlaySong(Props.songDef,true);
        }

        public override void CompPostPostRemoved()
        {
            base.CompPostPostRemoved();
            this.Pawn.story.HairColor = cacheHairColor;
            this.Pawn.Drawer.renderer.SetAllGraphicsDirty();
            MusicManagerPlay musicManagerPlay = Find.MusicManagerPlay;
            musicManagerPlay.Stop();


        }
    }
}
