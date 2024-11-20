using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class solvingPotion : MonoBehaviour
{

    public GameObject iImage;
    public GameObject potSolPhAct;
    public GameObject potSolPhInact;

    [SerializeField] private List<GameObject> crateres = new List<GameObject>();
    [SerializeField] private List<GameObject> manchas = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        if (itemManager.Instance.pBuy == true)
        {
            iImage.SetActive(true);
            potSolPhAct.SetActive(true);
        }
        else
        {
            iImage.SetActive(false);
            potSolPhAct.SetActive(false);
        }
        potSolPhInact.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        usePotion();
    }

    private void usePotion()
    {
        if(Input.GetKeyDown("i") && itemManager.Instance.pBuy == true)
        {
            foreach (GameObject crater in crateres)
            {
                crater.SetActive(false);
            }
            foreach (GameObject mancha in manchas)
            {
                mancha.SetActive(true);
            }
            iImage.SetActive(false);
            potSolPhAct.SetActive(false);
            potSolPhInact.SetActive(true);
            itemManager.Instance.pBuy = false;
        }
    }
}
