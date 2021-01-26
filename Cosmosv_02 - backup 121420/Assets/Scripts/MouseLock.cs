using UnityEngine;
using UnityEngine.UI;

public class MouseLock : MonoBehaviour
{
    Button bt;
    bool wasLocked = false;

    void Start()
    {
        bt = GetComponent<Button>();
    }

    // Called when the cursor is actually being locked

    void DidLockCursor()
    {
        Debug.Log("Locking cursor");

        // Disable the button
        bt.enabled = false;
    }

    // Called when the cursor is being unlocked
    // or by a script calling Screen.lockCursor = false;
    void DidUnlockCursor()
    {
        Debug.Log("Unlocking cursor");

        // Show the button again
        bt.enabled = true;
    }

    void OnMouseDown()
    {
        // Lock the cursor
        Screen.lockCursor = true;
    }

    void Update()
    {
        // In standalone player we have to provide our own key
        // input for unlocking the cursor
        if (Input.GetKeyDown("escape"))
            Screen.lockCursor = false;

        // Did we lose cursor locking?
        // eg. because the user pressed escape
        // or because they switched to another application
        // or because some script set Screen.lockCursor = false;
        if (!Screen.lockCursor && wasLocked)
        {
            wasLocked = false;
            DidUnlockCursor();
        }
        // Did we gain cursor locking?
        else if (Screen.lockCursor && !wasLocked)
        {
            wasLocked = true;
            DidLockCursor();
        }
    }
}