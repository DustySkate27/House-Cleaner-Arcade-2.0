using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class winScreen : MonoBehaviour
{

    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        animator.SetBool("finale", true);
    }

}
