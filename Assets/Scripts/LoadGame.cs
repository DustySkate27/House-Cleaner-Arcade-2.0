using System.Collections;
using System.Collections.Generic;
using TMPro.Examples;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadGame : MonoBehaviour
{
    public void CargarJuego()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
