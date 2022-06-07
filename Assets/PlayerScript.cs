using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayerScript : MonoBehaviour
{
    //
    public Rigidbody2D rb;
    //
    public float speed = 5000f;   
    //
    public int playerNum = 1; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //
        if (playerNum == 1)
        {
            //
            if (Input.GetKey(KeyCode.UpArrow))
            {
                rb.AddForce(Vector2.up * Time.deltaTime * speed);
               
            }
            if (Input.GetKey(KeyCode.DownArrow))
            {
                rb.AddForce(Vector2.down * Time.deltaTime * speed);
            }
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                rb.AddForce(Vector2.left * Time.deltaTime * speed);
            }
            if (Input.GetKey(KeyCode.RightArrow))
            {
                rb.AddForce(Vector2.right * Time.deltaTime * speed);
            }
        }//
        else
        {



            //
            if (Input.GetKey(KeyCode.W))
            {
                rb.AddForce(Vector2.up * Time.deltaTime * speed);
               
            }
            if (Input.GetKey(KeyCode.S))
            {
                rb.AddForce(Vector2.down * Time.deltaTime * speed);
            }
            if (Input.GetKey(KeyCode.A))
            {
                rb.AddForce(Vector2.left * Time.deltaTime * speed);
            }
            if (Input.GetKey(KeyCode.D))
            {
                rb.AddForce(Vector2.right * Time.deltaTime * speed);
            }

        }
















    }
}
