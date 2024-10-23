using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class perfectManager : MonoBehaviour
{
    public static perfectManager Instance;
    public int perfect;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(perfect);
    }

    private void iniciaNivel()
    {
        if (SceneManager.GetActiveScene().name == "nivel1")
        {
            perfect = 0;
        }
        if (SceneManager.GetActiveScene().name == "nivel2")
        {
            perfect = 0;
        }
        if (SceneManager.GetActiveScene().name == "nivel3")
        {
            perfect = 0;
        }

    }


}
