using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRay_Script : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Camera!");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) ShotRay(Input.mousePosition);
    }
    void ShotRay(Vector2 mouse)
    {
        Debug.Log("mouse："+mouse);
    }
}
