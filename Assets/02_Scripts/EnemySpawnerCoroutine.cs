using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnerCoroutine : MonoBehaviour
{
    public GameObject _enemyPrefab;
    public float _spawnSpan = 2.0f;

    public void Start()
    {
        StartCoroutine(SpawnEnemyCoroutine());
    }

    IEnumerator SpawnEnemyCoroutine()
    {
        while (true)
        {
            SpawnEnemy();
            yield return new WaitForSeconds(_spawnSpan);
        }
    }

    public void SpawnEnemy()
    {
        Instantiate(_enemyPrefab, transform.position, transform.rotation);
    }
}
