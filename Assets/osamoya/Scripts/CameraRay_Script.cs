using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRay_Script : MonoBehaviour
{
    Camera MainCamera;
    [SerializeField]ShootByTime_Script shootByTime_;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Camera!");
        MainCamera= Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) ShotRay(Input.mousePosition);
    }
    void ShotRay(Vector2 mouse)
    {
        Debug.Log("mouse："+mouse);
        Ray cameraToRay = MainCamera.ScreenPointToRay(mouse);
        RaycastHit hitInfo = new RaycastHit();
        if (Physics.Raycast(cameraToRay, out hitInfo))
        {
            //m_object.transform.position = hitInfo.point;
            Debug.Log("わーい");
            Debug.Log("場所："+hitInfo.point);
            shootByTime_.Fire(hitInfo.point);
        }
    }
}
