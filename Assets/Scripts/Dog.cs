using UnityEngine;

// // INHERITANCE
public class Dog : Animal
{
    // // POLYMORPHISM
    protected override void Speak()
    {
        DisplayText($"{AnimalName} jumps excitedly and says: Woof! Woof!");
    }

    protected override void Move()
    {
        transform.Translate(Vector3.up * 0.5f); 
    }
}