using UnityEngine;
using UnityEditor;

public class ShipControl : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody dis;
    public GameObject missle;
    public GameObject explosion;
    int cooldownR = 0;
    int cooldownL = 0;
    static int lives = 3;
    float time;
    void Start()
    {
        dis = this.GetComponent<Rigidbody>();
        time = Time.time;
    }

    // Update is called once per frame
    void Update()
    {

        TextMesh textObject2 = GameObject.Find("timealive").GetComponent<TextMesh>();
        if (lives > 0)
        {
            textObject2.text = "Time Alive: " + Mathf.Round(Time.time - time);
        }

        var velVec = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0) * 3f;
        Debug.Log("vel"+ velVec);
        if (Mathf.Abs(this.transform.position.x) - 5 > 0)
        {
          //  Debug.Log("XVel");
            velVec.x = (Mathf.Abs(this.transform.position.x) - 5) * -50 * (this.transform.position.x / Mathf.Abs(this.transform.position.x));
        }
        if (Mathf.Abs(this.transform.position.y - 1) - 2.5 > 0)
        {
            //Debug.Log("YVel");
            velVec.y = (Mathf.Abs(this.transform.position.y - 1) - 2.5f) * -50 * (this.transform.position.y - 1 / Mathf.Abs(this.transform.position.y - 1));
        }
        dis.velocity = velVec;
        //Debug.Log("vel2" + velVec);
        //Debug.Log(Input.GetAxis("Fire1"));
        cooldownR--;
        cooldownL--;

        if (Input.GetAxis("Fire1") == 1 && cooldownR <= 0)
        {
            Instantiate(missle, new Vector3(transform.position.x + .5f, transform.position.y, transform.position.z - 1.4f), transform.rotation);
            cooldownR = 10;
        }
        if (Input.GetAxis("Fire1") == -1 && cooldownL <= 0)
        {
            Instantiate(missle, new Vector3(transform.position.x - .5f, transform.position.y, transform.position.z - 1.4f), transform.rotation);
            cooldownL = 10;
        }

        //Debug.Log();
    }

    private void OnTriggerEnter(Collider other)
    {

        //Check for a match with the specific tag on any GameObject that collides with your GameObject
        if (other.gameObject.tag == "obs")
        {
            //If the GameObject has the same tag as specified, output this message in the console
            Debug.Log("OOF");
            Instantiate(explosion, new Vector3(transform.position.x, transform.position.y, transform.position.z + 24), transform.rotation); 
            lives--;
            TextMesh textObject = GameObject.Find("lives").GetComponent<TextMesh>();
            if (lives > 0)
            {   
                textObject.text = "Lives: " + lives;
            }
            else
            {
                textObject.text = "GAMEOVER";

                gameObject.SetActive(false);

                Invoke("donezo", 10);
                
            }

        }

    }

    void donezo()
    {
        //UnityEditor.EditorApplication.isPlaying = false;
        Application.Quit();
    }
}