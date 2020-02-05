using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class missileDespawn1 : MonoBehaviour
{
    GameObject ship;
    // Start is called before the first frame update
    void Start()
    {
        ship = GameObject.Find("moveForwardThingy");
    }

    // Update is called once per frame
    void Update()
    {
        if (this.transform.position.z > ship.transform.position.z + 200)
        {
            Destroy(gameObject);
            Debug.Log("Deleted Missile");
        }

    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("d" + collision.gameObject.tag);
        Destroy(gameObject);
    }

}
