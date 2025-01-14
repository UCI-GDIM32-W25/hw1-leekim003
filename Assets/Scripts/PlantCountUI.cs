using UnityEngine;
using TMPro;

public class PlantCountUI : MonoBehaviour
{
    [SerializeField] private TMP_Text _plantedText;
    [SerializeField] private TMP_Text _remainingText;

    public void UpdateSeeds (int seedsLeft, int seedsPlanted)
    {
         if (_remainingText != null)
        {
            _remainingText.text = "Seeds Left: " + seedsLeft;
        }

        if (_plantedText != null)
        {
            _plantedText.text = "Seeds Planted: " + seedsPlanted;
        }
    
    }
}