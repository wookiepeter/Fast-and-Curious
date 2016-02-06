using UnityEngine;
using System.Collections;

public class EnemyController : MonoBehaviour {
    public float live;
    public float attack;
    public float attacktime;
    public float maxspeed;
    public int mode; //0 - Random Movement || 1 - Folgt dem Spieler
    public GameObject bullet;
    public GameObject verfolgen;
    public float acceleration;

    private Vector3 target;
    private Vector3 speed;
    private Rigidbody rigid;
	// Use this for initialization
	void Start () {
        rigid = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        speed = new Vector3(rigid.velocity.x, 0, rigid.velocity.z);
        if(speed.magnitude > maxspeed)
        {
            rigid.velocity = speed.normalized* maxspeed;
        }

        target = rigid.position;

        rigid.AddForce(transform.up * acceleration);
	    
	}
}
