using UnityEngine;

public class tubeManager : MonoBehaviour
{
    public GameObject floor;
    private int spawnerNum;
    public GameObject Ability;
    public float Speed;
    int spawnRandom;

    [Header("Funzioni di debug")]
    public bool Testing;
    private int spawnNum2;

    bool canSpawn;



    private void Awake() {
        //Dichiarazioni
        canSpawn = Ability.GetComponent<abilityTrigger>().canSpawn = true;

        Ability.SetActive(false);

        //Funzioni di debug aggiuntive per i test
        if (Testing){
            spawnNum2 = 1;
        }

        else{
            spawnNum2 = 10;
        }
    }

    void Update()
    {
        gameObject.transform.Translate (new Vector2 (-1f, 0f) * Speed * Time.deltaTime);
        //ab.transform.Translate (new Vector2 (-1f, 0f) * Speed * Time.deltaTime);

        if (gameObject.transform.position.x <= -8f){
            spawnRandom = Random.Range(1, spawnNum2);
            Debug.Log(spawnRandom);
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



        //abilityManager

        
        

        if (spawnRandom == 1 && canSpawn){
            Ability.SetActive(true);
        }
        else{
            Ability.SetActive(false);
        }
    }
}
