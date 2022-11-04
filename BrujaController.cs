using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BrujaController : MonoBehaviour
{
    private float empuje = 150f;
    private Rigidbody2D rb;
    Text interfaz_vidas;
    int vidas = 3;
    GameObject deadwindow;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        interfaz_vidas = GameObject.FindGameObjectWithTag("vida").GetComponent<Text>();
        interfaz_vidas.text = vidas + "";
        deadwindow = GameObject.FindGameObjectWithTag("deadwindow");
        deadwindow.GetComponent<CanvasGroup>().alpha = 0;

    }

    // Update is called once per frame
    void Update()
    {
        

        if (Input.GetKeyUp("space"))
        {
            rb.velocity = new Vector2(0, empuje * Time.deltaTime);
        }


        if (Input.GetKeyUp("r") && vidas <= 0)
        {
            SceneManager.LoadScene("SampleScene");
        }

        if (vidas <=0)
        {
            vidas = 0;
            hasmuerto();
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag=="obstaculo")
        {
            vidas--;
            interfaz_vidas.text = vidas + "";
        }

        if (collision.tag == "deadzone")
        {
            vidas=0;
            interfaz_vidas.text = vidas + "";
        }
    }

    void hasmuerto()
    {
        deadwindow.GetComponent<CanvasGroup>().alpha = 1;
    }
}
