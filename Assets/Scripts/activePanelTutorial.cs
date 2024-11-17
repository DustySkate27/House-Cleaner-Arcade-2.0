using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activePanelTutorial : MonoBehaviour
{
    [SerializeField] public GameObject panel;
    private void Awake()
    {
        Time.timeScale = 0.0f;
        panel.SetActive(true);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
