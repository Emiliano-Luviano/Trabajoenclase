using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Enemigo : MonoBehaviour
{

    public GameObject enemy;
    public GameObject tanque;
    public GameObject veloz;
    public GameObject zigzag;
    public float max;
    public float min;
    public float timer;
    void Start()
    {

    }

    void Update()
    {
        timer = timer - Time.deltaTime;

        int enemigoElegido = Random.Range(0, 100);
        if (timer <= 0)
        {
            float posY = Random.Range(min, max);
            if (enemigoElegido < 25)
            {
                Instantiate(enemy, new Vector3(transform.position.x, posY, 0), Quaternion.identity);
                timer = 1;
            }

            else if (enemigoElegido < 50)
            {
                Instantiate(tanque, new Vector3(transform.position.x, posY, 0), Quaternion.identity);
            }
            else if (enemigoElegido < 75)
            {
                Instantiate(veloz, new Vector3(transform.position.x, posY, 0), Quaternion.identity);
            }
            else if (enemigoElegido < 100)
            {
                Instantiate(zigzag, new Vector3(transform.position.x, posY, 0), Quaternion.identity);
            }
            timer = 1;

        }
    }
}

