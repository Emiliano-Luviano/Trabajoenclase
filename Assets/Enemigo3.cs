using System.Collections;
using System.Collections.Generic;
using Unity.Properties;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemigo3 : MonoBehaviour
{
    public float speed;
    public TextoPuntaje textObject;
    public TextoVidas textObjectVidas;
    public int vidas;
    void Start()
    {
        textObject = FindAnyObjectByType<TextoPuntaje>();
        textObjectVidas = FindAnyObjectByType<TextoVidas>();
    }

    
    void Update()
    {
        transform.Translate(Vector3.left.normalized * speed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Pared")
        {
            Destroy(gameObject);
        }
        else if (collision.gameObject.tag == "Jugador")
        {
            textObjectVidas.puntosVida = textObjectVidas.puntosVida - 1;
            if (textObjectVidas.puntosVida == 0)
            {
                Destroy(collision.gameObject);
                SceneManager.LoadScene(3);
            }
            Destroy(gameObject);

        }
        else
        {
            vidas = vidas - 1;
            if (vidas == 0)
            {
                Destroy(gameObject);
            }
            textObject.puntos = textObject.puntos + 1;
            Destroy(collision.gameObject);
            
            if (textObject.puntos == 10)
            {
                SceneManager.LoadScene(2);
            }
        }

    }
}
