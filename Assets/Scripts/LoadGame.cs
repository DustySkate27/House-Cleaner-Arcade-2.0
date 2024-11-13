using System.Collections;
using System.Collections.Generic;
using TMPro.Examples;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadGame : MonoBehaviour
{
    private AudioSource sound;
    [SerializeField] public AudioClip buttonSound;

    private void Start()
    {
        sound = GetComponent<AudioSource>();
    }

    public void CargarJuego()
    {
        sound.PlayOneShot(buttonSound);
        SceneManager.LoadScene("nivel1");
    }
    public void volverMenu()
    {
        sound.PlayOneShot(buttonSound);
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
        sound.PlayOneShot(buttonSound);
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

            perfectManager.perfect = 0;
            economyManager.LevelMoney = 0;

        }
        if (SceneManager.GetActiveScene().name == "store")
        {
            musicPlayer.instance.putMusic();
            SceneManager.LoadScene("nivel3");

            perfectManager.perfect = 0;
            economyManager.LevelMoney = 0;

        }
        if (SceneManager.GetActiveScene().name == "win3")
        {
            SceneManager.LoadScene("nivel4");

            perfectManager.perfect = 0;
            economyManager.LevelMoney = 0;

        }
    }
}
