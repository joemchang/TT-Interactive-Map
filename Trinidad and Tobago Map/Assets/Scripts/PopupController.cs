using UnityEngine;
using UnityEngine.UI;
using TMPro; // Uncomment if you are using TextMeshPro

public class PopupController : MonoBehaviour
{
    [Header("UI Panels")]
    public GameObject popupPanel;

    [Header("Optional Dynamic Text")]
    // If you use TextMeshPro, use this:
    public TextMeshProUGUI infoText; 
    
    // If you use standard Unity UI Text, use this instead:
    // public Text infoText;

    void Start()
    {
        // Ensure the panel is closed when the map loads
        if (popupPanel != null)
        {
            popupPanel.SetActive(false);
        }
    }

    // Call this when clicking the location pin on the map
    public void OpenPopup(string locationDescription)
    {
        if (popupPanel != null)
        {
            popupPanel.SetActive(true);
            
            if (infoText != null)
            {
                infoText.text = locationDescription;
            }
        }
    }

    // Call this from your "X" Close Button
    public void ClosePopup()
    {
        if (popupPanel != null)
        {
            popupPanel.SetActive(false);
        }
    }
}