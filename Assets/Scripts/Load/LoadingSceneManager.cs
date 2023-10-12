using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class LoadingSceneManager : MonoBehaviour
{
    public static string nextScene;

    [SerializeField]Image progressBar;
    [SerializeField]TextMeshProUGUI progressText;

    private void Start()
    { 
        StartCoroutine(LoadScene());
    }

    public static void LoadScene(string sceneName)
    {
        nextScene = sceneName;
        SceneManager.LoadScene("LoadingScene");
    }

    IEnumerator LoadScene()
    {
        yield return null;

        AsyncOperation op = SceneManager.LoadSceneAsync(nextScene);
        op.allowSceneActivation = false;
        float timer = 0.0f;

        while (!op.isDone)
        {
            yield return null;

            timer += Time.deltaTime;

            if (op.progress < 0.90f) 
            {
                progressBar.fillAmount = Mathf.Lerp(progressBar.fillAmount, op.progress, timer);
                progressText.text = $"로딩중...{(int)(progressBar.fillAmount * 100)}%";

                if (progressBar.fillAmount >= op.progress) 
                {
                    timer = 0f; 
                } 
            }
            else if(timer > 1)
            {
                progressBar.fillAmount = Mathf.Lerp(progressBar.fillAmount, 1f, timer);
                progressText.text = $"로딩중...{(int)(progressBar.fillAmount * 100)}%";

                if (progressBar.fillAmount == 1.0f)
                {
                    op.allowSceneActivation = true;
                    yield break; 
                }
            }
            else
            {
                progressBar.fillAmount = 0.90f;
                progressText.text = "로딩중...90%";
            }
        }

    }

}