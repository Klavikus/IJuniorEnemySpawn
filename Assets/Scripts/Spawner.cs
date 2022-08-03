using System.Collections;
using UnityEngine;
using Random = UnityEngine.Random;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject _spawnPrefab;
    [SerializeField] private Transform[] _spawnPoints;
    [SerializeField] private Transform _objectContainer;
    [SerializeField] private float _spawnDelay;

    private float _timeFromLastSpawn;

    private IEnumerator Start()
    {
        WaitForSeconds delay = new WaitForSeconds(_spawnDelay);

        while (true)
        {
            RandomSpawnObject();
            yield return delay;
        }
    }

    private void RandomSpawnObject()
    {
        int randomPointId = Random.Range(0, _spawnPoints.Length);
        Instantiate(_spawnPrefab, _spawnPoints[randomPointId].transform.position, Quaternion.identity,
            _objectContainer);
    }
}