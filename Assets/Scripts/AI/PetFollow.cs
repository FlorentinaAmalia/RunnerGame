using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PetFollow : MonoBehaviour
{
    public NavMeshAgent pet;
    public Transform player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        pet.SetDestination(player.position);
    }
}
