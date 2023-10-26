using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class TextoVidas : MonoBehaviour
{
    TMP_Text textComponent;
    public int puntosVida = 5;
   
    void Start()
    {
        textComponent = GetComponent<TMP_Text>();
    }


    void Update()
    {
        textComponent.text = "Vidas: " + puntosVida;
    }
}
