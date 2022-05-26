using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{// makes dropdown accesible
    
    public void Sceneselection()
    {
        //lets you load scenes
        SceneManager.LoadScene(1);
    }


}

