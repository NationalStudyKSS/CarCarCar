using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSpawner : MonoBehaviour
{
    public GameObject[] _itemPrefab;
    public float _spawnSpan = 2.0f;

    public void Start()
    {
        StartCoroutine(SpawnItemCoroutine());
    }

    IEnumerator SpawnItemCoroutine()
    {
        while (true)
        {
            SpawnItem();
            yield return new WaitForSeconds(_spawnSpan);
        }
    }

    public void SpawnItem()
    {
        int itemChance = Random.Range(0, 100);
        if (itemChance < 50)
        {
            int rand = Random.Range(0, _itemPrefab.Length);
            Instantiate(_itemPrefab[rand], transform.position, transform.rotation);
        }
    }
}
