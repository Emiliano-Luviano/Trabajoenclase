using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemigo2 : MonoBehaviour
{
    public float speedx;
    public float speedy;
    public TextoPuntaje textObject;
    public TextoVidas textObjectVidas;
    public int vidas;
    Vector3 direccion = new Vector3(-1, 1, 0);
    void Start()
    {
        textObject = FindAnyObjectByType<TextoPuntaje>();
        textObjectVidas = FindAnyObjectByType<TextoVidas>();
    }


    void Update()
    {
        if (transform.position.y > 6)
        {
            direccion.y = -1;
        }
        else if (transform.position.y < -3.3)
        {
            direccion.y = 1;
        }

        transform.Translate(new Vector3(direccion.x * speedx, direccion.y * speedy, 0) * Time.deltaTime);
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
