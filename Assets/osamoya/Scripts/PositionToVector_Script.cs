using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// ・弾は放物線を描いて飛ぶ
/// ・放物線の２点は指定できるようにする
/// ・放物線の形を変えることができる
/// 　　→要素は：速さ・角度と時間
/// </summary>
public class PositionToVector_Script : MonoBehaviour
{
    [SerializeField] float gravity = 9.8f;
    [SerializeField] GameObject StartObj;
    [SerializeField] GameObject TargetObj;
    Vector3 StartPoint;
    Vector3 TargetPoint;

    [SerializeField] float reachTime;
    [SerializeField] float arg;//上向きの角度(xz_y)
    [SerializeField] float force;
    
    // Start is called before the first frame update
    void Start()
    {
        if (StartObj != null) StartPoint = StartObj.transform.position;
        if (TargetObj != null) TargetPoint = TargetObj.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    
    
}
