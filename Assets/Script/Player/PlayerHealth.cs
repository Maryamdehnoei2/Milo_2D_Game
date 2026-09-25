using UnityEngine;

public class PlayerHealth : MonoBehaviour
{

    [SerializeField] private int health;
    [SerializeField] private GameObject gameoverPanel;
    [SerializeField] private GameObject[] heart;
    [SerializeField] private GameObject heartPanel;
    [SerializeField] private GameObject pearlPanel;
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void Damage()
    {
        health--;
        if(health>=0)
        {
            heart[health].SetActive(false);
        }
        if (health <= 0)
        {
            heartPanel.SetActive(false);
            pearlPanel.SetActive(false);
            gameoverPanel.SetActive(true);

        }
    }
}
