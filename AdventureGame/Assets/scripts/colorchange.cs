using UnityEngine;

public class colorchange : MonoBehaviour
{
    public Color newColor = Color.blue;

    private void OnCollisionEnter(Collision collision)
    {
        GetComponent<Renderer>().material.color = newColor;
    }

}
