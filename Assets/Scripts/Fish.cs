using UnityEngine;

// INHERITANCE
public class Fish : Animal
{
    // POLYMORPHISM
    protected override void Speak()
    {
        Debug.Log($"{AnimalName} says: Blub... blub...");
    }

    // POLYMORPHISM
    protected override void Move()
    {
        Debug.Log($"{AnimalName} spins around!");
        
        // Rotates the capsule 45 degrees on its Y axis every click
        transform.Rotate(0, 45f, 0); 
    }
}