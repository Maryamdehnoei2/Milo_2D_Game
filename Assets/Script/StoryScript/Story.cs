using System;
using System.Collections;
using Unity.VisualScripting;
using UnityEngine;

public class Story : MonoBehaviour
{
    [SerializeField] private GameObject storyPanel;
    [SerializeField] private GameObject[] story;
    [SerializeField] private GameObject nextButton;

    [SerializeField] private GameObject trainingPanel;
    [SerializeField] private UIPanel uIPanel;
    void Start()
    {
        Time.timeScale = 0;
        StartCoroutine(ShowStory());
    }

    void Update()
    {
    }


    IEnumerator ShowStory()
    {
        yield return new WaitForSecondsRealtime(2f);

        for (int i = 0; i < story.Length; i++)
        {
            CanvasGroup canvasGroup = story[i].GetComponent<CanvasGroup>();
            story[i].SetActive(true);
            for (float alpha = 0; alpha <= 1; alpha += Time.unscaledDeltaTime)
            {
                canvasGroup.alpha = alpha;
                yield return null;
            }
            canvasGroup.alpha = 1;

            yield return new WaitForSecondsRealtime(3f);
        }
        nextButton.SetActive(true);
    }

    public void NextStory()

    {
        storyPanel.SetActive(false);
        trainingPanel.SetActive(true);
    }
    public void NextTraining()

    {
        trainingPanel.SetActive(false);
        uIPanel.ActivePanel();
        Time.timeScale = 1;
    }
}