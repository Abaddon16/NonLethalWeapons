using RimWorld;
using System;
using System.Collections.Generic;
using Verse;


namespace NonLethalWeapons {
	public class ThingDef_NLW_HediffProjectile : ThingDef {
		public float AddHediffChance;
		public List<HediffDef> HediffsToAdd;
	}
	public class Projectile_NLW_TranquilizerDart : Bullet {
		public ThingDef_NLW_HediffProjectile Def => this.def as ThingDef_NLW_HediffProjectile;

		protected override void Impact(Thing hitThing) {
			base.Impact(hitThing);
			if(this.Def != null && hitThing != null && hitThing is Pawn hitPawn) {
				if(!hitPawn.RaceProps.IsFlesh)
					return;
				foreach(HediffDef HediffToAdd in this.Def.HediffsToAdd) {
					float rand = Rand.Value;
					if(rand <= this.Def.AddHediffChance) {
						Hediff hediffOnPawn = hitPawn?.health?.hediffSet?.GetFirstHediffOfDef(HediffToAdd);
						float randomSeverity = Rand.Range(0.11f, 0.245f) / (float)Math.Pow(hitPawn.RaceProps.baseBodySize, 1.5f);
						if(hediffOnPawn != null)
							hediffOnPawn.Severity += randomSeverity;
						else {
							Hediff hediff = HediffMaker.MakeHediff(HediffToAdd, hitPawn, null);
							hediff.Severity = randomSeverity;
							hitPawn.health.AddHediff(hediff, null, null);
						}
					}
				}
			}
		}
	}
	public class Projectile_NLW_BeanBag : Bullet {
		public ThingDef_NLW_HediffProjectile Def => this.def as ThingDef_NLW_HediffProjectile;

		protected override void Impact(Thing hitThing) {
			base.Impact(hitThing);
			if(this.Def != null && hitThing != null && hitThing is Pawn hitPawn) {
				if(!hitPawn.RaceProps.IsFlesh)
					return;
				foreach(HediffDef HediffToAdd in this.Def.HediffsToAdd) {
					float rand = Rand.Value;
					if(rand <= this.Def.AddHediffChance) {
						Hediff hediffOnPawn = hitPawn?.health?.hediffSet?.GetFirstHediffOfDef(HediffToAdd);
						float randomSeverity = Rand.Range(0.125f, 0.3f) / (float)Math.Pow(hitPawn.RaceProps.baseBodySize, 1.5f);
						if(hediffOnPawn != null)
							hediffOnPawn.Severity += randomSeverity;
						else {
							Hediff hediff = HediffMaker.MakeHediff(HediffToAdd, hitPawn, null);
							hediff.Severity = randomSeverity;
							hitPawn.health.AddHediff(hediff, null, null);
						}
					}
				}
			}
		}
	}
}
