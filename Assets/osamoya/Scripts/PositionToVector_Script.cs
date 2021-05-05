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
    [SerializeField] ShootBullet_Script shootBullet_;
    [SerializeField] float gravity = 9.8f;
    [SerializeField] GameObject StartObj;
    [SerializeField] GameObject TargetObj;
    Vector3 StartPoint;
    Vector3 TargetPoint;
    float HoriDistance;
    float tan;

    [SerializeField] float reachTime;
    [SerializeField] Vector3 arg;//角度のベクトル
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
        if (Input.GetKeyDown(KeyCode.Space)) shot();
    }
    Vector3 calcAngle() { return calcAngle(StartPoint, TargetPoint); }
    Vector3 calcAngle(Vector3 start,Vector3 target)
    {
        target -= start;//原点に飛ばしてあげる
        tan = target.y + gravity * reachTime * reachTime;//角度が出るはず
        HoriDistance = calcDistance(target.x, target.z);
        float AngleY = tan * HoriDistance;
        Vector3 angle = new Vector3(target.x, AngleY, target.z);
        Debug.Log("方向："+angle);
        arg = angle.normalized;
        return arg;
    }

    float calcDistance(float x,float y)
    {
        return Mathf.Sqrt(x*x+y*y);
    }

    void shot()
    {
        shootBullet_.shot(StartPoint,calcAngle(),calcForce());
        
    }
    float calcForce()
    {
        return force*HoriDistance/reachTime/calcCos();
    }
    
    float calcCos()
    {
        return Mathf.Cos(Mathf.Atan(tan));
    }
}
