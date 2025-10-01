using UnityEngine;

public class ForwardMove : MonoBehaviour
{
    private Vector3 nextDirection;
    private void Update()
    {
        float speed = 0.001f;

        nextDirection.z += speed;
        transform.Translate(nextDirection, Space.Self);
    }
}
