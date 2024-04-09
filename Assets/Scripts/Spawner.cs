using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Enemy[] _spawnObjects;
    [SerializeField] private Transform[] _spawnPoints;
    [SerializeField] private Purposes[] _purpose;

    private float _delay = 2f;
    private int _minRandomSpawn = 0;    

    private void Start()
    {
        StartCoroutine(Spawn());
    }

    private void CreateEnemy()
    {        
        int _spawn = Random.Range(_minRandomSpawn, _spawnPoints.Length);        

        var enemy = Instantiate(_spawnObjects[_spawn], _spawnPoints[_spawn]);
        enemy.Direction(_purpose[_spawn]);
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