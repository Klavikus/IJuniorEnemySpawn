using UnityEngine;

public class SimpleMover : MonoBehaviour
{
    [SerializeField] private Vector3 _speed;

    private void Update()
    {
        transform.position += _speed * Time.deltaTime;
    }
}