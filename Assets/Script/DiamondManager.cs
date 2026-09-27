using UnityEngine;

public class DiamondManager : MonoBehaviour
{
    public int Diamond;
    void Start()
    {
        Diamond = PlayerPrefs.GetInt("Diamond", 0);
    }

    void Update()
    {
        
    }
    public void AddDiamond()
    {
        Diamond++;
        PlayerPrefs.SetInt("Diamond", Diamond);
        PlayerPrefs.Save();
    }
}
