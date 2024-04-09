using UnityEngine;

public class Purposes : MonoBehaviour
{
    [SerializeField] private Transform[] _moverPoints;
    [SerializeField] private float _speed;

    private int _currentPoint = 0;    
    
    private void Update()
    {
        if (transform.position == _moverPoints[_currentPoint].position)
        {
            _currentPoint = (_currentPoint + 1) % _moverPoints.Length;
        }

        transform.position = Vector3.MoveTowards(transform.position, _moverPoints[_currentPoint].position, _speed * Time.deltaTime);        
    }
}
