using UnityEngine;
using Random = UnityEngine.Random;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject _spawnPrefab;
    [SerializeField] private Transform[] _spawnPoints;
    [SerializeField] private Transform _objectContainer;
    [SerializeField] private float _spawnDelay;

    private float _timeFromLastSpawn;

    private void RandomSpawnObject()
    {
        int randomPointId = Random.Range(0, _spawnPoints.Length);
        Instantiate(_spawnPrefab, _spawnPoints[randomPointId].transform.position, Quaternion.identity,
            _objectContainer);
    }

    private void Update()
    {
        _timeFromLastSpawn += Time.deltaTime;

        if (_timeFromLastSpawn < _spawnDelay)
            return;

        RandomSpawnObject();

        _timeFromLastSpawn = 0;
    }
}