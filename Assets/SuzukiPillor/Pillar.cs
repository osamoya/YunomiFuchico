using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pillar : MonoBehaviour
{
   
    [SerializeField] float XMoveSpeed;//回転速度(球当たると変化)
    [SerializeField] float YMoveSpeed;//回転速度(すり鉢回転)
    [SerializeField] float CoolTime;//自動傾きが始まる時間
    [SerializeField] private float PillarAngle;//茶柱の現在の角度
    [SerializeField] string BallTag;//球のタグ
    float time=0;

    public float GetAngle()
    {
        PillarAngle = transform.eulerAngles.x;
        return PillarAngle;
    }//角度Xのゲッタ

    void PillarMove(float i)
    {
        if (i > 0 && transform.eulerAngles.x >= 0&& transform.eulerAngles.x <100)
        {
            transform.Rotate(new Vector3(XMoveSpeed * i, 0, 0));
        }

        if (i < 0 && transform.eulerAngles.x < 90 &&  transform.eulerAngles.x > 0)
        {
            transform.Rotate(new Vector3(XMoveSpeed * i, 0, 0));
            Debug.Log("1");
        }
        if (i < 0  && transform.eulerAngles.x < 0)
        {
            transform.Rotate(new Vector3(XMoveSpeed * -i, 0, 0));
            Debug.Log("2");
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == BallTag)//ここに球のタグ入れてください
        {
            PillarMove(1);
            Debug.Log("接触！");
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.localEulerAngles += new Vector3(0, YMoveSpeed, 0);
        
        if(transform.eulerAngles.x >= 180)
        {
            Debug.Log("成功");
        }
        
        if (time > CoolTime)
        {
            PillarMove(-0.5f);
            time = 0;
            
        }
        time += Time.deltaTime;
        //Debug.Log(time);
    }
}
