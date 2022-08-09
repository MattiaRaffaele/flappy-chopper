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

    public GameObject abilityManager;


    [Header("Audio")]
    public AudioSource gameoverAudio;

    Animator anim;
    Animator scoreAnim;


    public static bool isDead;
    bool canExecute;

    private void Awake() 
    {
        isDead = false;
        anim = animator.GetComponent<Animator>();
        gameoverUI.SetActive(false);
        scoreAnim = scoreText.GetComponent<Animator>();
    }
    

    

    public void GameOver(){

        isDead = true;

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
