using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDestroy : MonoBehaviour {

    public GameObject explosion;
    public GameObject playerExplosion;


    private void OnTriggerEnter2D(Collider2D collision)
    {
     
        if (collision.tag == "Bullet")
        {
            Instantiate(playerExplosion, collision.transform.position, collision.transform.rotation);
            Destroy(collision.gameObject);
             Destroy(gameObject);
        }
        if (collision.tag == "Enemy")
        {
            Instantiate(playerExplosion, collision.transform.position, collision.transform.rotation);
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }


    }
}
