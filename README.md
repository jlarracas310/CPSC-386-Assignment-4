# Lost Land

**Lost Land** is a 2D platformer developed in Unity. You play as a stranded spaceman who must traverse through treacherous terrain filled with enemies, traps, and collectibles. Your mission: reach the end portal in each level while surviving the dangers and collecting all the gems.

---

## 🎮 Controls

- `A / D`: Move left/right  
- `Space`: Jump  
- `K`: Place teleport  
- `L`: Recall teleport  
- `P`: Pause menu  
- `ESC`: Quit game  

---

## 🕹️ Gameplay Overview

Lost Land challenges players to complete each level by reaching the exit portal while avoiding hazards like spikes, slimes, and flying enemies. Along the way, players can collect gems for an additional challenge. Dying resets you to the beginning of the level. A teleportation mechanic lets players save and recall a location for strategic maneuvering.

---

## 🧠 Key Scripts Summary

### 🎥 CameraControl.cs
- Follows player smoothly without rotation.

### 🧍 PlayerMovement.cs
- Handles left/right movement and jumping.
- Controls player animation states.
- Includes in-level quit and pause functionality.

### ❤️ PlayerStatus.cs
- Manages collision with enemies.
- Implements death animation, disables movement on death.
- Death counter persists across lives and levels.

### ⏸️ Pause.cs
- Implements the pause menu (`P` key).
- Freezes time and audio when paused.

### 💾 SaveState.cs
- Teleportation system with `K` (set) and `L` (recall).
- Includes cooldown to prevent spam.

### 💎 ItemCollection.cs
- Handles gem collection and UI counter.

### 🚪 Finish.cs
- Detects player reaching the portal and loads next level.

### 🏁 StartMenu.cs / SettingsMenu.cs / BackToMenu.cs / EndMenu.cs
- UI navigation between main menu, settings, pause menu, and quitting the game.
- Handles volume and fullscreen toggles using Unity’s Audio Mixer.

### 👾 EnemyPatrol.cs / EnemyFlyPatrol.cs
- Ground and flying enemies patrol between two points.
- Includes flipping direction logic for ground enemies.

---

## 🔧 Key Game Objects in Scenes

### Start Screen
- Title, animated player, and UI buttons (start, settings, quit).

### Settings Menu
- Volume slider and fullscreen toggle.
- “Back to Menu” button.

### Level 0 (Tutorial)
- Introduces basic movement and teleport controls.
- Teaches mechanics using simple design and prompts.

### Level 1
- Introduces spikes and gem collection challenges.
- Platforming and teleport strategy come into play.

### Level 2
- Vertical climb with flying and fast enemies.
- Emphasizes challenge and advanced timing.

### End Screen
- Thank you message, return to menu, and quit options.

---

## ✅ Project Requirements & Features

- ✅ Player input with in-game instruction prompts.
- ✅ Saving and loading (teleport system and persistent death counter).
- ✅ Multiple sound effects (jump, death, gem collection, music).
- ✅ Fully functional settings menu (volume + fullscreen toggle).
- ✅ Multiple animated objects (player, enemies, gems, portal).
- ✅ Main menu, in-game pause menu, and multiple scenes.
- ✅ Game can be quit from menus or via `ESC`.
- ✅ Unpause and return-to-menu functionality.
- ✅ Expanded gameplay scope from Assignment 3 (patrolling enemies, cooldowns).
- ✅ Emergent gameplay progression (increasing challenge, enemy types).
- ✅ Clear win/lose conditions, taught through gameplay design.

---

## 🎬 Scenes Summary

- **Start Screen**: UI buttons, character animation, consistent theme.
- **Settings Screen**: Volume, fullscreen toggle, and navigation.
- **Level 0**: Linear tutorial introducing movement, teleport, and hazards.
- **Level 1**: Platforming with terrain, traps, and collectibles.
- **Level 2**: Vertical challenge with increased enemy complexity.
- **End Screen**: Completion message with navigation options.

---

## 🆕 Improvements Since Last Submission

- Added persistent death counter.
- Added cooldown to teleport feature.
- Introduced patrolling enemies (slimes, flying eyes).
- Balanced level difficulty with new enemy placements and behaviors.
- Added a fast slime to surprise gem hunters.

---

## 📦 Referenced Assets & Tutorials

| Resource | Usage |
|---------|-------|
| [2D Player Movement In Unity](https://www.youtube.com/watch?v=K1xZ-rycYY8) by bendux | Ground check, base movement logic (modified) |
| [Unity Main Menu UI](https://www.youtube.com/watch?v=DX7HyN7oJjE) by Rehope Games | Button setup (light usage) |
| [Pause Menu in Unity](https://www.youtube.com/watch?v=JivuXdrIHK0) by Brackeys | Menu and pause logic (expanded with audio pause) |
| [Settings Menu in Unity](https://www.youtube.com/watch?v=YOaYQrN1oYQ) by Brackeys | Volume and fullscreen implementation (as-is) |
| [Enemy Patrolling Tutorial](https://www.youtube.com/watch?v=RuvfOl8HhhM) by MoreBBlakeyyy | Patrol scripts (as-is and modified) |
| [Pixel Adventure 1](https://assetstore.unity.com/packages/2d/characters/pixel-adventure-1-155360) by Pixel Frog | Spike assets (as-is) |
| [Super Grotto Escape Pack](https://assetstore.unity.com/packages/2d/environments/super-grotto-escape-pack-238393) by Ansimuz | Player, terrain, portals, enemies (as-is) |
| [Sunny Land](https://assetstore.unity.com/packages/2d/characters/sunny-land-103349) by Ansimuz | Gem assets (as-is) |
| [Unity 2D Checkpoints Tutorial](https://www.youtube.com/watch?v=VE_bkPrrZdE) by Rehope Games | Teleport idea inspiration |

---

## 🛠️ Built With

- Unity (2D)
- C# scripting
- Unity Tilemap, Animator, Audio Mixer
- Free Unity Asset Store resources

---
