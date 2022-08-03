using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tubeManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position = new Vector2 (-5f , 0f * Time.deltaTime);

        if (gameObject.transform.position.x <= 5f){
            Destroy(gameObject);
        }
    }
}