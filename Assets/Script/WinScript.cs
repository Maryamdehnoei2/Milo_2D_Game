using Unity.VisualScripting;
using UnityEngine;

public class WinScript : MonoBehaviour
{
    [SerializeField] private GameObject winPanel;
   
    [SerializeField] private UIPanel uIPanel;
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            winPanel.SetActive(true);
            uIPanel.InactivePanel();
        }
    }
}
