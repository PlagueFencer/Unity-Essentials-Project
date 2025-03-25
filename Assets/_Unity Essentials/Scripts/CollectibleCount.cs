using UnityEngine;
using TMPro;

public class CollectibleCount : MonoBehaviour
{
    private TextMeshProUGUI collectibleText; // Reference to the TextMeshProUGUI component

    void Start()
    {
        collectibleText = GetComponent<TextMeshProUGUI>();
        if (collectibleText == null)
        {
            Debug.LogError("UpdateCollectibleCount script requires a TextMeshProUGUI component on the same GameObject.");
            return;
        }
        
        UpdateCollectibleDisplay(); // Initial update on start
    }

    public void UpdateCollectibleDisplay()
    {
        // Find all active objects of type Collectible (assuming Collectible is a MonoBehaviour)
        int totalCollectibles = FindObjectsOfType<Collectible>().Length;

        // Update the UI text
        collectibleText.text = $"Collectibles remaining: {totalCollectibles}";
    }
}
