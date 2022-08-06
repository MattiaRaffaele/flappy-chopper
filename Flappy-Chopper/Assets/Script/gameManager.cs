using UnityEngine;
using UnityEngine.SceneManagement;
public class gameManager : MonoBehaviour
{

    public GameObject tubi;

    public GameObject Player;

    public GameObject gameoverText;

    public GameObject animator;

    public GameObject gameoverUI;

    Animator anim;

    private void Awake() {
        anim = animator.GetComponent<Animator>();
        gameoverUI.SetActive(false);
    }

    public void GameOver(){

        anim.Play("gameoverAnim");

        gameoverUI.SetActive(true);

        tubi.GetComponent<tubeManager>().enabled = false;

        Destroy(Player);
    }

    public void Replay(){

        SceneManager.LoadScene(0);

    }

}
