using Unity.VisualScripting;
using UnityEngine;

public class UIPanel : MonoBehaviour
{
    [SerializeField] private GameObject heartPanel;
    [SerializeField] private GameObject pearlPanel;
    [SerializeField] private GameObject diamondPanel;
    void Start()
    {
        
    }

    void Update()
    {
        
    }
    public void ActivePanel()
    {
        heartPanel.SetActive(true);
        pearlPanel.SetActive(true);
        diamondPanel.SetActive(true);
    }
    public void InactivePanel()
    {
        heartPanel.SetActive(false);
        pearlPanel.SetActive(false);
        diamondPanel.SetActive(false);
    }
}
