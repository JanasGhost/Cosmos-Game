using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObject : MonoBehaviour
{

public GameObject cube;


    // Start is called before the first frame update
    void Start()
    {
        
    }

void OnTriggerEnter (Collider other)

{

if(other.tag == "Player")

{

Destroy(cube); 
	}
		}

    // Update is called once per frame
    void Update()
    {
        
    }
}
