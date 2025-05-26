using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundController : MonoBehaviour
{
    public float moveSpeed;

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
        if (_target == null)
        {
            GameObject targetObject = GameObject.FindGameObjectWithTag("Player");
            if (targetObject != null)
            {
                _target = targetObject.transform;
            }
        }
    }


    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 0, -moveSpeed * Time.deltaTime);

        if (_target == null) return;

        // X 방향 거리 차이 계산
        //float distX = _target.position.x - transform.position.x;

        //// 감도보다 거리가 크면 오른쪽/왼쪽으로 재배치
        //if (Mathf.Abs(distX) > _senseDistance)
        //{
        //    // Mathf.Sign(distX): 거리의 부호 -> +면 오른쪽, -면 왼쪽
        //    transform.position += Vector3.right * _reposDistance * Mathf.Sign(distX);
        //}

        //// Y 방향 거리 차이 계산
        //float distY = _target.position.y - transform.position.y;

        //// 감도보다 거리가 크면 위/아래로 재배치
        //if (Mathf.Abs(distY) > _senseDistance)
        //{
        //    transform.position += Vector3.up * _reposDistance * Mathf.Sign(distY);
        //}

        float distZ = _target.position.z - transform.position.z;

        // 감도보다 거리가 크면 위/아래로 재배치
        if (_target.position.z - transform.position.z > _senseDistance)
        {
            transform.position += Vector3.forward * _reposDistance;
        }
    }
}
