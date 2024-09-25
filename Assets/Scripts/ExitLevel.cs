using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitLevel : MonoBehaviour
{ 
    private bool hecho = false;
    Animator animator;

    private void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void openDoor(bool act)
    {
        hecho = act;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Jugador") && hecho == true)
        {
            SceneManager.LoadScene("Win");
        }
    }
}
