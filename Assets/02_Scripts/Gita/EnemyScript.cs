using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public GameObject[] cars;

    private void Start()
    {
        int rnd = Random.Range(0, cars.Length);
        cars[rnd].SetActive(true);    // OnOff
    }
}
