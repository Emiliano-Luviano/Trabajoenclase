using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MovimientoEnemigo : MonoBehaviour
{
    public float speed;
    public TextoPuntaje textObject;
    public TextoVidas textObjectVidas;
    void Start()
    {
        textObject = FindAnyObjectByType<TextoPuntaje>();
    }

  
    void Update()
    {
        transform.Translate(Vector3.left.normalized * speed * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision collision)
    {
        textObject.puntos = textObject.puntos + 1;


        if (collision.gameObject.tag == "Pared")
        {

        }
        else if (collision.gameObject.tag =="Jugador")
        {
            textObjectVidas.puntosVida = textObjectVidas.puntosVida - 1;
            if (textObjectVidas.puntosVida==0)
            {
                Destroy(collision.gameObject);
                SceneManager.LoadScene(0);               
            }
            Destroy(gameObject);

        }
        else
        {
            textObject.puntos = textObject.puntos + 1;
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }

        

        

    }
}
