using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextoPuntaje : MonoBehaviour
{
    TMP_Text textComponent;
     public int puntos = 0;
    void Start()
    {
        textComponent = GetComponent<TMP_Text>();
    }

    
    void Update()
    {
        textComponent .text= "Puntos:" + puntos ;
    }
}
