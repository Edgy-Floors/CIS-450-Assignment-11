using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PauseSystem : MonoBehaviour
{
    public TextMeshProUGUI tmp;

    public void LoadPauseMenu()
    {
        tmp.gameObject.SetActive(true);
        Time.timeScale = 0f;
    }

    public void UnloadPauseMenu()
    {
        Time.timeScale = 1.0f;

        tmp.gameObject.SetActive(false);
    }
}
