using UnityEngine;

public class playerScript : MonoBehaviour
{
    Rigidbody2D rb;


    public float rbVerticalVelocity;
 


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }




    private void Update()
    {
        if (Input.GetMouseButtonDown(0) || Input.touchCount > 0)
        {
            rb.velocity = new Vector2(0f, rbVerticalVelocity);
        }
    }
}