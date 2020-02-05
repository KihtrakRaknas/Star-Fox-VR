using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class despawn : MonoBehaviour
{
    GameObject ship;
    public GameObject explosion;
    float x;
    float y;
    float z;
    // Start is called before the first frame update
    void Start()
    {
        ship = GameObject.Find("moveForwardThingy");
        x = Random.Range(-1, 1);
        y = Random.Range(-1, 1);
        z = Random.Range(-1, 1);
    }

    // Update is called once per frame
    void Update()
    {
        if (this.transform.position.z+200 < ship.transform.position.z)
        {
            Destroy(gameObject);
        }
            
    }

    private void FixedUpdate()
    {
        this.transform.Rotate(x, y, z, Space.Self);
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("ONTRIG");
        Instantiate(explosion, new Vector3(transform.position.x, transform.position.y, transform.position.z), transform.rotation);
        Destroy(gameObject);
        Debug.Log("DEAD");
    }

}
