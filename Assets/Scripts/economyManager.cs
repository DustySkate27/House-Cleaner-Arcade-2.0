using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class economyManager : MonoBehaviour
{
    public static economyManager Instance;
    public int playerMoney;
    public int LevelMoney;

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

    public void loadLevel()
    {
        if (SceneManager.GetActiveScene().name == "nivel1")
        {
            LevelMoney = 0;
        }
        if (SceneManager.GetActiveScene().name == "nivel2")
        {
            LevelMoney = 0;
        }
        if (SceneManager.GetActiveScene().name == "nivel3")
        {
            LevelMoney = 0;
        }
    }

    private void sumarDinero()
    {
        if (perfectManager.Instance.perfect > 50)
        {
            LevelMoney = 1000;
        }

    }
    public void getMoney()
    {
        playerMoney += LevelMoney;
    }

    // Update is called once per frame
    void Update()
    {
        sumarDinero();
        Debug.Log(LevelMoney);
        Debug.Log(playerMoney);
    }
}
