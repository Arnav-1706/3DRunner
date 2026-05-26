# 3D Runner Racing Game 🎮

A 3D endless runner racing game developed using **Unity Engine** and **C#**.
The game features AI-controlled opponents, obstacle avoidance, speed boosts, particle effects, animations, audio systems, and smooth player movement mechanics.

---

# 📌 Table of Contents

* [Introduction](#introduction)
* [Game Overview](#game-overview)
* [Features](#features)
* [Controls](#controls)
* [Game Mechanics](#game-mechanics)
* [Technologies Used](#technologies-used)
* [Project Structure](#project-structure)
* [How to Run](#how-to-run)
* [Screenshots](#screenshots)
* [Future Improvements](#future-improvements)
* [References](#references)
* [GitHub Link](#github-link)

---

# Introduction

## Purpose

The purpose of this project is to develop a 3D endless runner racing game using Unity and C#.
The project demonstrates core game development concepts such as:

* Player movement
* AI opponents
* Collision systems
* Animations
* Audio integration
* Particle systems
* Environment design
* UI systems

## Scope

This project focuses on creating a beginner-friendly racing game where the player competes against AI-controlled opponents on an obstacle-filled track.

---

# Game Overview

## Genre

3D Endless Runner / Racing Game

## Target Audience

* Casual gamers
* Beginner players
* Students learning Unity game development

## Story

The player participates in a futuristic running competition against AI-controlled opponents.
The objective is to avoid obstacles, maintain speed, collect boosts, and reach the finish line before opponents.

---

# Features 🚀

* Smooth player movement
* AI opponents using NavMesh
* Speed boost system
* Slowness obstacles
* Coin collection system
* Collision detection
* Particle effects
* Audio effects
* Running animations
* Game over system
* Finish line detection
* Ranking system

---

# Controls 🎮

| Key | Action        |
| --- | ------------- |
| W   | Move Forward  |
| S   | Move Backward |
| A   | Move Left     |
| D   | Move Right    |

---

# Game Mechanics

## Player Movement

* Continuous smooth movement
* Boundary limitation using `Mathf.Clamp`
* Keyboard input handling
* Animator-controlled running animation

## Opponent AI

* Uses Unity `NavMeshAgent`
* Automatically follows race path
* Competes against the player

## Collision System

Implemented using:

* Collider components
* Trigger systems
* `OnCollisionEnter()`
* `OnTriggerEnter()`

## Power-Ups

### Speed Boost

* Temporarily increases player speed
* Plays particle effects and sound effects

### Slowness Effect

* Reduces movement speed temporarily
* Displays slowdown particles

## Audio System

The game includes:

* Coin collection sounds
* Obstacle collision sounds
* Finish line victory sound
* Background audio effects

## Particle Effects

Particle systems are used for:

* Speed boost effects
* Slowness effects

---

# Technologies Used 🛠️

* Unity 6 (6000.3.10f1)
* C#
* Unity NavMesh System
* Unity Animator
* Unity Particle System
* TextMeshPro

---

# Project Structure 📂

```plaintext
Assets/
│
├── Animations/
├── Models/
├── NavMesh/
├── Prefabs/
├── Scenes/
├── Scripts/
├── Sprites/
└── TextMesh Pro/
```

---

# How to Run ▶️

## Prerequisites

Install:

* Unity Hub
* Unity Editor 6000.3.10f1

## Steps

1. Clone the repository:

```bash
git clone https://github.com/Arnav-1706/3DRunner.git
```

2. Open Unity Hub

3. Click:

```plaintext
Add Project
```

4. Select the cloned project folder

5. Open the scene inside:

```plaintext
Assets/Scenes
```

6. Press:

```plaintext
Play
```

---

# Screenshots 📸

## Main Gameplay

* Player racing against AI opponents
* Obstacle system
* Speed boost zones
* Coin collection

## Systems Included

* Player Controller Script
* Opponent AI Script
* Ranking System
* Particle Effects
* Collision Systems

---

# Future Improvements 🔥

Possible future enhancements include:

* Multiple levels
* Improved AI behavior
* Multiplayer support
* Mobile support
* Character customization
* Advanced VFX
* Online leaderboard system
* Better obstacle variety

---

# References 📚

## Books

1. Game Development with Unity by Michelle Menard
2. Unity 2018 Game Development in 24 Hours by Mike Geig
3. Mastering Game Design with Unity 2021 by Scott Tykoski

## Online Resources

* Unity Official Documentation
* Unity Learn Platform
* GitHub Unity repositories
* YouTube Unity tutorials

---

# GitHub Link 🔗

https://github.com/Arnav-1706/3DRunner

---

# Conclusion ✅

This project successfully demonstrates the creation of a 3D endless runner racing game using Unity and C#.
The game includes AI opponents, collision systems, particle effects, animations, UI systems, sound effects, and smooth player controls.

The project also improved debugging, problem-solving, and practical Unity game development skills.

---

Made with ❤️ using Unity
