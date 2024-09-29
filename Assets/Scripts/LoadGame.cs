using System.Collections;
using System.Collections.Generic;
using TMPro.Examples;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadGame : MonoBehaviour
{

    public void CargarJuego()
    {
        SceneManager.LoadScene("nivel1");
    }
    public void volverMenu()
    {
        SceneManager.LoadScene("Menu");
    }
    public void salir()
    {
        Application.Quit();
    }

    public void CargarNivel()
    {
        if (SceneManager.GetActiveScene().name == "win")
        {
            SceneManager.LoadScene("nivel2");
        }

    }
}
