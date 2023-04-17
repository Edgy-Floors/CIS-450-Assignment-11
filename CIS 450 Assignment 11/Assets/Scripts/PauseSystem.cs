using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PauseSystem : MonoBehaviour
{
    public TextMeshProUGUI tmp;
    private bool isPaused = false;

    public void LoadPauseMenu()
    {
        isPaused = true;
        tmp.gameObject.SetActive(true);
        Time.timeScale = 0f;
    }

    public void UnloadPauseMenu()
    {
        isPaused = false;
        Time.timeScale = 1.0f;
        tmp.gameObject.SetActive(false);
    }

    public bool GetPauseState()
    {
        return isPaused;
    }
}
