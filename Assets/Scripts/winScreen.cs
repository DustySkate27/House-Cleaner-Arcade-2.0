using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class winScreen : MonoBehaviour
{

    private Animator animator;

    [SerializeField] private GameObject numberPrefab;
    [SerializeField] private TextMeshProUGUI numberText;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        animator.SetBool("finale", true);
        numberText = numberPrefab.GetComponent<TextMeshProUGUI>();
        numberText.text = economyManager.LevelMoney.ToString();
    }



}
