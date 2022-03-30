using System.Collections;
using System.Collections. Generic;
using UnityEngine;


public class CarMovement : MonoBehaviour
{
 
    public float speed = 5;
 


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float xMove = Input.GetAxisRaw("Horizontal"); 
        float yMove = Input.GetAxisRaw("Vertical");

        float xMovement = xMove * speed * Time.deltaTime;
        float yMovement = yMove * speed * Time.deltaTime;

        transform.position += Vector3.right * Time.deltaTime;
    }
}