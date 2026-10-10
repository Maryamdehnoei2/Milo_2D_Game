using Unity.VisualScripting;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{

    [SerializeField] private int health;
    [SerializeField] private GameObject gameoverPanel;
    [SerializeField] private GameObject[] heart;
    
    [SerializeField] private ShieldCollision shieldCollision;
    [SerializeField] private UIPanel uIPanel;
    
    void Start()
    {
    }

    void Update()
    {
        
    }

    public void Damage()
    {
        if(!shieldCollision.IsShieldActive)
        {
            health--;
            if (health >= 0)
            {
                heart[health].SetActive(false);
            }
            if (health <= 0)
            {
                uIPanel.InactivePanel();
                gameoverPanel.SetActive(true);

            }
        }
        
    }
}
