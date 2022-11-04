using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PuntuacionController : MonoBehaviour
{
    // Start is called before the first frame update

    float puntuacion = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        puntuacion+= 1f*Time.deltaTime;
        Text interfaz_puntuacion = GameObject.FindGameObjectWithTag("puntuacion").GetComponent<Text>();
        interfaz_puntuacion.text = Mathf.Round(puntuacion) + "";
    }
}
