using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject _spawnObject;
    [SerializeField] private Transform[] _spawnPoints;

    private float _timeBetweenSpawns = 2f;
    private int _minRandomSpawnPoints = 0;

    private void Start()
    {
       StartCoroutine(Spawn());
    }    

    private IEnumerator Spawn()
    {
        while (true)
        {
            int _direction = Random.Range(0, 360);
            _spawnObject.transform.position = _spawnPoints[Random.Range(_minRandomSpawnPoints, _spawnPoints.Length)].position;

            Instantiate(_spawnObject, _spawnObject.transform.position, Quaternion.Euler(0,0, _direction));            
            yield return new WaitForSeconds(_timeBetweenSpawns);
        }
    }
}
