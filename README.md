[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-22041afd0340ce965d47ae6ef1cefeee28c7c493a6346c4f15d667ab976d596c.svg)](https://classroom.github.com/a/7qg5CCgx)
# HW2
## Devlog
Looking first at the Player section of my plan, I did add a Collider and a Rigidbody to the Player GameObject in Unity. For jumping, I added in the Update method of the player code an if statement that checked for a space bar input for the player and if the player was grounded. If the player presses space, the AddForce method from the player's rigidbody is used to make the player object jump in game. For collecting coins, I added an OnTriggerEnter2D method as the coin would be the only trigger possible in the game. Once triggered, the player would up its _points variable and then proceed to update the points text itself as opposed to having a separate class for it like shown in my plan. For my coin spawner, I set up a timer in my CoinSpawner class. I then made a method in which if the timer passed over a random value, set earlier in the Start method, then a coin would be created through Instantiate. Then, it would reset the timer and select a new random number to vary coin spawn times. Finally, for the coins, in a new class, I just used their transform to use the Translate method to keep them constantly moving left once the were Instantiated in. In addition to this, to make sure they were "collected" by the player, I added an OnTriggerEnter2D method that made the coin destroy itself when it was triggered by something.


## Open-Source Assets
If you added any other outside assets, list them here!
- [Sprout Lands sprite asset pack](https://cupnooble.itch.io/sprout-lands-asset-pack) - rabbit and item sprites
- [Pixel Penguin 32x32 Asset pack](https://legends-games.itch.io/pixel-penguin-32x32-asset-pack) - penguin sprites
- [Coins 2D](https://artist2d3d.itch.io/2d) - coin sprites