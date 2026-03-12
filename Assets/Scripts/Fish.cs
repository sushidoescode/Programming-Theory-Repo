using UnityEngine;

// // INHERITANCE
public class Fish : Animal
{
    // // POLYMORPHISM
    protected override void Speak()
    {
        DisplayText($"{AnimalName} spins around and says: Blub... blub...");
    }

    protected override void Move()
    {
        transform.Rotate(0, 45f, 0); 
    }
}