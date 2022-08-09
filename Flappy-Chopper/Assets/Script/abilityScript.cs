using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class abilityScript : MonoBehaviour
{

    int spawnerNum;
    
    
    void Update()
    {
        if (gameObject.transform.position.x <= -10f)
        {
            abilitySpawner();
        }
    }

    void abilitySpawner(){
        spawnerNum = Random.Range(1,10);
        Debug.Log(spawnerNum);
        if (spawnerNum == 5){
            gameObject.transform.position = new Vector2 (Random.Range(8f, 16f), Random.Range(5f, -5f));
        }
    }

    
}
