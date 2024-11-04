using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class economyManager : MonoBehaviour
{
    public static economyManager Instance;
    public static int playerMoney = 150;
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

    private void sumarDinero()
    {
        if (perfectManager.perfect > 50) //Si hace mas del 50%
        {
            LevelMoney = 1000; //Se le da esta plata
            perfectManager.perfect = 0; //Y se resetea el perfect para el proximo nivel
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
        Debug.Log(playerMoney);
        Debug.Log(LevelMoney);
    }
}
