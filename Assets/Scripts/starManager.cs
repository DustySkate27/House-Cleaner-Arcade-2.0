using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class starManager : MonoBehaviour
{
    public static starManager Instance;

    public GameObject star1;
    public GameObject star2;
    public GameObject star3;
    public GameObject star1off;
    public GameObject star2off;
    public GameObject star3off;
    public static int starFilter = 0;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }

        
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        parameter();
    }

    public void parameter()
    {
        if (perfectManager.perfect >= 25 && starFilter == 0)
        {
            star1.SetActive(true);
            star1off.SetActive(false);
            starFilter++;
        }
        if (perfectManager.perfect >= 50 && starFilter == 1)
        {
            star2.SetActive(true);
            star2off.SetActive(false);
            starFilter++;
        }
        if (perfectManager.perfect == 100 && starFilter == 2)
        {
            star3.SetActive(true);
            star3off.SetActive(false);
            starFilter++;
        }
    }
}
