using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class quitGame : MonoBehaviour
{
    void Start()
    {

    }
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            OyundanC�k();
        }
        
        if (Input.GetKeyDown("r"))
        {
            SceneManager.LoadScene("Start");
        }


    }

     public void OyundanC�k()
    {
        UnityEditor.EditorApplication.isPlaying = false;
    }
}
