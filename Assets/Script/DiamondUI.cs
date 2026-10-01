using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class DiamondUI : MonoBehaviour
{
    [SerializeField] private TMP_Text diamondText;
    [SerializeField] private DiamondManager diamondManager;
    void Start()
    {
        
    }

    void Update()
    {
        diamondText.text = diamondManager.Diamond.ToString();
    }
}
