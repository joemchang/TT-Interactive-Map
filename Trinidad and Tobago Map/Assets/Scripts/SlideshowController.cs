using UnityEngine;
using UnityEngine.UI;

public class SlideshowController : MonoBehaviour
{
    [Header("UI References")]
    public RawImage displayImage;
    
    [Header("Slideshow Settings")]
    public Texture2D[] slides; // Drop your images here in the Inspector
    
    private int currentIndex = 0;

    void Start()
    {
        UpdateSlideshow();
    }

    // Call this from your "Next" button's OnClick() event
    public void NextSlide()
    {
        if (slides.Length == 0) return;
        
        currentIndex = (currentIndex + 1) % slides.Length;
        UpdateSlideshow();
    }

    // Call this from your "Previous" button's OnClick() event
    public void PreviousSlide()
    {
        if (slides.Length == 0) return;
        
        currentIndex--;
        if (currentIndex < 0)
        {
            currentIndex = slides.Length - 1;
        }
        UpdateSlideshow();
    }

    private void UpdateSlideshow()
    {
        if (slides.Length > 0 && displayImage != null)
        {
            displayImage.texture = slides[currentIndex];
        }
    }
}