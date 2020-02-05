using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goForward : MonoBehaviour
{
    public static double count = 0;
    // Start is called before the first frame update
    void Start()
    {
        //GameObject.Find("moveForwardThingy").GetComponent<Rigidbody>().velocity = -1* Vector3.forward;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        count += .001;
        this.transform.position += Vector3.forward * (float)(1+ count) ;
        //Debug.Log(count);
    }
}
