using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balas : MonoBehaviour
{
    
    public float speed;
   
    void Start()
    {
        
    }

   
    void Update()
    {
        transform.Translate(Vector3.right * speed * Time.deltaTime);
    }
}
