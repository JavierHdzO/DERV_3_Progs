using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SistemaJuego : MonoBehaviour
{

    public TextMeshProUGUI txt_puntaje;
    public TextMeshProUGUI txt_tiempo;
    public TextMeshProUGUI Fin;
    private float tiempo = 10f;

    int puntaje;


    // Start is called before the first frame update
    void Start()
    {
        puntaje = 0;
        txt_tiempo.text = " " + tiempo;
        Fin.enabled = false;

    }

    // Update is called once per frame
    void Update()
    {
        tiempo -= Time.deltaTime;
        txt_tiempo.text = " " + tiempo.ToString("f0");

        if (tiempo <= 0)
        {
            //txt_tiempo.text = "0";
            Fin.enabled = true;
            tiempo = Time.timeScale = 0;
        }

    }

    private void FixedUpdate()
    {

    }


    private void OnCollisionEnter(Collision collision)
    {
        string etiqueta = collision.gameObject.tag;
        string nombre;

        

        if (etiqueta.Equals("Dinero"))
        {
            Debug.Log("Colisión con: " + etiqueta);
            nombre = collision.gameObject.name;

            GameObject gameObj;
            gameObj = GameObject.Find(nombre);
            Destroy(gameObj);

            puntaje++;
            txt_puntaje.text = puntaje.ToString();

            tiempo += 5f;

        }

    }

    private void OnCollisionStay(Collision collision)
    {
        
    }

    private void OnCollisionExit(Collision collision)
    {
        
    }

}
