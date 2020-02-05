using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyExplos : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("goaway", 7);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void goaway()
    {
        Debug.Log("ASDASDAS");
        Destroy(this.gameObject);
    }
}
