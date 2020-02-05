using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class missleGoForward : MonoBehaviour
{
    Rigidbody dis;
    GameObject ship;
    

    // Start is called before the first frame update
    void Start()
    {
        dis = this.GetComponent<Rigidbody>();
        ship = GameObject.Find("moveForwardThingy");
        dis.velocity = Vector3.forward * (float)(100 + goForward.count*100);
        Debug.Log(ship.GetComponent<Rigidbody>().velocity);
        Debug.Log(goForward.count);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        dis.AddForce(Vector3.forward * (float)(5+ goForward.count * 60), ForceMode.Force);
        //Debug.Log(dis.velocity);
    }
}
