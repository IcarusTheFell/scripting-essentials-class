using UnityEngine;
using UnityEngine.Events;

public class SimpleTriggerEventBehaviourScript : MonoBehaviour
{
    public UnityEvent triggerEvent;

    private void OnTriggerEnter(Collider other)
    {
        triggerEvent.Invoke();
    }
}
