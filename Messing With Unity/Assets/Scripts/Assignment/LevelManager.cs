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
        pcRigid = GameObject.Find("Player").GetComponent<Rigidbody2D>();
        player = GameObject.Find("Player");
        
    }
    public void RespawnPlayer(){
        StartCoroutine ("RespawnPlayerCo");
    }
    public IEnumerator RespawnPlayerCo(){
        // Generate Death Particle 
        Instantiate (deathParticle, pcRigid.transform.position, pcRigid.transform.rotation);
        //HIde Pc 
        player.SetActive(false);
        pcRigid.GetComponent<Renderer> ().enabled = false;
        //gravity reset
        gravityStore = pcRigid.GetComponent<Rigidbody2D>().gravityScale;
        pcRigid.GetComponent<Rigidbody2D>().gravityScale = 0f;
        pcRigid.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        //point penalty
        ScoreManager.AddPoints(-pointPenaltyOnDeath);
        //debug message
        Debug.Log ("PC Respawn");
        //Respawn Delay
        yield return new WaitForSeconds (respawnDelay);
        //gravity restore
        pcRigid.GetComponent<Rigidbody2D>().gravityScale = gravityStore;
        //match pcs transform positon
        pcRigid.transform.position = CurrentCheckPoint.transform.position;
        //show pc
        player.SetActive(true);
        pcRigid.GetComponent<Renderer> ().enabled = true;
        //spawn PC
        Instantiate (respawnParticle, CurrentCheckPoint.transform.position, CurrentCheckPoint.transform.rotation);
    
        

    }
    // Update is called once per frame
}
