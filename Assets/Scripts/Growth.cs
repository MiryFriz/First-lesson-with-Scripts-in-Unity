using UnityEngine;

public class Growth : MonoBehaviour
{
    [SerializeField] private float _speed;

    void Update()
    {
        Vector3 currentScale = transform.localScale;
        var newScale = new Vector3(currentScale.x + _speed, currentScale.y + _speed, currentScale.z + _speed);

        transform.localScale = newScale;
    }
}
