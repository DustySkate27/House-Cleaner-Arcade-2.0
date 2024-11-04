using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class tienda : MonoBehaviour
{
    public static tienda Instance;

    //silbato|Red Scream
    public GameObject silAct;
    public GameObject silInact;
    public static bool sBuy = false;

    //poción|Solving Potion
    public GameObject potAct;
    public GameObject potInact; 
    public static bool pBuy = false;

    public TextMeshProUGUI actualMon;
    public GameObject price;
    public TextMeshProUGUI priceText;
    public GameObject textPan;
    public TextMeshProUGUI descText; 


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
        checker();
    }

    // Update is called once per frame
    void Update()
    {
        actualMon.text = economyManager.playerMoney.ToString();
    }

    public void OnHighlightSil()
    {
        textPan.SetActive(true);
        price.SetActive(true);
        priceText.text = "50";
        descText.text = "The Red Scream: Use this and all the dogs will be gone by the time they hear it. Be aware! The sound destroys the device (And sometimes the user)";
    }

    public void OffHighlightSil()
    {
        textPan.SetActive(false);
        price.SetActive(false);
        priceText.text = string.Empty;
        descText.text = string.Empty;
    }

    public void OnHighlightPot()
    {
        textPan.SetActive(true);
        price.SetActive(true);
        priceText.text = "100";
        descText.text = "The Solving Potion: I'm not sure what this does, but it must have something to do with fixing something... At least I think so.";
    }

    public void OffHighlightPot()
    {
        textPan.SetActive(false);
        price.SetActive(false);
        priceText.text = string.Empty;
        descText.text = string.Empty;
    }

    public void silBuyed()
    {
        if (sBuy == false && economyManager.playerMoney >= 50)
        {
            sBuy = true;
            economyManager.playerMoney-=50;
            silAct.gameObject.SetActive(false);
            silInact.gameObject.SetActive(true);
            textPan.SetActive(false);
            price.SetActive(false);
            priceText.text = string.Empty;
            descText.text = string.Empty;
        }
    }

    public void potBuyed()
    {
        if (pBuy == false && economyManager.playerMoney >= 100)
        {
            pBuy = true;
            economyManager.playerMoney -= 100;
            potAct.gameObject.SetActive(false);
            potInact.gameObject.SetActive(true);
            textPan.SetActive(false);
            price.SetActive(false);
            priceText.text = string.Empty;
            descText.text = string.Empty;
        }
    }

    public void checker()
    {
        if (sBuy == false)
        {
            silAct.SetActive(true);
        }
        if (pBuy == false)
        {
            potAct.SetActive(true);
        }
    }

}
