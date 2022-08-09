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
            spawnerNum = Random.Range(0, 10);
            abilitySpawner();
        }
    }

    void abilitySpawner(){
        if (spawnerNum == 0){
            Debug.Log(spawnerNum);
            gameObject.transform.position = new Vector2 (5f, 0f);
        }
    }
}
