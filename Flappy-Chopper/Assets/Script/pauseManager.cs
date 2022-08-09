using UnityEngine.SceneManagement;
using UnityEngine;

public class pauseManager : MonoBehaviour
{

    public void pauseButton(){
        Time.timeScale = 0;
    }
    public void resumeButton(){
        Time.timeScale = 1;
    }

    public void quitButton(){
        SceneManager.LoadScene(0);
    }
}
