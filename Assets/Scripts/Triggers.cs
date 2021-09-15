using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Triggers : MonoBehaviour
{

    public TextMeshProUGUI txt_puntaje;
    public TextMeshProUGUI txt_vida;

    int puntaje;
    int vida;

    // Start is called before the first frame update
    void Start()
    {
        puntaje = 0;
        vida = 100;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        vida--;
        txt_vida.text = vida.ToString();
    }


    //Corrutina


    //Trigger
    private void OnTriggerEnter(Collider other)
    {
        
    }

    private void OnTriggerStay(Collider other)
    {
        string etiqueta = other.gameObject.tag;
        string nombre;

        Debug.Log("Colisión con: " + etiqueta);

        if (etiqueta.Equals("Enemigo"))
        {
            nombre = other.gameObject.name;

            GameObject gameObj;
            gameObj = GameObject.Find(nombre);

            Destroy(gameObj);

            puntaje++;
            txt_puntaje.text = puntaje.ToString();
        }
        else if (etiqueta.Equals("PowerUp"))
        {
            vida++;
            txt_vida.text = vida.ToString();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        
    }

}
