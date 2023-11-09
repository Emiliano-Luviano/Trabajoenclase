using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Botones : MonoBehaviour
{
   
    public void BotonJugar()
    {
        SceneManager.LoadScene(1);
    }
    public void botónMenú ()
    {
        SceneManager.LoadScene(0);
    }
  

    public void SalirDelJuego()
    {
        Application.Quit();
    }
      
}
