using UnityEngine;

public class PearlManager : MonoBehaviour
{
    public int Pearl;
    void Start()
    {
        Pearl = PlayerPrefs.GetInt("Pearl", 0);
    }

    void Update()
    {
        
    }

    public void AddPearl()
    {
        Pearl++;
        PlayerPrefs.SetInt("Pearl", Pearl);
        PlayerPrefs.Save();
    }
}
