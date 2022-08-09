using UnityEngine;


public class playerScript : MonoBehaviour
{
    Rigidbody2D rb;

    public float rbVerticalVelocity;

    private bool canJump;

    [Header("Audio")]
    public AudioSource jumpSound;
 


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
            //rb jump
            jumpSound.Play();

            rb.velocity = new Vector2(0f, rbVerticalVelocity);

            canJump = true;
        }
    }
}