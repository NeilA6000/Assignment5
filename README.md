I made many modifications to the script but the notable ones are
1. Adding an isGrounded bool for the detection to stop jumping if false.
2. If trigger and compare tags for the platform so the bool will change from true to false when jumping and not colliding with the platform.
Next, I added a simple retro arcade music to my game which I'll show to you later, which loops and plays on awake.
Lastly as a bonus, i added a nice win script to the end of my game.
All scripts can be found in this repository.
I didn't really have any challenges, none of this is new to me, however, sorting layers is a challenge for me, so I decided just to match up the z coordinates for collisions instead of using sorting layers.
I'm most proud of the gravity and the collision bool I added to the player-controller script.
