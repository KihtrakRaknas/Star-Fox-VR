using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnObs : MonoBehaviour
{
    public GameObject obstacle1;
    public GameObject obstacle2;
    public GameObject obstacle3;
    public GameObject obstacle4;
    public GameObject obstacle5;
    public GameObject obstacle6;
    public GameObject obstacle7;
    public GameObject obstacle8;
    public GameObject obstacle9;

    int i = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        i++;
        var relitiveVector = new Vector3(Random.Range(-500, 500), Random.Range(-500, 500), 1000);
        var relitiveVector2 = new Vector3(Random.Range(-10, 10), Random.Range(-10, 10), 1000);
        var obs = obstacle1;
        int rand = (int)Random.Range(0, 9);
        if (rand == 1)
            obs = obstacle2;
        else if (rand == 2)
            obs = obstacle3;
        else if (rand == 3)
            obs = obstacle4;
        else if (rand == 4)
            obs = obstacle5;
        else if (rand == 5)
            obs = obstacle6;
        else if (rand == 6)
            obs = obstacle7;
        else if (rand == 7)
            obs = obstacle8;
        else if (rand == 8)
            obs = obstacle9;
        if (i % 20 == 0)
        {


            Instantiate(obs, this.transform.position + relitiveVector2 + Vector3.forward * 10, this.transform.rotation);


        }
        else if(i % 2 == 1)
        {
            Instantiate(obs, this.transform.position + relitiveVector + Vector3.forward * 10, this.transform.rotation);


        }
    }
}
