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
            audioSource.Play();
            animator.SetBool("opening", true);
            animator.SetBool("open", true);
        }
    }

    public void openDoor(bool act)
    {
        hecho = act;
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
        }

        if (SceneManager.GetActiveScene().name == "nivel2")
        {
            SceneManager.LoadScene("win2");
        }

        if (SceneManager.GetActiveScene().name == "nivel3")
        {
            SceneManager.LoadScene("win3");
        }

    }
}
