# Interactive Zoo: Programming Theory in Action

## Overview
This project is a 3D interactive prototype built in Unity to demonstrate mastery of the four pillars of Object-Oriented Programming (OOP). Developed as the final capstone for the Unity Junior Programmer Pathway, this application features clickable 3D primitive animals that each possess unique behaviors and dialogue, all driven by a clean, scalable class hierarchy.

## The Four Pillars of OOP Demonstrated

This project serves as a practical application of core software architecture principles:

* **1. Encapsulation (Protecting Data):** The base `Animal` class features a private backing field (`m_AnimalName`) with a public property (`AnimalName`). The property's setter includes validation logic to ensure the string cannot be left empty or exceed 10 characters, protecting the UI from breaking.
  
* **2. Inheritance (Sharing DNA):** The project utilizes a base parent class (`Animal.cs`) that handles universal logic like mouse-click detection and UI communication. Three child classes (`Dog.cs`, `Bird.cs`, and `Fish.cs`) inherit from this base class, gaining all its functionality without needing to rewrite duplicate code.

* **3. Polymorphism (Many Forms):** The base class contains `virtual` methods for `Speak()` and `Move()`. Each child class uses the `override` keyword to alter these behaviors. When clicked, the game doesn't need to check what animal it is; it simply fires the command, and the Dog jumps, the Bird floats, and the Fish spins.

* **4. Abstraction (Hiding Complexity):** The complex logic of updating the UI text, triggering animations, and logging console messages is hidden behind a single, high-level `Interact()` method. When the player clicks an object, `OnMouseDown()` simply calls `Interact()`, keeping the interface incredibly simple.

## Key Features
* **Dynamic UI Speech Bubble:** Utilizes TextMeshPro to push localized dialogue from the scripts directly to a canvas UI, making the application fully playable in a WebGL browser environment.
* **Custom Aesthetics:** Features custom Albedo materials to distinguish the 3D primitives and a localized 3D Quad background to enhance the visual presentation.
* **Input System Compatibility:** Configured to support both Legacy and New Input Systems to ensure reliable Raycast clicking across different Unity builds.

## How to Play
1. Launch the application in the browser or Unity Editor.
2. Left-click on any of the three animals (the brown cube, blue sphere, or orange capsule).
3. Watch as they perform their unique physical actions and display their custom dialogue in the speech bubble at the top of the screen!

## Author
* **Sushant**
