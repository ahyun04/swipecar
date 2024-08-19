using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class CarController : MonoBehaviour
{
    private float Speed = 1 ;
    void Start()
    {
        
    }

    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Debug.Log(Input.mousePosition);
            this.transform.Translate(Speed, 0, 0);
            Speed = 0.1f;
        }
        if(Input.GetMouseButtonDown(1))
        {
            Debug.Log(Input.mousePosition);
            this.transform.Translate(-Speed, 0, 0);
            Speed = 0.1f;
        }
    }
}
