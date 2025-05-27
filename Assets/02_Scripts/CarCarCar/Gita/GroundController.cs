using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundController : MonoBehaviour
{
    [SerializeField] Item_SpeedUp _speedUp;
    public float moveSpeed;
    private float _originalSpeed;

    // 재배치 기준이 되는 대상의 트랜스폼 컴포넌트
    [SerializeField] Transform _target;

    // 재배치 감도 거리(타겟으로부터 이 거리보다 멀어지면 재배치)
    [SerializeField] float _senseDistance;

    // 재배치 시 이동 거리
    [SerializeField] float _reposDistance;

    /// <summary>
    /// 자동으로 target을 찾아줌(Player태그 이용)
    /// </summary>
    void Start()
    {
        _originalSpeed = moveSpeed;
    }


    // Update is called once per frame
    void Update()
    {
        GroundControlling();
    }

    void GroundControlling()
    {
        float speed = moveSpeed * GameSpeedManager.Instance.SpeedMultiplier;
        transform.Translate(0, 0, -speed * Time.deltaTime);

        if (_target == null) return;

        float distZ = _target.position.z - transform.position.z;

        if (distZ > _senseDistance)
        {
            transform.position += Vector3.forward * _reposDistance;
        }
    }
}
