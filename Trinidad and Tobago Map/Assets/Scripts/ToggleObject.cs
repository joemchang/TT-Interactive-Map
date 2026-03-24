using UnityEngine;

public class ToggleObjectVisibility : MonoBehaviour
{
    // Reference to the GameObject you want to toggle
    public GameObject objectToToggle;

    // Public method that the button will call
    public void ToggleVisibility()
    {
        // Toggle the active state of the referenced GameObject
        if (objectToToggle != null)
        {
            objectToToggle.SetActive(!objectToToggle.activeInHierarchy);
        }
    }
}
