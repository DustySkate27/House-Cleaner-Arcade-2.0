using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitLevel : MonoBehaviour
{

    [SerializeField] private int selecLevel;

    private bool hecho = false;
    Animator animator;

    public void Start()
    {
        animator = GetComponent<Animator>();
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
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Jugador") && hecho == true)
        {
            SceneManager.LoadScene(selecLevel);
        }
    }
}
