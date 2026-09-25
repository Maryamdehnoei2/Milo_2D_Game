using UnityEngine;
using UnityEngine.SceneManagement;

public class PanelButton : MonoBehaviour
{
    void Start()
    {

    }

    void Update()
    {

    }

    public void Replay()
    {
        SceneManager.LoadScene("GameScene");
    }

    public void Menu()

    {
        SceneManager.LoadScene("MenuScene");
    }
    public void NextLevel()
    {
        SceneManager.LoadScene("");
    }
}
