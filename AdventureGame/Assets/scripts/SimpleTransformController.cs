using UnityEngine;

public class SimpleTransformController : MonoBehaviour
{
    private void Update()
    {
        var x = Mathf.PingPong(Time.time, 4);
        var p = new Vector3(0, x, 0);
        transform.position = p;

        transform.Rotate(new Vector3(0, 25, 15) * Time.deltaTime);
    }
}