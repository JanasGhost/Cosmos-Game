﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI; 

public class Follow : MonoBehaviour
{


private NavMeshAgent Mob; 

public GameObject Player;

public float MobDistanceRun = 2.0f;


    // Start is called before the first frame update
    void Start()
    {
        Mob = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        
float distance = Vector3.Distance(transform.position, Player.transform.position);

if (distance < MobDistanceRun)

{

Vector3 dirToPlayer = transform.position - Player.transform.position;

Vector3 newPos = transform.position - dirToPlayer;

Mob.SetDestination(newPos);

}

    }
}
