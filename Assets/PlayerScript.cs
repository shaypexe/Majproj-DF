using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayerScript : MonoBehaviour
{
    //the boundary of the player
    public Rigidbody2D rb;
    //controls the speed/velocity you can move your player
    public float speed = 5000f;   
    //identifies a player as seperate from another
    public int playerNum = 1; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if your player number is 1 this code is applied to you
        if (playerNum == 1)
        {
            //this code is adding in the controls to move the play as well as mentioning the speed so it all matches the same speed
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
        }//if your player number isnt 1 this code is applied to you 
        else
        {



            //this code is adding in the controls to move the play as well as mentioning the speed so it all matches the same speed
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
