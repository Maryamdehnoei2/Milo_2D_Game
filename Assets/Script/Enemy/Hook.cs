using System;
using UnityEngine;

public class Hook : MonoBehaviour
{

    [SerializeField] private GameObject gameoverPanel;
    [SerializeField] private GameObject heartPanel;
    [SerializeField] private GameObject pearlPanel;
    [SerializeField] private GameObject diamondPanel;
    [SerializeField] private ShieldCollision shieldCollision;
    [SerializeField] private PlayerMovement playerMovement;
    [SerializeField] private Rigidbody2D rigidbodyPlayer;
    void Start()
    {
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player") && !shieldCollision.IsShieldActive)
        {
           
            playerMovement.enabled = false;
            rigidbodyPlayer.linearVelocity = Vector2.zero;
            rigidbodyPlayer.gravityScale = 0;
            collision.transform.SetParent(transform);
            Invoke(nameof(Gameover), 2f);
        }
    }
    private void Gameover()
    {
        Time.timeScale = 0;
        gameoverPanel.SetActive(true);
        heartPanel.SetActive(false);
        pearlPanel.SetActive(false);
        diamondPanel.SetActive(false);
    }
}

