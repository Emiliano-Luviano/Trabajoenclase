using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Enemigo : MonoBehaviour
{
    public GameObject enemy;
    public float max;
    public float min;

    public float timer;
    void Start()
    {
        
    }

    void Update()
    {
        timer = timer - Time.deltaTime;
        if (timer <= 0)
        {
            float posY = Random.Range(min, max);
            Instantiate(enemy, new Vector3(transform.position.x, posY, 0), Quaternion.identity);
            timer = 1;
        }
    }
}
