using Unity.VisualScripting;
using UnityEngine;

public class Effect : MonoBehaviour
{

    [SerializeField] private AudioSource gameOverSound;
    [SerializeField] private AudioSource winSound;
    void Start()
    {
        bool effectOn = PlayerPrefs.GetInt("Effect", 1) == 1;
        if(gameOverSound != null)
        {
            gameOverSound.mute = !effectOn;
        }
        if (winSound != null)
        {
            winSound.mute = !effectOn;
        }
    }

    void Update()
    {

    }

    public void ToggleEffect()
    {
        bool state = PlayerPrefs.GetInt("Effect",1) == 1;
        bool newState = !state;
        PlayerPrefs.SetInt("Effect", newState ? 1 : 0);
        PlayerPrefs.Save();

        if(gameOverSound!=null)
        {
            gameOverSound.mute = !newState;
        }
        if(winSound!=null)
        {
            winSound.mute = !newState;
        }
    }
}
