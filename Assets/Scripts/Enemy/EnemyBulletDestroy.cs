using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBulletDestroy : MonoBehaviour {

    // Use this for initialization
    public GameObject enemybullet;
    public float lifetime = 10;
	void Start () {
        Invoke("Destroy", lifetime);
	}
	
	// Update is called once per frame
	void Destroy () {
        Destroy(enemybullet);
	}
}
