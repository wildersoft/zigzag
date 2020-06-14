using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float force;
    public bool changeDir = false;
    public Vector3 dir;
    public Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
        dir = new Vector3(0, 0, 0);
        //rb.ad
    }

    // Update is called once per frame
    void Update()
    {
        //if( transform.position.y <-3)
        //{
        //    this.transform.position = new Vector3(0, 3, 2);
        //    rb.Sleep();
        //    dir = new Vector3(0, 0, 0);
        //}

        if (Input.GetMouseButtonDown(0))
        {
            rb.Sleep();
            if (changeDir)
            {
                dir = new Vector3(-1, 0, 0);
                changeDir = false;
            }
            else
            {
                dir = new Vector3(0, 0, -1);
                changeDir = true;
            }
        }

        if(Input.GetMouseButtonDown(1))
        {
            rb.Sleep();
            if (changeDir)
            {
                dir = new Vector3(1, 0, 0);
                changeDir = false;
            }
            else
            {
                dir = new Vector3(0, 0, 1);
                changeDir = true;
            }
        }
    }

    public void FixedUpdate()
    {
        rb.MovePosition(transform.position + dir * Time.deltaTime * force);
    }
}