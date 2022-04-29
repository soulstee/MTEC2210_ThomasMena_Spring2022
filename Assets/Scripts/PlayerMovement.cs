using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{

    public float speed = 5.0f;
    public GameManager gameManager;

    // Update is called once per frame
    void Update()
    {
        float xMove = Input.GetAxisRaw("Horizontal");
        float yMove = Input.GetAxisRaw("Vertical");

        float xMovement = xMove * speed * Time.deltaTime;
        float yMovement = yMove * speed * Time.deltaTime;

        transform.Translate(xMovement, yMovement, 0);

        //transform.position = new Vector3(transform.position.x + xMovement, transform.position.y + yMovement, transform.position.z);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //if (collision.tag == "Car")
        {

            //Destroy(collision.gameObject);
            //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            //Debug.Log("Game Over");

       //}
   }
}
