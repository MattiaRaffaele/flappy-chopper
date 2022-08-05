using UnityEngine;

public class tubeManager : MonoBehaviour
{
    void Update()
    {
        gameObject.transform.Translate (new Vector2 (-5f, 0f) * Time.deltaTime);

        if (gameObject.transform.position.x <= -5f){
            Vector2 SpawnPos = new Vector2 (5f, Random.Range(-3f, 3f));
            gameObject.transform.position = SpawnPos;
            return;
        }
    }
}
