# ATLS4519_VR_Midterm Project_Chen Kakam
Untitled Shooting Game.

## Description
This is a midterm project from CU Boulder ATLS4519. The project is a VR shooting game where player need to hold as long as possible. Player will spawn in the middle of the map and there will randomly spawn enemies around you. 

There are three types of enemy：the swordman will coming straight toward you and try to launch the thrust attack. The ranger will wondering around and shoot at player with bow. The sniper will stand still in the high ground and keep shooting player. 

The player will have a magic wand that can shoot the magical ball. Enemy take one hit to eliminated. Player have 20 hp that can take 20 attacks. Try to eliminate as more as possible enemies is the goal of this game. 

The game has the Qualisys Tracking system so player can dodge the incoming arrow and thrust in the room scale VR environment.The current build didn't enable the QTM system. To enable the tracking, just enable the QTM script and connect to the grid wifi netwok.

## Feature
Player can physically dodge all the incoming attack including the thrust from the swordman.

Player can also use wand to block the arrow and thrust.

Cool effect, animation and damage indicator.

## Scripts
angleOffset: Let the thrust effect always face the player and emit at correct location.

approaching: The swordman AI. The swordman will slowly approach the player and launch the attack when distant is close enough.

arrowFlying: The arrow logic. Always aim for the player's hitbox.

CameraTransformCorrection: Camera transform correction for the QTM.

damage: Monitor the hp and kill count of the player. It also decide when the damage indicator effect will play.

fireballLunch: Allow wand to shoot the magical ball.

hpMonitor: The 3D text that attach to the camera. Will show the HP left and kill count.

MeleeSpawner: Spawn the swordman around the player.

rangedAI: ranger AI. Will randomly walk around and shooting. Make player hard to aim.

rangeSpawner: Spawn the ranger around the player.

removeArrow: The arrow destory conditions.

sniper: sniper AI. Stand still and shoot at the player from the high ground.

sniperSpawner: Spawn the sniper at the high ground. It's more like a "refresher". It will remove the current sniper when spawn the new one.

swordThrust: Play the thrust effect and launch a invisible hitbox toward the player. If you are fast enough, you can block it or even dodge it.

timeOutRemove: just time out remover.




