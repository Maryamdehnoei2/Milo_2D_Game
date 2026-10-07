using System.Collections;
using Unity.VisualScripting;
using UnityEngine;

public class Bubble : MonoBehaviour
{
    [SerializeField] private ShieldCollision shieldCollision;
    [SerializeField] private GameObject bubble;
    private bool isActive = true;
    [SerializeField] private SpriteRenderer fish;
    void Start()
    {
    }

    void Update()
    {
        Active();
    }


    private void Active()
    {
        if (shieldCollision.IsShieldActive && isActive)
        {
            bubble.SetActive(true);
        }
        else
        {
            bubble.SetActive(false);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Shark") ||
            collision.gameObject.CompareTag("Jellyfish") ||
            collision.gameObject.CompareTag("Hook"))
        {
            isActive = false;
            bubble.SetActive(false);
            StartCoroutine(BlinkFish());
        }
    }



    IEnumerator BlinkFish()
    {
        for (int i = 0; i < 10; i++)
        {
            fish.enabled = false;
            yield return new WaitForSeconds(0.2f);

            fish.enabled = true;
            yield return new WaitForSeconds(0.2f);
        }
    }
}
