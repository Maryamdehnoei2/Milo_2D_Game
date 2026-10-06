using Unity.VisualScripting;
using UnityEngine;

public class SharkCollision : MonoBehaviour
{
    [SerializeField] private GameObject gameoverPanel;
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

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Shark") && !shieldCollision.IsShieldActive)
        {
            Time.timeScale = 0;
            gameoverPanel.SetActive(true);
            heartPanel.SetActive(false);
            pearlPanel.SetActive(false);
            diamondPanel.SetActive(false);
        }
    }
}
