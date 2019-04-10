using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour{
    public float speed;
    public float timeOut;
    public GameObject player;
    public GameObject enemyDeath;
    public GameObject projectileParticle;
    public int pointsForKill;

    // Start is called before the first frame update
    void Start(){
        player = GameObject.Find("Player");

        enemyDeath = Resources.Load("Prefabs/PS") as GameObject;
        projectileParticle = Resources.Load("Prefabs/PS") as GameObject;
        if(player.transform.localScale.x < 0)
            speed = -speed;

            //destroys projectile after x seconds
            Destroy(gameObject,timeOut);

        
    }

    // Update is called once per frame
    void Update(){
        GetComponent<Rigidbody2D>().velocity = new Vector2(speed, GetComponent<Rigidbody2D>().velocity.y);
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        //destroys enemy on contact with projectile. adds points
        if(other.tag == "Enemy"){
            Instantiate(enemyDeath, other.transform.position, other.transform.rotation);
            Destroy (other.gameObject);
            ScoreManager.AddPoints (pointsForKill);

            //instantiate (ProjectileParticle, transform.position, transform.rotation)
            //Destroy projectile after hitting the enemy
            Destroy (gameObject);

        }
    }
    void OnCollisionEnter2D(Collision2D other){
        Instantiate(projectileParticle, transform.position, transform.rotation);
        Destroy (gameObject);
    
    
        
    }
}
