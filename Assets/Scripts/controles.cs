using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class controles : MonoBehaviour
{
    [SerializeField] public Transform spawnUp;
    [SerializeField] public Transform spawnDown;
    [SerializeField] public Transform spawnLeft;
    [SerializeField] public Transform spawnRight;
    [SerializeField] public GameObject escoba;
    [SerializeField] private bool escAct=false;
    [SerializeField] private bool check = false;
    [SerializeField] public Vector2 velocidad;

    private Rigidbody2D rb;

    private GameObject[] cantidad;
    private GameObject[] cantidadInicial;
    [SerializeField] private TextMeshProUGUI cantidadTexto;
    private int percent;

    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        cantidadInicial = GameObject.FindGameObjectsWithTag("Mugre");
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        velocidad.x = 10;
        velocidad.y = 10;
    }

    // Update is called once per frame
    void Update()
    {
        animations();

        if (Input.GetKeyDown("w"))
        {
            rb.AddForce(Vector3.up * velocidad.y, ForceMode2D.Impulse);
            Debug.Log("gO UP, bby");
        }

        if (Input.GetKeyDown("s"))
        {
            rb.AddForce(Vector3.down * velocidad.y, ForceMode2D.Impulse);
        }

        if (Input.GetKeyDown("d"))
        {
            rb.AddForce(Vector3.right * velocidad.x, ForceMode2D.Impulse);
        }

        if (Input.GetKeyDown("a"))
        {
            rb.AddForce(Vector3.left * velocidad.x, ForceMode2D.Impulse);
        }

        if (Input.GetKeyDown("p") && rb.velocity.y > 0 && escAct == false)
        {
            Instantiate(escoba, spawnUp);
            escAct = true;
            checkEscoba(check);
        }
        if (Input.GetKeyDown("p") && rb.velocity.y < 0 && escAct == false)
        {
            Instantiate(escoba, spawnDown);
            escAct = true;
            checkEscoba(check);
        }
        if (Input.GetKeyDown("p") && rb.velocity.x > 0 && escAct == false)
        {
            Instantiate(escoba, spawnRight);
            escAct = true;
            checkEscoba(check);
        }
        if (Input.GetKeyDown("p") && rb.velocity.x < 0 && escAct == false)
        {
            Instantiate(escoba, spawnLeft); 
            escAct = true;
            checkEscoba(check);
        }

        cleanPorcent();

    }

    private void animations()
    {
        if (rb.velocity.y > 0)
            animator.SetBool("IsUp",true);
        else
            animator.SetBool("IsUp", false);

        if (rb.velocity.y < 0)
            animator.SetBool("IsDown", true);
        else
            animator.SetBool("IsDown", false);

        if (rb.velocity.x > 0)
            animator.SetBool("IsRight", true);
        else
            animator.SetBool("IsRight", false);

        if (rb.velocity.x < 0)
            animator.SetBool("IsLeft", true);
        else
            animator.SetBool("IsLeft", false);
    }

    public void cleanPorcent()
    {
        cantidad = GameObject.FindGameObjectsWithTag("Mugre");

        percent = cantidad.Length/cantidadInicial.Length*100; 

        cantidadTexto.text = "Dirt: " + percent.ToString() + "%";
    }


    public void checkEscoba(bool check)
    {
        if (check == true)
        {
            escAct = false;
            check = false;
        }
    }
}
