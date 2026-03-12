Project Brief: The Interactive Zoo

1. Inheritance (Choose your objects):

Base Class: Animal (This will hold the universal data and behaviors).

Child Classes: Dog, Bird, and Fish (These will inherit from Animal).

Visuals: We will use primitive shapes in Unity. A Cube for the Dog, a Sphere for the Bird, and a Capsule for the Fish.

2. Polymorphism (Choose your behaviors):

All animals will have a Move() and Speak() behavior.

Dog: Overrides Move() to jump up and down. Overrides Speak() to print "Woof!" to the UI.

Bird: Overrides Move() to float upward. Overrides Speak() to print "Tweet!"

Fish: Overrides Move() to spin around. Overrides Speak() to print "Blub..."

3. Encapsulation (Choose your data):

Every animal needs a name, but we want to protect the data.

We will create a private variable m_AnimalName and a public property AnimalName.

The setter will include a rule: If the string is blank or longer than 10 characters, default it to "Unknown" and throw a warning. This prevents the UI from breaking with massive text strings.

4. Abstraction (Choose your functions):

We will create a high-level public method called Interact().

When the player clicks an animal, the mouse click just calls Interact().

The player/UI doesn't need to know how the animal moves or speaks. Interact() handles the complex sequence of calculating physics, triggering particle effects (optional), and calling the internal Move() and Speak() methods.
