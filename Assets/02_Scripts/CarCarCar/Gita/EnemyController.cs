using System.Collections;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float moveSpeed = 2f;

    void Update()
    {
        float speed = moveSpeed * GameSpeedManager.Instance.SpeedMultiplier;
        transform.Translate(0, 0, -speed * Time.deltaTime);
    }
}