# NLW Changelog

All notable changes will be in this file.



## [0.1.4c - Fixed BeanBag gun, working on PepperSpray] 2020-08-18
- Brain went the dumb and broke the BeanBag Gun, so I fixed that
- Working to implement PepperSpray. Similar to the BBG, but would have a smaller range with higher chance of applying the debuff
  - Not yet implemented, still heavy WIP
- Working on the BBG, I realize how messed up it is. Maybe PainSensitivity isn't the way to go, but Pain is? Dunno yet.

## [0.1.4a & 0.1.4b - Messing with folders] 2020-08-18
- Tried to update to the "Common" folder format, but that breaks 1.0 compatibility if I don't hella duplicate files so I reverted
- Minor attempts to balance the Tranquilizer towards 3 shots vs 2 shots
- Attempted to add a "techLevel" tag of "Industrial" to the guns so maybe raiders won't spawn with them super early on? Dunno :D

## [0.1.4 - Update to RW1.2] 2020-08-18

- Getting back into the swing of things. Trying to balance the Tranq gun.
  - Dropped amount of tranq to apply by .1 something
  - Reduced accuracy a smidge at longer ranges
  - increased cool down time by .05
- Checked on bean bag gun per some comments, still works as intended
  - Gun causes almost no pain on its own but it amplifies other pain. May change this in the future, but we shall see

## [0.1.3 - Update to RW1.1] 2020-02-17

- Jumped on the update bandwagon
- Easy update, just the requisite to get it working
- I will continue to update this as time goes on
  - I am starting a project with a group, and it's resparked my interest, so here we are

## [0.1.2 - tranq balance] 2018-12-21

- balancing the tranq gun
  - current is great for players but... not so great when raiders spawn with it
  - reducing range to... air rifle ish? values. Will continue to tweak
  - reducing accuracy to be reasonable

## [0.1.1 - graphics update] 2018-12-20

- updated graphics for the tranq gun and the bean bag shotgun
  - @Axinex did the tranq gun
  - I did the bean bag shotgun

## [0.1.1] - 2018-12-18

- added the beanbag shotgun (craftable at the machining table after the applicable research is complete)
  - cheaper, slower, more inaccurate at far range but more accurate at close range, much smaller range than the tranquilizer gun
  - adds a Pain Sensitivity Hediff that increases the target Pawn's sensitivity to pain significantly, and increasing amounts (it stacks, but also wears off)
- refactored code a smidge to make it more reusable
