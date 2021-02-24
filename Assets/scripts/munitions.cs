using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor.SceneManagement;

public class munitions : MonoBehaviour
{   
    public Image[] bullets;
    int numOfBullets;
    void Start()
    {
        numOfBullets = 0;
    }
    void Update()
    {
        if(numOfBullets < bullets.Length)
        {
            if(Input.GetMouseButtonDown(0))
            {
                bullets[numOfBullets].enabled = false;
                numOfBullets++;
            }
        }
        else
        {
            Spawner.stop = true; //if bullets finish, game stop here.
        }
    }

    
}
