using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
    public float acceleration;
    public float steering;
    public float brake;
    public float maxSpeed;

    private Rigidbody rigid;
    private float direction;
    private float speed;
    private Vector2 MovingDirection;
	// Use this for nitialization
	void Start () {
        rigid = GetComponent<Rigidbody>();
        direction = transform.rotation.y;
        MovingDirection = new Vector2(1, 0);
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButton("Vertical") && speed < maxSpeed)
        {
            rigid.AddForce(MovingDirection * acceleration);
        }
	}

    void FixedUpdate()
    {
        speed = new Vector2(rigid.velocity.x, rigid.velocity.z).magnitude;
        direction = transform.rotation.y;
    }
}
