using Unity.VisualScripting;
using UnityEngine;

public class SettingPanel : MonoBehaviour
{
    [SerializeField] private GameObject settingPanel;
    void Start()
    {

    }

    void Update()
    {

    }

    public void BackButton()

    {
        settingPanel.SetActive(false);
    }
}
