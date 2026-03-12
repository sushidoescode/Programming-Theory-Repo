using UnityEngine;

// INHERITANCE: Dog derives from the Animal class
public class Dog : Animal
{
    // POLYMORPHISM: We override the generic animal noise with a bark
    protected override void Speak()
    {
        Debug.Log($"{AnimalName} says: Woof! Woof!");
    }

    // POLYMORPHISM: We override the generic wiggle with a jump
    protected override void Move()
    {
        Debug.Log($"{AnimalName} jumps excitedly!");
        
        // Moves the cube up on the Y axis slightly every time you click!
        transform.Translate(Vector3.up * 0.5f); 
    }
}