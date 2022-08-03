using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameManager : MonoBehaviour
{
    float spawntimer;
    float spawnRate;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        spawntimer += Time.deltaTime;
        if (spawntimer >= spawnRate){
            spawntimer -= spawnRate;
            Vector2 spawnPos = new Vector2 (2f, Random.Range(-1f, 2f));
            Instantiate(Tubi, spawnPos, Quaternion.identity);
        }

    }
}
