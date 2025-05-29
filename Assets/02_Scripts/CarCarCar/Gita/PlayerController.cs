using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private AudioSource normalBGM;
    [SerializeField] private AudioSource invincibleBGM;

    public float moveSpeed;
    public float limitX;
    public int playerHp = 5;
    public int maxHp = 5;

    public GameObject hitEffect;
    public GameObject itemEffect;

    public event UnityAction HitEnemy;

    public Image[] _hpIcons;

    private bool _isInvincible = false;         //  무적 상태 여부
    private float _invincibleTimer = 0f;         //  무적 시간 타이머

    private void Start()
    {
        invincibleBGM.Stop();
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKey(KeyCode.LeftArrow))
        //{
        //    transform.Translate(-moveSpeed * Time.deltaTime, 0, 0);

        //    if (transform.position.x < -limitX)
        //    {
        //        transform.position = new Vector3(-limitX, transform.position.y, transform.position.z);
        //    }
        //}

        //if (Input.GetKey(KeyCode.RightArrow))
        //{
        //    transform.Translate(moveSpeed * Time.deltaTime, 0, 0);
        //    if (transform.position.x > limitX)
        //    {
        //        transform.position = new Vector3(limitX, transform.position.y, transform.position.z);
        //    }
        //}

        // 무적 타이머 관리
        if (_isInvincible)
        {
            _invincibleTimer -= Time.deltaTime;
            if (_invincibleTimer <= 0f)
            {
                _isInvincible = false;
                Debug.Log("무적 해제");

                // 음악 전환
                invincibleBGM.Stop();
                normalBGM.Play();
                Debug.Log("기본 BGM 재생");
            }
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            if (_isInvincible)
            {
                Instantiate(hitEffect, transform.position, transform.rotation);
                Destroy(other.gameObject);
                
                return;
            }

            HitEnemy?.Invoke();

            Debug.Log(other.gameObject.tag + "랑 부딪힘!!");
            playerHp = Mathf.Max(playerHp-1, 0);
            Instantiate(hitEffect,transform.position, transform.rotation);
            Destroy(other.gameObject);
            for(int i=0;i < _hpIcons.Length; i++)
            {
                if (i < playerHp)
                {
                    _hpIcons[i].enabled = true;
                }
                else
                {
                    _hpIcons[i].enabled = false;
                }
            }

            if (playerHp <= 0)
            {
                Debug.Log("GAME OVER");
                SceneManager.LoadScene(0);
            }
        }

        else if (other.CompareTag("Potion"))
        {
            playerHp = Mathf.Min(playerHp + 1, maxHp);
            for (int i = 0; i < _hpIcons.Length; i++)
            {
                if (i < playerHp)
                {
                    _hpIcons[i].enabled = true;
                }
                else
                {
                    _hpIcons[i].enabled = false;
                }
            }
        }
        
    }

    public void ActivateInvincibility(float duration)
    {
        if (!_isInvincible)
        {
            // 처음 무적 시작
            normalBGM.Stop();
            invincibleBGM.Play();
            Debug.Log("무적 BGM 재생 시작");
        }

        _isInvincible = true;
        _invincibleTimer = duration;
        Debug.Log($"무적 시작! {duration}초");
    }
}
