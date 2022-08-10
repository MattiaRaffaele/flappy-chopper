using UnityEngine;
using System.Collections;
using TMPro;


public class abilityTrigger : MonoBehaviour
{

    public bool testing;
    public int abilitàMassime;

    [Header("Per abilità")]
    public GameObject scoreManager;
    public GameObject Tubo;
    public GameObject player;
    public bool canSpawn = true;

    Animator abAnim;
    public GameObject abilityTextGroup;
    public GameObject abilityText;



    private void Start() {
        abAnim = abilityTextGroup.GetComponent<Animator>();
        abilityText.SetActive(false);
    }


    private void OnTriggerEnter2D(Collider2D other) {

        Debug.Log("Preso");

        if (other.gameObject.tag == "Player"){
            
            gameObject.transform.localScale = transform.localScale -= new Vector3 (0.5f, 0.5f, 0f);
            puntiDoppiAB();
        }
    }


    public void puntiDoppiAB(){
        abAnim.Play("abAnimation");
        scoreManager.GetComponent<scoreManager>().scoreState = 2;
    }
}