using UnityEngine;

public class WinScript : MonoBehaviour
{
    [SerializeField] private GameObject winPanel;
    [SerializeField] private GameObject heartPanel;
    [SerializeField] private GameObject pearlPanel;
    [SerializeField] private GameObject diamonPanel;

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
            heartPanel.SetActive(false);
            pearlPanel.SetActive(false);
            diamonPanel.SetActive(false);
        }
    }
}
