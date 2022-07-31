using UnityEngine;

public class playerScript : MonoBehaviour
{
    Rigidbody2D rb;


    public float rbVerticalVelocity;

    public SpriteRenderer spriteRenderer;
    public Sprite frame1;
    public Sprite frame2;
    public Sprite frame3;

    private bool canJump;
 


    void Start()
    {
        canJump = true;
        rb = GetComponent<Rigidbody2D>();
    }


    private void Update()
    {
        Debug.Log("Jumpstate" + canJump);

        if (Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space) || Input.touchCount > 0 && canJump)
        {
            canJump = false;

            
            rb.velocity = new Vector2(0f, rbVerticalVelocity);
            
            canJump = true;
        }
    }
}