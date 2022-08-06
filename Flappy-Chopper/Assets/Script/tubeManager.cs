using UnityEngine;

public class tubeManager : MonoBehaviour
{
    public GameObject floor;
    void Update()
    {
        gameObject.transform.Translate (new Vector2 (-5f, 0f) * Time.deltaTime);

        if (gameObject.transform.position.x <= -5f){
            Vector2 SpawnPos = new Vector2 (5f, Random.Range(-2.5f, 2.5f));
            gameObject.transform.position = SpawnPos;
            return;
        }

        //extra
        floor.transform.Translate (new Vector2 (-5f, 0f) * Time.deltaTime);
        if (floor.transform.position.x == -4.50f){
            floor.transform.position = new Vector2 (4.50f, 0f);
            return;
        }
    }
}
