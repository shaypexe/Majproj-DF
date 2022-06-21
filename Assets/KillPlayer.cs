using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class KillPlayer : MonoBehaviour
{
    //
    public int Respawn;
    //
    public Game game;
    //
    public int Playernum;

    private void Start()
    {//
        game = GameObject.Find("Canvas").GetComponent<Game>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {//
        if (collision.CompareTag("Player"))
        {//
            Invoke("RespawnNow", 0.5f);
          
        }
    }

    void RespawnNow()
    {//
        game.Respawn(Playernum);
    }
}
