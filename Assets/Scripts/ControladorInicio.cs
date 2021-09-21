using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControladorInicio : MonoBehaviour
{
    // Start is called before the first frame update
  public void iniciaJuego() 
    {
        SceneManager.LoadScene(1);
    }
}
