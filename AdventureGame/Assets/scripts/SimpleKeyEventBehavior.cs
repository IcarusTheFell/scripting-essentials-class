using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SimpleKeyEventBehaviour : MonoBehaviour
{
    public UnityEvent keyEvent;
    public KeyCode triggerKey = KeyCode.Space;

    void Update()
    {
        if (Input.GetKeyDown(triggerKey))
        {
            keyEvent.Invoke();
        }
    }
}