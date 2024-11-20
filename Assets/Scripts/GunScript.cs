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
            gunControl.isShooting = true;

            consumptionTimer += Time.deltaTime;

            if (gunControl.waterPressure1)
            {
                ActivateWater(water1);
                if (consumptionTimer >= 1.0f)
                {
                    gunControl.WaterTank -= 2;
                    consumptionTimer = 0f;
                }
            }
            else if (gunControl.waterPressure2)
            {
                ActivateWater(water2);
                if (consumptionTimer >= 1.0f)
                {
                    gunControl.WaterTank -= 5;
                    consumptionTimer = 0f;
                }
            }
            else if (gunControl.waterPressure3)
            {
                ActivateWater(water3);
                if (consumptionTimer >= 1.0f)
                {
                    gunControl.WaterTank -= 10;
                    consumptionTimer = 0f;
                }
            }

            if (gunControl.WaterTank <= 0)
            {
                gunControl.WaterTank = 0;
                DeactivateAllWater();
            }
        }
        else
        {
            DeactivateAllWater();
            consumptionTimer = 0f;
            gunControl.isShooting = false;
        }
    }

    private void ActivateWater(GameObject activeWater)
    {
        water1.SetActive(activeWater == water1);
        water2.SetActive(activeWater == water2);
        water3.SetActive(activeWater == water3);
    }

    private void DeactivateAllWater()
    {
        water1.SetActive(false);
        water2.SetActive(false);
        water3.SetActive(false);
    }




}

