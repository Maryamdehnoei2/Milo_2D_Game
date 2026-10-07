using UnityEngine;

public class Hook : MonoBehaviour
{

    [SerializeField] private GameObject gameoverPanel;
    [SerializeField] private GameObject heartPanel;
    [SerializeField] private GameObject pearlPanel;
    [SerializeField] private GameObject diamondPanel;
    [SerializeField] private ShieldCollision shieldCollision;
    void Start()
    {
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player") && !shieldCollision.IsShieldActive)
        {
            Time.timeScale = 0;
            gameoverPanel.SetActive(true);
            heartPanel.SetActive(false);
            pearlPanel.SetActive(false);
            diamondPanel.SetActive(false);
        }
    }
}
