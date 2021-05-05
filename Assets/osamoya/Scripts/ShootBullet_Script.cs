using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootBullet_Script : MonoBehaviour
{
    [SerializeField] GameObject bullet;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void shot(Vector3 start,Vector3 angle,float force)
    {
        GameObject b=Instantiate(bullet);
        b.transform.position = start;
        b.GetComponent<Rigidbody>().AddForce(angle*force);
    }
}
