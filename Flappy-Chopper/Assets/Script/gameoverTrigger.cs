using UnityEngine;

public class gameoverTrigger : MonoBehaviour {
    
    public GameObject gameManager;
    private void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.tag == "Tubi"){
                gameManager.GetComponent<gameManager>().GameOver();
        }  
    }
}