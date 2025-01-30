using UnityEngine;

public class SimpleTransformController : MonoBehaviour
{
    private void Update()
    {
        var x = Mathf.PingPong(Time.time, 4);
        var p = new Vector3(0, x, 0);
        transform.position = p;

        transform.Rotate(new Vector3(0, 15, 5) * Time.deltaTime);
        var o = Mathf.PingPong(Time.time, 2); transform.position = new Vector3(o, 0, 0);
    }
}