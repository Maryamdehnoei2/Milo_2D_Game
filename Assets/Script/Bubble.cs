using Unity.VisualScripting;
using UnityEngine;

public class Bubble : MonoBehaviour
{
    [SerializeField] private ShieldCollision shieldCollision;
    [SerializeField] private GameObject bubble;
    void Start()
    {
    }

    void Update()
    {
        ActiveBubble();
    }

    void ActiveBubble()
    {
        if(shieldCollision.IsShieldActive)
        {
            bubble.SetActive(true);
        }
        else
        {
            bubble.SetActive(false);
        }
    }
}
