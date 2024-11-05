using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitLevel : MonoBehaviour
{
    private AudioSource audioSource;
    private bool hecho = false;
    Animator animator;

    public void Start()
    {
        animator = GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();
    }

    public void Update()
    {
        if (hecho)
        {
            animator.SetBool("opening", true);
            animator.SetBool("open", true);
        }
    }
    public void openDoor(bool act)
    {
        hecho = act;
        audioSource.Play();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Jugador") && hecho == true)
        {
            CargarNivel();
        }
    }

    public void CargarNivel()
    {
        if (SceneManager.GetActiveScene().name == "nivel1")
        {
            SceneManager.LoadScene("win");
            economyManager.Instance.calculoDinero();
            economyManager.Instance.getMoney();
        }

        if (SceneManager.GetActiveScene().name == "nivel2")
        {
            SceneManager.LoadScene("win2");
            economyManager.Instance.calculoDinero();
            economyManager.Instance.getMoney();
        }

        if (SceneManager.GetActiveScene().name == "nivel3")
        {
            SceneManager.LoadScene("win3");
            economyManager.Instance.getMoney();
        }

    }
}
