using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootByTime_Script : MonoBehaviour
{
    [SerializeField] GameObject Bullet;
    [SerializeField] GameObject StartPos;
    //[SerializeField] GameObject TargetPos;
    [SerializeField] float reachTime=1.0f;
    public Vector3 TargetV;
    Vector3 V0 = new Vector3(0,0,0);//初速

    // Start is called before the first frame update
    void Start()
    {
      //  TargetV = TargetPos.transform.position;   
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            Debug.Log("z検出");
            calcVelocity();
            
            shot();
        }
    }
    public void Fire(Vector3 target)
    {
        Debug.Log("target:"+target);
        TargetV = target;
        calcVelocity();
        shot();
    }

    void calcVelocity()
    {
        //Vector3 deltaVector = TargetPos.transform.position-StartPos.transform.position;
        Vector3 deltaVector = TargetV - StartPos.transform.position;
        V0.x = deltaVector.x / reachTime;
        V0.z = deltaVector.z / reachTime;

        V0.y = (deltaVector.y - Physics.gravity.y * reachTime * reachTime/2)/reachTime;
        
    }

    void shot()//実際に撃つやつ
    {
        GameObject newBullet = Instantiate(Bullet);
        newBullet.transform.position = StartPos.transform.position;
        //Debug.Log("new.pos："+ newBullet.transform.position);
        newBullet.GetComponent<Rigidbody>().velocity = V0;//初速を与える
        //Debug.Log("new.velocity：" + newBullet.GetComponent<Rigidbody>().velocity);
    }
}
