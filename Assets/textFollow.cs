using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class textFollow : MonoBehaviour
{
    public Transform target;
    public GameObject location;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.rotation = location.transform.rotation;

        var vec = transform.position + (location.transform.position- transform.position)/50;// * 20 * Time.deltaTime;
        while (Mathf.Sqrt(vec.x * vec.x + vec.z * vec.z) > 50)
        {
            if (vec.x < vec.z)
                vec.z = vec.z - .01f;
            else
                vec.x = vec.x - .01f;
        }
        vec.y = 30;
        transform.position = vec;
    }
}
