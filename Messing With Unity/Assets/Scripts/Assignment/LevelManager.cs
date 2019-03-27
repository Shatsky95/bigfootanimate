using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour{
    public GameObject CurrentCheckPoint;
    private Rigidbody2D pcRigid;
    private GameObject player;

    //particles 
    public GameObject deathParticle;
    public GameObject respawnParticle;

    //respawn delay
    public float respawnDelay;

    //point penalty on death 
    public int pointPenaltyOnDeath;

    //store gravity value
    private float gravityStore;


    // Start is called before the first frame update
    void Start(){
        pcRigid = GameObject.Find("player").GetComponent<Rigidbody2D>();
        player = GameObject.Find("player");
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
