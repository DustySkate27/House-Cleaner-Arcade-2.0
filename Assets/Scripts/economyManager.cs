using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class economyManager : MonoBehaviour
{
    public static economyManager Instance;
    public static int playerMoney = 0;
    public static int LevelMoney = 0;

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

    public void calculoDinero()
    {
        if (perfectManager.perfect == 100) //Si hace mas del 50%
        {
            LevelMoney = 50; //Se le da esta plata
            perfectManager.perfect = 100; //Y se resetea el perfect para el proximo nivel
        }

        if(perfectManager.perfect < 100)
        {
            LevelMoney = 20;
            perfectManager.perfect = 100;
        }
    }
    public void getMoney()
    {
        playerMoney += LevelMoney;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
