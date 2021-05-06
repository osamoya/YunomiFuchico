using System.Collections;
using System.Collections.Generic;
using UnityEngine;


    public enum STEP
    {
        NONE = -1,
        SET,
        PLAY,
    }

    private STEP step;
    private STEP next_step;
    public float speed = 6.0f;
    public float angle = 360.0f / 8.0f;


    void Start()
    {
        next_step = STEP.SET;
    }


    void Update()
    {
        step_timer += Time.deltaTime;
        if(next_step != STEP.NONE)
        {
            step = next_step;
            next_step = STEP.NONE;
            step_timer = 0.0f;
            switch (step)
            {
                case STEP.SET:
                    next_step = STEP.PLAY;
                    break;
            }
        }


        switch (step)
        {
            case STEP.PLAY:
                Vector3 pos = transform.position;
                pos += transform.right * speed * Time.deltaTime;
                transform.position = pos;

                Vector3 ang = transform.eulerAngles;
                if (Input.GetKeyButtonDown(D))
                {
                    ang.z += angle;
                }
                transform.eulerAngles = ang;

                Vector3 ang = transform.eulerAngles;
                if (Input.GetKeyMouseButtonDown(A))
                {
                     ang.z -= angle;
                 }
                 transform.eulerAngles = ang

                    break;
        }
    }


}

                break;
        }
    }



