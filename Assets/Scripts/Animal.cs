using UnityEngine;
using TMPro; 

public class Animal : MonoBehaviour
{
    // // ENCAPSULATION
    // Protecting the data so it can't be set to an invalid value
    [SerializeField] private string m_AnimalName = "Unknown";
    
    public string AnimalName
    {
        get { return m_AnimalName; }
        set
        {
            if (string.IsNullOrEmpty(value) || value.Length > 10)
            {
                m_AnimalName = "Unknown";
            }
            else
            {
                m_AnimalName = value;
            }
        }
    }

    private TextMeshProUGUI m_DialogText;

    private void Start()
    {
        // Automatically find our UI text on screen so we don't have to drag and drop!
        m_DialogText = GameObject.Find("DialogText").GetComponent<TextMeshProUGUI>();
    }

    private void OnMouseDown()
    {
        Interact();
    }

    // // ABSTRACTION
    // The player clicks, and this handles the rest without exposing the steps.
    public void Interact()
    {
        Speak();
        Move();
    }

    // // POLYMORPHISM 
    // Virtual methods allow child classes to override these behaviors
    protected virtual void Speak()
    {
        DisplayText("The animal makes a generic noise.");
    }

    protected virtual void Move()
    {
        // Default wiggle
    }

    // A helper method to push text to our UI bubble instead of the Console
    protected void DisplayText(string text)
    {
        if (m_DialogText != null)
        {
            m_DialogText.text = text;
        }
    }
}