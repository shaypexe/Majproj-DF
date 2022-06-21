using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Game : MonoBehaviour
{   //these are gameobject variables
    public GameObject Player1;
    public GameObject Player2;
    //these are text variables
    public Text PlayerOneScoreText;
    public Text PlayerTwoScoreText;
    //these are int variables
    public int PlayerOneScore;
    public int PlayerTwoScore;
    //these are int variables
    public GameObject SpawnOne;
    public GameObject SpawnTwo;
  

     
    public void Respawn(int Playernum)
    {   //this code is setting a respawn point for the players so they respawn where they are told every time
        Player1.transform.position = SpawnOne.transform.position;
        Player2.transform.position = SpawnTwo.transform.position;
        //this is isolating the players to their seperate respawn points
        if(Playernum == 1)
        {
            PlayerTwoScore++;
            PlayerTwoScoreText.text = PlayerTwoScore.ToString();

        }//his is isolating the players to their seperate respawn points
        else
        { 
            PlayerOneScore++;
            PlayerOneScoreText.text = PlayerOneScore.ToString();
        }
    }
}
