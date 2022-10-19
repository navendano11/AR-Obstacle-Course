using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuController : MonoBehaviour
{
    public GameObject loadingScreen;
    public Slider slider;

    public void StartBtn(int sceneIndex)
    {
       StartCoroutine(LoadAsynchronously(sceneIndex));
    }

    IEnumerator LoadAsynchronously (int sceneIndex)
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneIndex);
        loadingScreen.SetActive(true);
        while (operation.isDone == false)
        {
            // Debug.Log(operation.progress);
            slider.value = operation.progress;

            yield return  null;
        }
        // float loadProgress = loadingOperation.progress;
    }

    // public void StartBtn(int sceneIndex)
    // {
    //    StartCoroutine(LoadAsynchronously(sceneIndex));
    // }
}
