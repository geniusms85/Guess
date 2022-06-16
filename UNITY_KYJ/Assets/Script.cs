using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script : MonoBehaviour
{
    [SerializeField]
    private float _speed = 30;
    

    void Start()
    {
        transform.position = Vector3.zero;
    }

  
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
            transform.position += Vector3.forward * Time.deltaTime * _speed;
        if (Input.GetKey(KeyCode.S))
            transform.position += Vector3.back * Time.deltaTime * _speed;
        if (Input.GetKey(KeyCode.A))
            transform.position += Vector3.left * Time.deltaTime * _speed;
        if (Input.GetKey(KeyCode.D))
            transform.position += Vector3.right * Time.deltaTime * _speed;

        if (Input.GetKey(KeyCode.O))
            transform.localScale += new Vector3(1.0f,0,0)*Time.deltaTime; 
        if(Input.GetKey(KeyCode.P))
            transform.localScale -= new Vector3(0,1.0f,0)*Time.deltaTime; 
    }
}
