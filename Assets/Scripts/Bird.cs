using UnityEngine;

// INHERITANCE
public class Bird : Animal
{
    // POLYMORPHISM
    protected override void Speak()
    {
        Debug.Log($"{AnimalName} says: Tweet! Tweet!");
    }

    // POLYMORPHISM
    protected override void Move()
    {
        Debug.Log($"{AnimalName} floats upward!");
        
        // Moves the sphere up, but slower than the dog
        transform.Translate(Vector3.up * 0.2f);
    }
}