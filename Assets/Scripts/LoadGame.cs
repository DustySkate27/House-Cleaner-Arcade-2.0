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
            economyManager.Instance.LevelMoney = 0;
            perfectManager.Instance.perfect = 0;
        }
        if (SceneManager.GetActiveScene().name == "win2")
        {
            SceneManager.LoadScene("nivel3");
            economyManager.Instance.LevelMoney = 0;
            perfectManager.Instance.perfect = 0;

        }
    }
}
