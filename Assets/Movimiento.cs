using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    public GameObject instanceObject;
    public Vector3 instancePosition= new Vector3(0,0,0);
    public float speed;
    
    void Start()
    {
        
    }

   
    void Update()
    {
       if (Input .GetKeyDown(KeyCode.Space))
        {
            Instantiate(instanceObject, transform.position, Quaternion.identity);
                
        }
        if(Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.left.normalized * speed * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.right.normalized * speed * Time.deltaTime);
        }
    }
}
