using UnityEngine;
using System.Collections;


public class abilityTrigger : MonoBehaviour
{

    public bool testing;
    public int abilitàMassime;

    [Header("Per abilità")]
    public GameObject scoreManager;


    private void OnTriggerEnter2D(Collider2D other) {
        
        if (other.gameObject.tag == "Player"){
            if (testing){

            }

            else{
                extractorVoid();
            }
        }
    }

    private void extractorVoid(){
        Random.Range(1, abilitàMassime);
    }

    private void puntiDoppiAB(){
        scoreManager.GetComponent<scoreManager>().scoreState = 2;
        endAB();
    }

    IEnumerator endAB(){
        yield return new WaitForSeconds(10);
    }
}