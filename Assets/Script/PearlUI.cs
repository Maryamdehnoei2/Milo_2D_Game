using TMPro;
using UnityEngine;

public class PearlUI : MonoBehaviour
{
    [SerializeField] private TMP_Text pearlText;
    [SerializeField] private PearlManager pearlManager;
    void Start()
    {
        
    }

    void Update()
    {
        pearlText.text=pearlManager.Pearl.ToString();
    }
}
