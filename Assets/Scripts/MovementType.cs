using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementType : MonoBehaviour
{
    public float speed;
    private Rigidbody2D rb;
    float xMove;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //float xMove = Inout.GetAxis("Horizontal");
        //float xMovement = xMove * speed *  Time.deltaTime;

        //transform.Translate(xMovement, 0, 0);
        //transform.position = new Vector3(transform.position.x + xMovement, transform.position.y, transform.position.z);
        
    }

    private void FixedUpdate()
    {
        float xMove = Input.GetAxis("Horizontal");
        float xMovement = xMove * speed * Time.deltaTime;

        //rb.AddForce(Vector2.right * xMovement);

        //rb.velocity = new Vector2(xMovement, 0);

        rb.MovePosition(transform.position + Vector3.right * xMovement);
    }
}
