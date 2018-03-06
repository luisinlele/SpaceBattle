using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    // Use this for initialization

    public float speed = 5f;
    public float padding = 1f;
    public GameObject bullet;

    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        // Movimiento horizontal
        float hInput = Input.GetAxis("Horizontal");
        transform.position += new Vector3(hInput * speed * Time.deltaTime, 0, 0);

        // Movimiento vertical
        float vInput = Input.GetAxis("Vertical");
        transform.position += new Vector3(0, vInput * speed * Time.deltaTime, 0);

        // Rectificaicon
        float newX = Mathf.Clamp(transform.position.x, -10 + padding, 10 - padding);
        float newY = Mathf.Clamp(transform.position.y, -10 + padding, 10 - padding);
        transform.position = new Vector3(newX, newY, transform.position.z);
        //Disparo
        if (Input.GetKeyDown(KeyCode.Space))
        {

            var playership = GameObject.Find("PlayerShip");
            if (playership != null) {
                Vector3 newPosition = playership.transform.position;
                Instantiate(bullet, newPosition*1f, Quaternion.identity);
            }
        }
    }


}
