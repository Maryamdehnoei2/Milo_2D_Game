using UnityEngine;

public class PlayerHealth : MonoBehaviour
{

    [SerializeField] private int health;
    [SerializeField] private GameObject gameoverPanel;
    [SerializeField] private GameObject[] heart;
    [SerializeField] private GameObject heartPanel;
    [SerializeField] private GameObject pearlPanel;
    [SerializeField] private GameObject diamondPanel;
    private ShieldCollision shieldCollision;
    
    void Start()
    {
        shieldCollision = GetComponent<ShieldCollision>();
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
                heartPanel.SetActive(false);
                pearlPanel.SetActive(false);
                diamondPanel.SetActive(false);
                gameoverPanel.SetActive(true);

            }
        }
        
    }
}
