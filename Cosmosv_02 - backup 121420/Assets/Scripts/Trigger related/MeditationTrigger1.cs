using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeditationTrigger1 : MonoBehaviour
{
  
    public AudioSource playSound;
	
	void OnTriggerEnter(Collider other)
{

playSound.Play();

}

void OnTriggerExit(Collider other)

{
playSound.Stop();
}

}
