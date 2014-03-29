The-Maze-Game
=============

Super Awesome Game In Development


Project Assignments
===================
Primary

Valentin - Map Generation
Andrew - User Interface
Cormac - Enemy Movement / A.I.
Jordan - Enemy Movement / A.I.
Aaron - Player Movement

Secondary

Everyone - Help where needed if you can

Game Screens
============
1. Start Screen
  a. Play Game
    - Start at Level 1
  b. Load Level
    - Load certain maze level
    - If we have time to implement only
  c. Instructions
    - How to play the game
  d. Exit Game

2. Level
  a. Fog of war over map
  b. Camera zooms in only showing the player a certain amount of the map
  c. Clicking the "M" key displays the entire maze showing each part which was discovered unfogged
  d. Stamina Bar in top left corner
  e. Enemies strategically placed
  f. 5 pieces of injection code to inject yourself into the next level, cannot go ahead without it
    - Constant with all levels

3. Caught Screen
  a. BSOD
  b. "You were caught. Try to be a little stealthier next time"
  c. Options
    - Retry Level
    - Exit to Main Menu

4. Success Screen
  a. Dial up like tone / static which fades out the current map and fades in the next map

5. Instruction Screen
  a. Movement
  b. Make more noise when you run
  c. Require collectibles to move on
  d. What hacking a camera does

Player Specs
============
1. WASD and Up, Down, Left, Right allow the player to walk around the maze
2. Holding shift allows the player to run for a certain period of time before going back to walking and "recharging"
  a. Update the stamina bar in the top-left of the map screen
3. Constantly tells enemy objects whether player is walking or running so "Virus Scanners" can detect them.
4. Pickup collectibles by running over them
5. Holding "H" key next to a "Virus Scanner" allows you to hack it 
  a. Instantaneous

Enemy Specs
===========
1. Virus Scanner (Camera)
  a. Sits on wall, and rotates 180 degress
  b. Visually scans hallway
  c. Detects a person running by the camera even if not in vision
  d. Alerts all patroling guards when player is detected
  e. Ability to hack which changes function to alert player when patrolling unit passes
  f. Graphical cone showing where the camera is looking, Red = unhacked, Green = Hacked

2. Patrolling Units
  a. Randomly patrol map
  b. Find shortest path to Virus Scanner which detects player
  c. Graphical cone showing where the patrol is looking and how far
  d. Lose patrol by getting far enough away or out of line of sight
  e. Will revert back to randomly patrolling when player is lost
  f. Will turn and follow player if running near patrol
  g. On contact, player is caught
  h. Follows player
