using TMPro;
using UnityEngine;

public class scoreManager : MonoBehaviour
{
    public TMP_Text scoreText;
    int score;

    private void Update() {
        scoreText.text = score.ToString();
    }

    private void OnTriggerEnter2D(Collider2D other) {
        score ++;
    }
}
