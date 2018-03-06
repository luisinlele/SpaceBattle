using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {

    // Use this for initialization
    public float speed=1;

    void Update()
    {
       
        transform.position += new Vector3(0, -1* speed * Time.deltaTime, 0);
       

    }
}
