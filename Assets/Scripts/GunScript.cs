using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunScript : MonoBehaviour
{
    [SerializeField] private GameObject water1;

    [SerializeField] private GameObject water2;

    [SerializeField] private GameObject water3;


    [SerializeField] private float waterConsumptionRate;

    [SerializeField] private float consumptionTimer;

    [SerializeField] private GunControl gunControl;

    // Start is called before the first frame update
    void Start()
    {
        consumptionTimer = 0f;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space) && gunControl.WaterTank > 0)
        {

            water1.SetActive(true);


            consumptionTimer += Time.deltaTime;


            if (consumptionTimer >= 1.0f)
            {
                gunControl.WaterTank -= waterConsumptionRate;
                consumptionTimer = 0f;

                if (gunControl.WaterTank <= 0)
                {
                    gunControl.WaterTank = 0;
                    water1.SetActive(false);
                }
            }
        }
        else
        {

            water1.SetActive(false);
            consumptionTimer = 0f;
        }
    }
}

