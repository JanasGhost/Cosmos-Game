using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowTextUI : MonoBehaviour
{

public GameObject UiObject;
public GameObject cube;


    void Start()
   {
	UiObject.SetActive(false);

    }

void OnTriggerEnter(Collider other)

{

if(other.tag == "Player")
{

UiObject.SetActive(true);

}

}

    void Update()
    {


 }

void OnTriggerExit(Collider other)

{

UiObject.SetActive(false);
Destroy(cube);

}

}
