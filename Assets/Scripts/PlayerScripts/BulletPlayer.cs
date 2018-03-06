using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletPlayer : MonoBehaviour {

    // Use this for initialization
    public float bulletspeed = 10f;
	void Start () {
        this.GetComponent<Rigidbody2D>().velocity = new Vector3(0, bulletspeed, 0);
	}
	
	// Update is called once per frame
	void Update () {
        if (transform.position.y > 8) {
            Destroy(gameObject);
        }
	}
}
