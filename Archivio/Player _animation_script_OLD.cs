//Mattia Raffaele
//01 08 2022
//Lunedì
//Animazione birdy 3 frame
//Sostituito con rotazione flappye




using UnityEngine;
using System.Collections;


public class playerScript : MonoBehaviour
{
    Rigidbody2D rb;


    public float rbVerticalVelocity;

    [SerializeField] SpriteRenderer spriteRenderer;
 

    public Sprite[] sprite;

    private bool canJump;
 


    void Start()
    {
        canJump = true;

        //dichiarazioni
        rb = GetComponent<Rigidbody2D>();
    }


    private void Update()
    {

        if (canJump && Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space) || Input.touchCount > 0)
        {
            //sprite [0] = idle version
            //sprite [1] = jumping version
            //sprite [2] = afterjump version

            Debug.Log("jumpPhase started");


            
            //rb jump
            rb.velocity = new Vector2(0f, rbVerticalVelocity);

            spriteRenderer.sprite = sprite[1];

            //Debug
            Debug.Log("Sprite changes IENumerator running");

            //IE starts
            animationDeelay();

            
            spriteRenderer.sprite = sprite[2];

            afterjump();
        }
    }

    IEnumerator animationDeelay(){
        yield return new WaitForSeconds(100);
    }

    private void afterjump(){
        spriteRenderer.sprite = sprite[0];
        canJump = true;
        Debug.Log("jumpPhase ended");
    }
}