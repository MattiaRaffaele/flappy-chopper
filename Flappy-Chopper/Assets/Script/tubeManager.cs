using UnityEngine;

public class tubeManager : MonoBehaviour
{
    public GameObject floor;
    private int spawnerNum;
    public GameObject ab;
    public float Speed;

    void Update()
    {
        gameObject.transform.Translate (new Vector2 (-1f, 0f) * Speed * Time.deltaTime);
        ab.transform.Translate (new Vector2 (-1f, 0f) * Speed * Time.deltaTime);

        if (gameObject.transform.position.x <= -8f){
            
            Vector2 SpawnPos = new Vector2 (8f, Random.Range(-2.5f, 2.5f));//Dichiara la posizione di spawn dei tubi
            gameObject.transform.position = SpawnPos;
            return;
        }

        //extra
        floor.transform.Translate (new Vector2 (-5f, 0f) * Time.deltaTime);
        if (floor.transform.position.x <= -20f){
            floor.transform.position = new Vector2 (0f, 0f);
            return;
        }
    }
}
