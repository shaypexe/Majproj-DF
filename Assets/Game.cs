using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Game : MonoBehaviour
{
    public GameObject Player1;
    public GameObject Player2;
    public Text PlayerOneScoreText;
    public int PlayerOneScore;
    public Text PlayerTwoScoreText;
    public int PlayerTwoScore;
    public GameObject SpawnOne;
    public GameObject SpawnTwo;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void Respawn(int Playernum)
    {
        Player1.transform.position = SpawnOne.transform.position;
        Player2.transform.position = SpawnTwo.transform.position;

        if(Playernum == 1)
        {
            PlayerTwoScore++;
            PlayerTwoScoreText.text = PlayerTwoScore.ToString();

        }
        else
        { 
            PlayerOneScore++;
            PlayerOneScoreText.text = PlayerOneScore.ToString();
        }
    }
}
