using Unity.VisualScripting;
using UnityEngine;

public class SharkCollision : MonoBehaviour
{
    [SerializeField] private GameObject gameoverPanel;
    
    [SerializeField] private ShieldCollision shieldCollision;
    [SerializeField] private UIPanel uIPanel;
    void Start()
    {
    }

    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Shark") && !shieldCollision.IsShieldActive)
        {
            Time.timeScale = 0;
            gameoverPanel.SetActive(true);
            uIPanel.InactivePanel();
        }
    }
}
