using Unity.VisualScripting;
using UnityEngine;

public class SharkCollision : MonoBehaviour
{
    [SerializeField] private GameObject gameoverPanel;
    [SerializeField] private GameObject heartPanel;
    [SerializeField] private GameObject pearlPanel;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Shark"))
        {
            Time.timeScale = 0;
            gameoverPanel.SetActive(true);
            heartPanel.SetActive(false);
            pearlPanel.SetActive(false);
        }
    }
}
