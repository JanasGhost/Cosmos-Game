using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateObject : MonoBehaviour
{

public Transform Spawnpoint;
public Rigidbody Prefab;
public GameObject cube;
  
    void OnTriggerEnter(Collider other)
    {
       
 Instantiate(Prefab, Spawnpoint.position, Spawnpoint.rotation);

    }

void OnTriggerExit(Collider other)

{

Destroy(cube);

}

}
