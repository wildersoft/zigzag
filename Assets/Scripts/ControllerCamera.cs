using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerCamera : MonoBehaviour
{
    public GameObject player;
    public Vector3 posIni;

    // Start is called before the first frame update
    void Start()
    {
        posIni = this.transform.position - player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = player.transform.position + posIni;
    }
}