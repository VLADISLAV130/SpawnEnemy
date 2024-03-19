using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Enemy _spawnObject;
    [SerializeField] private Transform[] _spawnPoints;
    [SerializeField] private Vector3 _movementDirection;

    private float _delay = 2f;
    private int _minRandomSpawnPoints = 0;

    private void Start()
    {
       StartCoroutine(Spawn());
    }    

    private void CreateEnemy()
    {
        int _direction = Random.Range(0, 360);
        _spawnObject.transform.position = _spawnPoints[Random.Range(_minRandomSpawnPoints, _spawnPoints.Length)].position;

        var enemy = Instantiate(_spawnObject, _spawnObject.transform.position, Quaternion.Euler(0, 0, _direction));
        enemy.Direction(_movementDirection);
    }

    private IEnumerator Spawn()
    {
        while (true)
        {
            CreateEnemy();             
            yield return new WaitForSeconds(_delay);
        }
    }
}
