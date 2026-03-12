using UnityEngine;

public class Animal : MonoBehaviour
{
    // --- ENCAPSULATION ---
    // The data is private, protected from outside interference
    [SerializeField] private string m_AnimalName = "Unknown";
    
    // The public property controls HOW other scripts get or set the name
    public string AnimalName
    {
        get { return m_AnimalName; }
        set
        {
            if (string.IsNullOrEmpty(value) || value.Length > 10)
            {
                Debug.LogWarning("Name is invalid or too long! Defaulting to 'Unknown'.");
                m_AnimalName = "Unknown";
            }
            else
            {
                m_AnimalName = value;
            }
        }
    }

    // --- ABSTRACTION ---
    // The player just clicks the object and calls this one simple method.
    // They don't need to know the complex steps happening inside.
    private void OnMouseDown()
    {
        Interact();
    }

    public void Interact()
    {
        // 1. Log the interaction
        Debug.Log($"You interacted with {AnimalName}.");
        
        // 2. Call the internal behaviors
        Speak();
        Move();
    }

    // --- POLYMORPHISM (Prep) ---
    // 'virtual' means: "This is the default action, but my children can override it!"
    protected virtual void Speak()
    {
        Debug.Log("The animal makes a generic noise.");
    }

    protected virtual void Move()
    {
        Debug.Log("The animal wiggles slightly.");
    }
}