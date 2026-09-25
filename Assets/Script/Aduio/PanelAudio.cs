using Unity.VisualScripting;
using UnityEngine;

public class PanelAudio : MonoBehaviour
{

    private AudioSource audioSource;


    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnEnable()
    {
        audioSource.Play();
    }
}
