using System.Collections;
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
