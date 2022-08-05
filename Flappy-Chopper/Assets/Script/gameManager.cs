using TMPro;
using UnityEngine;

public class gameManager : MonoBehaviour
{

    //public TMP_Text gameoverText;

    public bool isDead;

    public GameObject tubi;

    public GameObject Player;

    public TMP_Text gameoverText;


    private void Awake() {
        gameoverText.text = "";
    }
    
    private void Update() {
        if (isDead){
            GameOver();
        }
    }

    private void GameOver(){

        Debug.Log("GameOver initialized");
        gameoverText.text = "Game Over";

        tubi.GetComponent<tubeManager>().enabled = false;
        Debug.Log("Tubi disabled");

        Player.GetComponent<playerScript>().enabled = false;
        Debug.Log("Player disabled");

        Debug.Log("GameOver Successfully");
    }

}
