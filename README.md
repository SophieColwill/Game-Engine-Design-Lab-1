# Sophie Colwill (100919358)

Bullet Hell Lab 1 Thing:
The main gameplay loop of this, is you use WASD to move around dodging enemies. While the player controls are really basic, the difficulty comes from the enmies as not only do different enemy variations spawn as time goes on, but they also get faster & more frequent. When making it, I did remember a game called "Just Shapes & Beats" so the project is colored with those colors fully in mind.

The system I used the singleton on in my project was the score keeper / wave keeper. It held the player's high score and current score, along with all the base enemy values since they change based on how large your score is. I choose to adopt it here as almost everything in the project, minus the player, would have to refrence everything held within in one way or another. This meant that grouping it up as an "easy to access" class was going to save me alot of work.
In the end, I do think that making it a singleton was benifical in the way I implemented it since not only did it mean that keeping a High Score for the player was easy, but all the refrences that I would have had to make otherwise made the amount of code I had to write a substantial amount less.

My Code Diagram:
<img width="761" height="481" alt="Lab 1 Diagram" src="https://github.com/user-attachments/assets/b12bfd2e-5554-44cb-9804-3a69648c977b" />
