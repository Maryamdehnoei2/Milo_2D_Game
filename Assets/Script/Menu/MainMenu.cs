using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private GameObject settingPanel;

    void Start()
    {

    }

    void Update()
    {

    }

    public void PlayGame()
    {
        SceneManager.LoadScene("GameScene"); 
    }

    public void ShowSettingPanel()
    {
        settingPanel.SetActive(true);
    }

    public void ExitButton()
    {

    }
}
