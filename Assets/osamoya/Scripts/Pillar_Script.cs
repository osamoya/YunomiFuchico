using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pillar_Script : MonoBehaviour
{
    //[SerializeField]GameObject pillar;
    [SerializeField] float Yspeed;
    [SerializeField] float Xspeed;

    float coolTime=0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.localEulerAngles += new Vector3(0, Yspeed, 0);

        if (Input.GetKeyDown(KeyCode.Z))
        {
            PillarRote(1);
            coolTime = 0;
        }
        else
        {
            coolTime += Time.deltaTime;
        }
        if (coolTime > 3) PillarRote(-0.5f);
    }

    public void PillarRote(float i)
    {
        
        if (i>0&&transform.eulerAngles.x>0)
        {
            transform.Rotate(new Vector3(Xspeed * i, 0, 0));
        }

        if (i<0&&transform.eulerAngles.x<90)
        {
            transform.Rotate(new Vector3(Xspeed * i, 0, 0));
        }
    }
}
