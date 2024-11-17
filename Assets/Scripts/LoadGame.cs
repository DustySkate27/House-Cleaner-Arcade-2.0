using System.Collections;
using System.Collections.Generic;
using TMPro.Examples;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadGame : MonoBehaviour
{

    private void Start()
    {
    }

    public void CargarJuego()
    {
        SceneManager.LoadScene("nivel1");
    }
    public void volverMenu()
    {
        SceneManager.LoadScene("Menu");
        perfectManager.perfect = 0;
        economyManager.LevelMoney = 0;
        economyManager.playerMoney = 0;
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

            perfectManager.perfect = 0;
            economyManager.LevelMoney = 0;
        }
        if (SceneManager.GetActiveScene().name == "win2")
        {
            musicPlayer.instance.putStore();
            SceneManager.LoadScene("store");

            itemManager.visits++;
            perfectManager.perfect = 0;
            economyManager.LevelMoney = 0;

        }
        if (SceneManager.GetActiveScene().name == "store" && itemManager.visits == 1)
        {
            musicPlayer.instance.putMusic();
            SceneManager.LoadScene("nivel3");

            perfectManager.perfect = 0;
            economyManager.LevelMoney = 0;

        }
        if (SceneManager.GetActiveScene().name == "win3")
        {
            musicPlayer.instance.putStore();
            SceneManager.LoadScene("store");

            itemManager.visits++;
            perfectManager.perfect = 0;
            economyManager.LevelMoney = 0;

        }
        if (SceneManager.GetActiveScene().name == "store" && itemManager.visits == 2)
        {
            musicPlayer.instance.putMusic();
            SceneManager.LoadScene("nivel4");

            perfectManager.perfect = 0;
            economyManager.LevelMoney = 0;

        }

    }
}
