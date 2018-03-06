using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDestroy : MonoBehaviour {

    // Use this for initialization
    public GameObject explosion;
    public GameObject playerExplosion;
    private GameController gameController;
    public int scorevalue=10;

    void Start()
    {
        GameObject gameControllerObject = GameObject.FindWithTag("GameController");
        if (gameControllerObject != null)
        {
            gameController = gameControllerObject.GetComponent<GameController>();
        }
        if (gameController == null)
        {
            Debug.Log("Cannot find 'GameController' script");
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Boundary")
        {
            Destroy(gameObject);
            gameController.AddScore(-10);

        }

        //Instantiate(explosion, transform.position, transform.rotation);
        if (collision.tag == "PlayerBullet")
        {
            Instantiate(playerExplosion, collision.transform.position, collision.transform.rotation);
            gameController.AddScore(10);
            Destroy(collision.gameObject);

            Destroy(gameObject);
           
        }
    }

}
