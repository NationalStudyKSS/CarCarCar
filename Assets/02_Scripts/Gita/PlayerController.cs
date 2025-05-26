using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed;
    public float limitX;
    public int playerHp = 5;
    public int maxHp = 5;

    public GameObject hitEffect;
    public GameObject itemEffect;

    public event UnityAction HitEnemy;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-moveSpeed * Time.deltaTime, 0, 0);

            if (transform.position.x < -limitX)
            {
                transform.position = new Vector3(-limitX, transform.position.y, transform.position.z);
            }
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(moveSpeed * Time.deltaTime, 0, 0);
            if (transform.position.x > limitX)
            {
                transform.position = new Vector3(limitX, transform.position.y, transform.position.z);
            }
        }
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            HitEnemy?.Invoke();
            Debug.Log(other.gameObject.tag + "랑 부딪힘!!");
            playerHp--;
            Instantiate(hitEffect,transform.position, transform.rotation);
            Destroy(other.gameObject);
            if (playerHp <= 0)
            {
                Debug.Log("GAME OVER");
            }
        }
    }
}
