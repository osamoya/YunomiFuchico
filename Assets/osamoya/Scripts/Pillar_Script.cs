using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pillar_Script : MonoBehaviour
{
    //[SerializeField]GameObject pillar;
    [SerializeField] float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.localEulerAngles += new Vector3(0, speed, 0);

        if(Input.GetKeyDown(KeyCode.Z)) transform.Rotate(new Vector3(speed, 0, 0));


    }

}
