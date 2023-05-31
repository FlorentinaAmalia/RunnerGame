using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*public class ObstacleCollision : MonoBehaviour
{
    public GameObject thePlayer;
    public GameObject charModel;
    public AudioSource crashFall;
    public GameObject mainCamera;
    public GameObject levelControl;

    void OnTriggerEnter(Collider other)
    {
        this.gameObject.GetComponent<BoxCollider>().enabled = false;
        thePlayer.GetComponent<PlayerMove>().enabled = false;
        charModel.GetComponent<Animator>().Play("Stumble");
        levelControl.GetComponent<LevelDistance>().enabled = false;
        crashFall.Play();
        mainCamera.GetComponent<Animator>().enabled = true;
        levelControl.GetComponent<EndRunSequence>().enabled = true;
    }
}*/

public class ObstacleCollision1 : MonoBehaviour
{
    public Rigidbody thePlayer; // Change GameObject to Rigidbody
    public GameObject charModel;
    public AudioSource crashFall;
    //public GameObject mainCamera;
    public GameObject levelControl;

    void OnCollisionEnter(Collision other)
    {
        this.gameObject.GetComponent<BoxCollider>().enabled = false;
        thePlayer.GetComponent<PlayerMovement>().enabled = false;


        thePlayer.velocity = Vector3.zero; // Set the player's velocity to zero to stop movement
        thePlayer.angularVelocity = Vector3.zero; // Set the player's angular velocity to zero to stop rotation
        thePlayer.isKinematic = true; // Make the player's Rigidbody kinematic to prevent external forces from affecting it


        charModel.GetComponent<Animator>().Play("Stumble");
        //levelControl.GetComponent<LevelDistance>().enabled = false;
        crashFall.Play();
        //mainCamera.GetComponent<Animator>().enabled = true;
        levelControl.GetComponent<EndRunSequence>().enabled = true;

        // Apply forces to the player
        thePlayer.AddForce(Vector3.up * 10f, ForceMode.Impulse);
        thePlayer.AddForce(-thePlayer.transform.forward * 5f, ForceMode.Impulse);
    }
}
