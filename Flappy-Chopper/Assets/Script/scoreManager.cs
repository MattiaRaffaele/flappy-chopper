using TMPro;
using UnityEngine;

public class scoreManager : MonoBehaviour
{
    public TMP_Text scoreText;
    int score;
    public int scoreState;


    private void Awake() {
        scoreState = 1;
    }
    private void Update() {
        scoreText.text = score.ToString();
    }

    private void OnTriggerEnter2D(Collider2D other) {
        score += scoreState;
    }
}
