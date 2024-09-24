using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitLevel : MonoBehaviour
{
    [SerializeField] public int tareasHacer;
    [SerializeField] public int tareas;
    private bool hecho = false;

    private void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(tareas >= tareasHacer)
        {
            hecho = true;
        }
    }
    
    public void juntarTareas()
    {
        tareas++;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Jugador") && hecho == true)
        {
            SceneManager.LoadScene(2);
        }
    }
}
