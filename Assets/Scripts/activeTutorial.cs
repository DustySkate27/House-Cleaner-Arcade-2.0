using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class activeTutorial : MonoBehaviour
{
    [SerializeField] public GameObject panelGun;

    public void resumeGame()
    {
        Time.timeScale = 1.0f;
        panelGun.SetActive(false);
    }
}
