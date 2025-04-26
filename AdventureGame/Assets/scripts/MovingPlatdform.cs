using UnityEngine;

public class SimplePlatformMover : MonoBehaviour
{
    public float speed = 2f;
    public float distance = 3f;

    private Vector3 startPos;

    private void Start()
    {
        startPos = transform.position;
    }

    private void Update()
    {
        float movement = Mathf.PingPong(Time.time * speed, distance);
        transform.position = startPos + Vector3.right * movement;
    }
}
