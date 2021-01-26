using UnityEngine;

public class Cursorlock : MonoBehaviour
{

   void Start()
    {
        //Set Cursor to not be visible
        Cursor.visible = false;
    }
	
    void Update()
    {
        //Press the space bar to apply no locking to the Cursor
        if (Input.GetKey(KeyCode.E))
            Cursor.lockState = CursorLockMode.None;
			 if (Input.GetKey(KeyCode.Escape))
            Cursor.lockState = CursorLockMode.None;
    }

    void OnGUI()
    {
        //Press this button to lock the Cursor
        if (GUI.Button(new Rect(0, 0, 100, 50), "Lock Cursor"))
        {
            Cursor.lockState = CursorLockMode.Locked;
        }


    }
}