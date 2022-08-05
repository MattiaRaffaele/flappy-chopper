using UnityEngine;

public class tubeTrigger : MonoBehaviour {
    
    public GameObject gameManager;
    private void OnTriggerEnter2D(Collider2D other) {
        gameManager.GetComponent<gameManager>().isDead = true;
    }
}