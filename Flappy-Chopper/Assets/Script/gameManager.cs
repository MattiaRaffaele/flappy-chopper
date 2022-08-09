using UnityEngine;
using UnityEngine.SceneManagement;
public class gameManager : MonoBehaviour
{

    public GameObject tubi;

    public GameObject Player;

    public GameObject gameoverText;

    public GameObject animator;

    public GameObject gameoverUI;

    public GameObject scoreText;

    [Header("Audio")]
    public AudioSource gameoverAudio;

    Animator anim;
    Animator scoreAnim;



    bool canExecute;

    private void Awake() {
        anim = animator.GetComponent<Animator>();
        gameoverUI.SetActive(false);
        scoreAnim = scoreText.GetComponent<Animator>();
    }

    

    public void GameOver(){

        anim.Play("gameoverAnim");

        scoreAnim.Play("scoreAnimation");

        gameoverAudio.Play();

        gameoverUI.SetActive(true);

        tubi.GetComponent<tubeManager>().enabled = false;

        Destroy(Player);
    }

    public void Replay(){

        SceneManager.LoadScene(1);

    }

    public void mainMenu(){
        SceneManager.LoadScene(0);
    }
}
