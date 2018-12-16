using RimWorld;
using System;
using System.Collections.Generic;
using Verse;


namespace NonLethalWeapons {
	/**
		<summary>  A thing definition class of a non-lethal bullet. </summary>
		<remarks>  Abaddon16, 12/15/2018. </remarks>
		<seealso cref="T:Verse.ThingDef"/>
	*/
	public class ThingDef_NonLethalBullet:ThingDef {
		/** <summary>  The chance of adding the hediffs. </summary> */
		public float AddHediffChance;
		/** <summary>  A list of the hediffs to add. </summary> */
		public List<HediffDef> HediffsToAdd;
	}

	/**
		<summary>  A tranquilizer bullet object. </summary>
		<remarks> Abaddon16, 12/15/2018. </remarks>
		<seealso cref="T:RimWorld.Bullet"/>
	*/
	public class Projectile_TranquilizerBullet:Bullet {
		#region Properties
		/**
			<summary>  Gets the definition of the non-lethal bullet </summary>
			<value> The definition class. </value>
		*/
		public ThingDef_NonLethalBullet Def => this.def as ThingDef_NonLethalBullet;
		#endregion Properties

		#region Overrides
		/**
			<summary>  Code called on impact </summary>
			<remarks>  Abaddon16, 12/15/2018. </remarks>
			<param name="hitThing"> The thing being hit. </param>
		*/
		protected override void Impact(Thing hitThing) {
			base.Impact(hitThing);
			if(this.Def!=null&&hitThing!=null&&hitThing is Pawn hitPawn) {
				if(!hitPawn.RaceProps.IsFlesh)
					return;
				foreach(HediffDef HediffToAdd in this.Def.HediffsToAdd) {
					float rand = Rand.Value;
					if(rand<=this.Def.AddHediffChance) {
						Hediff hediffOnPawn = hitPawn?.health?.hediffSet?.GetFirstHediffOfDef(HediffToAdd);
						float randomSeverity = Rand.Range(0.25f, 0.4285f)/(float)Math.Pow(hitPawn.RaceProps.baseBodySize, 1.5f);
						if(hediffOnPawn!=null)
							hediffOnPawn.Severity+=randomSeverity;
						else {
							Hediff hediff = HediffMaker.MakeHediff(HediffToAdd, hitPawn, null);
							hediff.Severity=randomSeverity;
							hitPawn.health.AddHediff(hediff, null, null);
						}
					}
				}
			}
		}
		#endregion Overrides
	}
}
