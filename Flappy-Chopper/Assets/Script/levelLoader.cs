using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class levelLoader : MonoBehaviour
{
    public Slider slider;
    

    public void Start()
    {
        StartCoroutine(bobo());
    }

    public IEnumerator bobo()
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(2);

        while (!operation.isDone)
        {

            float progress = Mathf.Clamp01(operation.progress / .9f);
            slider.value = progress;

            yield return null;

            //Testi
            for (; ; )
            {
                yield return new WaitForSeconds(1);
            }
        }
    }
}
