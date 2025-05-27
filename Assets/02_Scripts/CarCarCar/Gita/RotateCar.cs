using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCar : MonoBehaviour
{
    public float leftRotationY = -20f;  // ���� �밢�� ȸ�� ����
    public float rightRotationY = 20f;  // ������ �밢�� ȸ�� ����
    public float neutralRotationY = 0f; // ����

    private void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.rotation = Quaternion.Euler(0, leftRotationY, 0);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.rotation = Quaternion.Euler(0, rightRotationY, 0);
        }
        else
        {
            transform.rotation = Quaternion.Euler(0, neutralRotationY, 0);
        }
    }
}
