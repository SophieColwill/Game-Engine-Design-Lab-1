# Space Escape Colors
## Sophie Colwill (100919358)

The main gameplay loop of Space Escape Colors is that, as soon as you load into the game you are thrusted into battle with space debris coming towards you. You use WASD to move around, and Left Shift to use your limited amount of boost to dodge the oncoming enemies. You keep going until you die, then try again to get a better highscore.

I think that my implementation of the Factory workflow was a rather good use of it as it makes my obstacle spawning code rather modular and easily expandable. All I have to do is create a new obstacle script, attach it to a prefab, then drag the prefab into my obstacle spawner script. Once that is done, I can repeat again and again until I have all the obstacles I want, and all I need to do is drag the prefab to the obstacle spawner to make it spawn in game. This would take more than double the lines of code to do, if I were to do it without the Factory design pattern.

## Factory Implementation
<img width="531" height="521" alt="Factory Implementation" src="https://github.com/user-attachments/assets/2415c9c9-a4ae-4f89-9366-97b235073c04" />
