using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShot : MonoBehaviour {

    // Use this for initialization

    public GameObject shot;
    public Transform shotSpawn;
    public float fireRate;
    public float delay;


    void Start()
    {
        InvokeRepeating("Fire", delay, fireRate);
    }

    void Fire()
    {
        Instantiate(shot, shotSpawn.position, shotSpawn.rotation);
    
    }
 

}

