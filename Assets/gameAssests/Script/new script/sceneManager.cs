using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class sceneManager : MonoBehaviour
{
    public GameObject sceneLoader;
    public Slider progressSlider;

   
    public IEnumerator LoadScene_Coroutine(int index)
    {
        progressSlider.value = 0;
        sceneLoader.SetActive(true);

        AsyncOperation async = SceneManager.LoadSceneAsync(index);
        async.allowSceneActivation = false;
        float progress = 0;

        while (!async.isDone)
        {
            progress = Mathf.MoveTowards(progress, async.progress, Time.deltaTime);
            progressSlider.value = progress;
            if (progress >= 0.9f)
            {
                progressSlider.value = 1;
                async.allowSceneActivation = true;

            }
            
            yield return null;
        }


    }
    public void loadScene(int x)
    {
        StartCoroutine(LoadScene_Coroutine(x));
    }
  
    public void quitNa()
    {
        Application.Quit();
        Debug.Log("quited");

    }



    //public void play()
    //{
    //    FindObjectOfType<AudioManager>().Play("Button");
    //}

    //public void Start()
    //{
    //    FindObjectOfType<AudioManager>().Play("bgMusic");
    //}
}
