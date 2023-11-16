using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo2 : MonoBehaviour
{
    public float speedx;
    public float speedy;
    Vector3 direccion = new Vector3(-1, 1, 0);
    void Start()
    {

    }


    void Update()
    {
        if (transform.position.y > 6)
        {
            direccion.y = -1;
        }
        else if (transform.position.y < -3.3 )
        {
            direccion.y = 1;
        }

        transform.Translate(new Vector3(direccion.x* speedx, direccion.y*speedy, 0) * Time.deltaTime);
    }
}
