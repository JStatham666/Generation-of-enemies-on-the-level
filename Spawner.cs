using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private float _delay = 2f;
    [SerializeField] private List<SpawnPoint> _spawnPoints;

    private void Start() =>
        StartCoroutine(CountSpawnDelay());

    private IEnumerator CountSpawnDelay()
    {
        var delay = new WaitForSeconds(_delay);

        while (true)
        {
            GetSpawnPoint().Create();
            yield return delay;
        }
    }

    private SpawnPoint GetSpawnPoint() =>
        _spawnPoints[UnityEngine.Random.Range(0, _spawnPoints.Count)];
}