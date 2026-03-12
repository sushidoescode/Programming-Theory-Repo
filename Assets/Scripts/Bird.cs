using UnityEngine;

// // INHERITANCE
public class Bird : Animal
{
    // // POLYMORPHISM
    protected override void Speak()
    {
        DisplayText($"{AnimalName} floats upward and says: Tweet! Tweet!");
    }

    protected override void Move()
    {
        transform.Translate(Vector3.up * 0.2f);
    }
}