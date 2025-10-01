using UnityEngine;

public class Move : MonoBehaviour
{
    private Vector3 nextDirection;
    void Update()
    {
        nextDirection.z += 0.001f;
        transform.Translate(nextDirection, Space.Self);
    }
}
