using System.Collections;
using UnityEngine;

public class ShieldCollision : MonoBehaviour
{
    public bool IsShieldActive;
    void Start()
    {

    }

    void Update()
    {

    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            IsShieldActive = true;
            Destroy(gameObject);
            StartCoroutine(DisableShield());
        }
    }

    IEnumerator DisableShield()
    {
        yield return new WaitForSeconds(5f);
        IsShieldActive = false;
    }
}
