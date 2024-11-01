using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunControl : MonoBehaviour
{
    [SerializeField] private GameObject gunUp;
    [SerializeField] private GameObject gunDown;
    [SerializeField] private GameObject gunRight;
    [SerializeField] private GameObject gunLeft;

    private controles broomControl;


    public float WaterTank;
    

    // Start is called before the first frame update
    void Start()
    {
        broomControl = GetComponent<controles>();
    }

    // Update is called once per frame
    void Update()
    {
        gun();
    }
    private void gun()
    {
        if (broomControl != null && !broomControl.escAct)
        {
            if (Input.GetKeyDown(KeyCode.UpArrow)) // Up
            {
                gunUp.SetActive(true);
                gunDown.SetActive(false);
                gunRight.SetActive(false);
                gunLeft.SetActive(false);
            }

            if (Input.GetKeyDown(KeyCode.DownArrow)) // Down
            {
                gunUp.SetActive(false);
                gunDown.SetActive(true);
                gunRight.SetActive(false);
                gunLeft.SetActive(false);
            }

            if (Input.GetKeyDown(KeyCode.RightArrow)) // Right
            {
                gunUp.SetActive(false);
                gunDown.SetActive(false);
                gunRight.SetActive(true);
                gunLeft.SetActive(false);
            }

            if (Input.GetKeyDown(KeyCode.LeftArrow)) // Left
            {
                gunUp.SetActive(false);
                gunDown.SetActive(false);
                gunRight.SetActive(false);
                gunLeft.SetActive(true);
            }
        }
        else
        {
            deactivateGuns(); // Si la escoba está activa, desactiva todas las armas
        }
    }
    

    private void deactivateGuns()
    {
        gunUp.SetActive(false);
        gunDown.SetActive(false);
        gunRight.SetActive(false);
        gunLeft.SetActive(false);
    }



}
 
