using UnityEngine;

public class tubeManager : MonoBehaviour
{
    public static float tubeSpeed;

    private void Awake() 
    {
        tubeSpeed = -5f;
    }
    void Update()
    {
        gameObject.transform.Translate (new Vector2 (tubeSpeed , 0f) * Time.deltaTime);

        if (gameObject.transform.position.x <= -10f) Destroy(gameObject);
    }
}