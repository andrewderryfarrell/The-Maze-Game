The-Maze-Game
=============

Super Awesome Game In Development


Project Assignments
===================
**Primary**

Valentin - Map Generation

Andrew - User Interface

Cormac - Enemy Movement / A.I.

Jordan - Enemy Movement / A.I.

Aaron - Player Movement

**Secondary**

Everyone - Help where needed if you can

Game Screens
============
1. Start Screen
  - Play Game
    - Start at Level 1
  - Load Level
    - Load certain maze level
    - If we have time to implement only
  - Instructions
    - How to play the game
  - Exit Game

2. Level
  - Fog of war over map
  - Camera zooms in only showing the player a certain amount of the map
  - Clicking the "M" key displays the entire maze showing each part which was discovered unfogged
  - Stamina Bar in top left corner
  - Enemies strategically placed
  - 5 pieces of injection code to inject yourself into the next level, cannot go ahead without it
    - Constant with all levels

3. Caught Screen
  - BSOD
  - "You were caught. Try to be a little stealthier next time"
  - Options
    - Retry Level
    - Exit to Main Menu

4. Success Screen
  - Dial up like tone / static which fades out the current map and fades in the next map

5. Instruction Screen
  - Movement
  - Make more noise when you run
  - Require collectibles to move on
  - What hacking a camera does

Player Specs
============
- WASD and Up, Down, Left, Right allow the player to walk around the maze
- Holding shift allows the player to run for a certain period of time before going back to walking and "recharging"
  - Update the stamina bar in the top-left of the map screen
- Constantly tells enemy objects whether player is walking or running so "Virus Scanners" can detect them.
- Pickup collectibles by running over them
- Holding "H" key next to a "Virus Scanner" allows you to hack it 
  - Instantaneous

Enemy Specs
===========
1. Virus Scanner (Camera)
  - Sits on wall, and rotates 180 degress
  - Visually scans hallway
  - Detects a person running by the camera even if not in vision
  - Alerts all patroling guards when player is detected
  - Ability to hack which changes function to alert player when patrolling unit passes
  - Graphical cone showing where the camera is looking, Red = unhacked, Green = Hacked

2. Patrolling Units
  - Randomly patrol map
  - Find shortest path to Virus Scanner which detects player
  - Graphical cone showing where the patrol is looking and how far
  - Lose patrol by getting far enough away or out of line of sight
  - Will revert back to randomly patrolling when player is lost
  - Will turn and follow player if running near patrol
  - On contact, player is caught
  - Follows player
