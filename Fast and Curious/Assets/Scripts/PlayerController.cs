using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
    public float acceleration;
    public float steering;
    public float brake;
    public float maxSpeed;

    private Rigidbody rigid;
    private float direction;
    private Vector3 speed;
	// Use this for nitialization
	void Start () {
        rigid = GetComponent<Rigidbody>();
        direction = transform.rotation.y;
	}
	
	// Update is called once per frame
	void Update () {
        if (speed.magnitude > maxSpeed)
        {
            rigid.velocity = speed.normalized * maxSpeed;
        }

        if (Input.GetKey("up"))
        {
            rigid.AddForce(transform.up * acceleration);
        }
        else if(Input.GetKey("down"))
        {
            
            rigid.AddForce(transform.up * brake);
        }

        if(Input.GetKey("left"))
        {
            transform.Rotate(Vector3.forward , steering);
        }
        else if(Input.GetKey("right"))
        {
            transform.Rotate(Vector3.forward, -steering);
        }

        
	}

    void FixedUpdate()
    {
        speed = new Vector3(rigid.velocity.x,0, rigid.velocity.z);
    }
}
