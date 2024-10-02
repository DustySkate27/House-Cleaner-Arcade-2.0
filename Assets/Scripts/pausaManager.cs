using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pausaManager : MonoBehaviour
{
    [SerializeField] private GameObject pausarPanel;

    private void Start()
    {
        if (SceneManager.GetActiveScene().name == "nivel1")
        {
            Time.timeScale = 0f;
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown("escape"))
        {
            pausar();
        }
    }

    public void pausar()
    {
        pausarPanel.SetActive(true);
        Time.timeScale = 0f;
    }
    public void despausar()
    {
        Time.timeScale = 1f;
    }

    public void volverMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
