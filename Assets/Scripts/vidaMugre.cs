using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class vidaMugre : MonoBehaviour
{
    private int vida = 1;
    


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
    public void tomarDanio(int danio)
    {
        vida -= danio;
        if(vida <= 0)
        {
            Destroy(gameObject);
        }
    }
}
