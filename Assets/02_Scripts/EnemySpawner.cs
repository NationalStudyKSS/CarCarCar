using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public float curTime;   // 현재 시간
    public float coolTime = 2f;  // 쿨타임
    public GameObject enemyPrefab;
    public GameObject itemPrefab;

    // Start is called before the first frame update
    void Start()
    {
        curTime = 0f;
        RandomCoolTime();
    }

    // Update is called once per frame
    void Update()
    {
        curTime += Time.deltaTime;  //curTime = curTime + Time.deltaTime;

        if (curTime > coolTime)
        {
            curTime -= coolTime;
            int rand = Random.Range(0, 100);
            if (rand > 25)
            {
                Instantiate(enemyPrefab, transform.position, transform.rotation);
            }
            else
            {
                Instantiate(itemPrefab, transform.position, transform.rotation);
            }
                RandomCoolTime();
        }
    }

    public void RandomCoolTime()
    {
        int rand = Random.Range(1,6);
        //print(rand);
        coolTime = rand;
    }
}
