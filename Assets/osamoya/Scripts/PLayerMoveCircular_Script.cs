using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PLayerMoveCircular_Script : MonoBehaviour
{
    [SerializeField] float speed;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start");   
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("Start");
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(new Vector3(0, speed, 0));
            
            Debug.Log("A");
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(new Vector3(0, -speed, 0));
            Debug.Log("D");
        }
    }
}
