using System.Collections;
/*
 *  EJ Flores
 *  GameController.cs
 *  Assignment 11
 *  This is the GameController. It makes the player take damage after a fixed interval as well as providing inputs for pausing and healing.
 */

using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameController : MonoBehaviour
{
    public GameFacade gf;
    public TextMeshProUGUI healthText;

    private void Start()
    {
        StartCoroutine(gf.TakeDamage());
    }

    private void Update()
    {
        healthText.text = "Current Health: " + gf.GetHealth();
        
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(gf.GetPauseState())
            {
                gf.Unpause();
            } else
            {
                gf.Pause();
            }
        }

        if(Input.GetKeyDown(KeyCode.E))
        {
            gf.Heal();
        }
    }
}
