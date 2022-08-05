using UnityEngine;

public class gameManager : MonoBehaviour
{
    public GameObject Tubi;

    
    void Update()
    {
        if (gameObject.transform.position.x <= -5f){
            
            Vector2 spawnPos = new Vector2 (5f, Random.Range(-1f, 2f));
            Instantiate(Tubi, spawnPos, Quaternion.identity);

            gameObject.transform.position = new Vector2 (5f, 0f);
            
        }

        float tubeSpeed = tubeManager.tubeSpeed;
        gameObject.transform.Translate (new Vector2 (tubeSpeed , 0f) * Time.deltaTime);
    }  
}
