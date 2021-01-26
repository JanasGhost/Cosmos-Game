using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cursorhide : MonoBehaviour {

public bool cursorLocked; 

 // Use this for initialization
 void Start () {
  
 }
 
 // Update is called once per frame
 void Update () {

        if(cursorLocked == true) {
            Cursor.visible = false;
         
        }   else if (cursorLocked == false) {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
       
        }
  
 }
}