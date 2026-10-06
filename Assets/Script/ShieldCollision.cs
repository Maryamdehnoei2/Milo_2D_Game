using System.Collections;
using UnityEngine;

public class ShieldCollision : MonoBehaviour
{
    public bool IsShieldActive;
    private SpriteRenderer shield;
    void Start()
    {
        shield = GetComponent<SpriteRenderer>();
    }

    void Update()
    {

    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            IsShieldActive = true;
            StartCoroutine(DisableShield());
            shield.enabled = false;
        }
    }

    IEnumerator DisableShield()
    {
        yield return new WaitForSecondsRealtime(5f);
        IsShieldActive = false;
    }
}
