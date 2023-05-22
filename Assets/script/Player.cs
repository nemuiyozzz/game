using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float _movespeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            this.transform.Translate(0,_movespeed * Time.deltaTime,0);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            this.transform.Translate(0,-_movespeed * Time.deltaTime,0);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            this.transform.Translate(_movespeed * Time.deltaTime, 0, 0);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            this.transform.Translate(-_movespeed * Time.deltaTime, 0, 0);
        }
    }
}
