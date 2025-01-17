[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-22041afd0340ce965d47ae6ef1cefeee28c7c493a6346c4f15d667ab976d596c.svg)](https://classroom.github.com/a/MjLLqDcN)
# HW1
## W1L2 In-Class Activity
- Player
  - Move with WASD key
  - Space key plant seeds
  - Start with 5 seeds
- Seeds
  - Start with 5
  - Be planted when spacebar is pressed
- UI
  - number of plants
  - number of remaining seeds
- Players move with the WASD key and plant seeds with the spacebar. The seed will be planted on the space where the spacebar is pressed which will decrease one # of remaining seeds and increase one # of plants.

## Devlog
When I started working on HW1, I planned how the project would function by breaking it into small steps. My initial idea was simple: a player that could move with WASD or arrow keys and plant seeds with the SPACE key. The game would track how many seeds were left and how many had been planted, and this information would be displayed on the screen. At first, I didn’t think much about how the UI would be updated, but during development, I realized I needed to use a dedicated PlantCountUI script to handle that connection.

Writing the code felt pretty smooth once I had a clear plan. The Player class is where most of the action happens—it handles movement through the Update() method and planting seeds with PlantSeed(). The PlantCountUI script was critical for updating the "Seeds Left" and "Seeds Planted" text on the screen. Setting up the UI in Unity was satisfying. I created a Canvas with TextMeshPro objects for the seed counters and linked them to the script. Seeing everything come together was really rewarding.

The most valuable part of this process was learning how to connect the plan to actual functionality in Unity, like linking the Player class to the PlantCountUI and watching my ideas come to life in the game.

## Open-Source Assets
If you added any other outside assets, list them here!
- [Sprout Lands sprite asset pack](https://cupnooble.itch.io/sprout-lands-asset-pack) - character and item sprites

## Prof comments
Thank you for describing how you broke down the game into pieces and connected your breakdown to the code you wrote. I'm glad you found it satsifying to code!

Please consider formatting your break-down activities with the hyphen '-' symbol as suggested above, and remove the prompts. This will make it a lot easier for me to read. See the [README formatting guide here](https://docs.github.com/en/get-started/writing-on-github/getting-started-with-writing-and-formatting-on-github/basic-writing-and-formatting-syntax).
