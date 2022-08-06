using UnityEngine;

public class gameoverTrigger : MonoBehaviour {
    
    public GameObject gameManager;
    private void OnTriggerEnter2D(Collider2D other) {
        gameManager.GetComponent<gameManager>().GameOver();
    }
}