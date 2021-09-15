using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TriggersRespawn : MonoBehaviour
{

    public GameObject posInicio;
    public GameObject objetoLanzar;
    int i = 0;
    // Start is called before the first frame update
    void Start()
    {
        i = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
      
    }


    //Corrutina


    //Trigger
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag.Equals("Player")) 
        {
            GameObject obj = Instantiate(objetoLanzar, posInicio.transform.position, posInicio.transform.rotation) as GameObject;
            obj.name = "Enemigo";
            Destroy(obj, 3);
        }
    }

    

    private void OnTriggerExit(Collider other)
    {
        
    }

}
