using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Purposes _purpose;
    [SerializeField] private float _speed;

    private void Update()
    {       
        var direction = (_purpose.transform.position - transform.position).normalized;
        
        //transform.LookAt(_purpose.transform);
        transform.Translate(direction * _speed);
    }

    public void Direction(Purposes purpose)
    {
        _purpose = purpose;
    }
}
