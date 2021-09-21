using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ControladorUI : MonoBehaviour
{
    public TextMeshProUGUI texto;
    
    public void saludar() 
    {
        texto.text = "Hola amigo";
    }
}
