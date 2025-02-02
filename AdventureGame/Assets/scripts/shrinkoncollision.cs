using UnityEngine;

public class shrinkoncollision : MonoBehaviour
{
    public float shrinkfactor = 0.95f;

    private void OnCollisionEnter(Collision collision)
    {
        transform.localScale *= shrinkfactor;
    }

}
