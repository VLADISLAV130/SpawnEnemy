using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Vector3 _movementDirection;

    private void Update()
    {
        transform.Translate(_movementDirection * Time.deltaTime);
    }

    public void Direction(Vector3 movementDirection)
    {
        _movementDirection = movementDirection;
    }
}
