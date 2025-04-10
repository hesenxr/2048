# 2048 Game

## Overview

The 2048 game is a single-player sliding block puzzle game where the objective is to combine numbered tiles on a grid to create a tile with the value 2048. The game was originally created by Gabriele Cirulli and has gained popularity due to its simple yet challenging gameplay.

This documentation provides an overview of the game mechanics, instructions on how to play, and details about the features and customization options available in this implementation.

---

## Features

1. **Normal Game Mode**
2. **Customizable Game Mode**
3. **Game Controls**
4. **Score Tracking**
5. **Undo Feature**
6. **Game Over and Win Conditions**
7. **Main Menu and Exit Options**

---

## 🎮 Normal Game Mode

- Starts with a 4x4 grid
- Objective: reach a tile with the value 2048 (standard mode)

---

## ⚙️ Customizable Game Mode

- Configure grid size (between 3x3 and 10x10)
- Set custom target tile value
- Adds flexibility and challenge

---

## 🕹 Game Controls

- **Arrow Keys**: Slide tiles (Up, Down, Left, Right)
- **Reset Button**: Restart the game
- **Undo Button**: Undo the last move
- **Main Menu Button**: Return to main menu
- **Exit Game Button**: Close the game

---

## 📊 Score Tracking

- Tracks **current score** (based on merges)
- **Best score** saved between sessions

---

## ↩️ Undo Feature

- Reverts the board to its state before the last move
- Helpful for strategy and fixing mistakes

---

## 🚫 Game Over and 🎉 Win Conditions

- **Game Over**: No valid moves (no empty spaces and no matching tiles)
- **Win**: A tile reaches the target value (2048 or custom)

---

## 🧭 Main Menu and Exit Options

- **Main Menu**: Start Normal or Custom Game, or exit
- **Exit**: Can be done from any screen

---

## 📖 How to Play

1. **Start the Game**: Launch app → Welcome screen
2. **Select Mode**:
   - Normal Game: Click `Normal Game`
   - Custom Game: Click `Customizable Game`, set grid and target
3. **Play**:
   - Use arrow keys to combine tiles
   - Use Undo if needed
   - Game ends on win or no moves
4. **Restart or Exit**:
   - Reset: Restart current game
   - Main Menu: Return to Welcome
   - Exit: Close app

---

## 🎛 Customization Options

- **Grid Size**: Between 3x3 and 10x10
- **Target Value**: Any positive integer

---

## 🖥 User Interface

1. **Game Grid**: Where the action happens
2. **Score Display**: Shows current and best score
3. **Control Buttons**: Reset, Undo, Menu, Exit

---

## 📂 Project Info

Built using **C# and WinForms** on Windows (runs via Visual Studio).

---

## 🚀 Future Ideas

- Add sound effects
- Leaderboard
- Save/load feature

