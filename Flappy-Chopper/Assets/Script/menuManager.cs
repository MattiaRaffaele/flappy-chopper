using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine;

public class menuManager : MonoBehaviour
{

    public void playButton(){
        SceneManager.LoadScene(1);
    }


    public void yesBtn(){
        Application.Quit();
    }
}
