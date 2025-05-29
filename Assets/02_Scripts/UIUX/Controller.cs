using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    [SerializeField] Transform _player;
    [SerializeField] float moveX;
    [SerializeField] float moveY;
    [SerializeField] float limitX;
    [SerializeField] float limitY;

    public bool left = false;
    public bool right = false;
    public bool up = false;
    public bool down = false;

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.LeftArrow))
        {
            PressLeftBtn();
            if (left == true)
            {
                _player.Translate(-moveX * Time.deltaTime, 0, 0);
                if (_player.transform.position.x < -limitX)
                {
                    Debug.Log("���̻� ����!!!");
                    _player.transform.position = new Vector3(-limitX, transform.position.y, 0);
                }
            }
        }

        if (left == true)
        {
            _player.Translate(-moveX * Time.deltaTime, 0, 0);
            if(_player.transform.position.x < -limitX)
            {
                Debug.Log("���̻� ����!!!");
                _player.transform.position = new Vector3(-limitX, transform.position.y, 0);
            }
        }
        if (right == true)
        {
            _player.Translate(moveX * Time.deltaTime, 0, 0);
            if (_player.transform.position.x > limitX)
            {
                Debug.Log("���̻� ����!!!");
                _player.transform.position = new Vector3(limitX, transform.position.y, 0);
            }
        }
        if (up == true)
        {
            _player.Translate(0, moveY * Time.deltaTime, 0);
            if (_player.transform.position.y > limitY)
            {
                Debug.Log("���̻� ����!!!");
                _player.transform.position = new Vector3(transform.position.x, limitY, 0);
            }
        }
        if (down == true)
        {
            _player.Translate(0, -moveY * Time.deltaTime, 0);
            if (_player.transform.position.y < -limitY)
            {
                Debug.Log("���̻� ����!!!");
                _player.transform.position = new Vector3(transform.position.x, -limitY, 0);
            }
        }
    }

    public void OnClickLeftBtn()
    {
        Debug.Log("L ��ư ����!!!");
        _player.Translate(-moveX, 0, 0);
        if (_player.transform.position.x < -limitX)
        {
            Debug.Log("���̻� ����!!!");
            _player.transform.position = new Vector3(-limitX, transform.position.y, 0);
        }
    }

    public void OnClickRightBtn()
    {
        Debug.Log("R ��ư ����!!!");
        _player.Translate(moveX, 0, 0);
        if (_player.transform.position.x > limitX)
        {
            Debug.Log("���̻� ����!!!");
            _player.transform.position = new Vector3(limitX, transform.position.y, 0);
        }
    }

    public void OnClickUpBtn()
    {
        Debug.Log("Up ��ư ����!!!");
        _player.Translate(0, moveY, 0);
        if (_player.transform.position.y > limitY)
        {
            Debug.Log("���̻� ����!!!");
            _player.transform.position = new Vector3(transform.position.x, limitY, 0);
        }
    }

    public void OnClickDownBtn()
    {
        Debug.Log("Down ��ư ����!!!");
        _player.Translate(0, -moveY, 0);
        if (_player.transform.position.y < -limitY)
        {
            Debug.Log("���̻� ����!!!");
            _player.transform.position = new Vector3(transform.position.x, -limitY, 0);
        }
    }

    public void PressLeftBtn()
    {
        Debug.Log("LeftBtn ����!!!");
        left = true;
    }
    public void ReleaseLeftBtn()
    {
        Debug.Log("LeftBtn ��!!!");
        left = false;
    }
    public void PressRightBtn()
    {
        Debug.Log("RightBtn ����!!!");
        right = true;
    }
    public void ReleaseRightBtn()
    {
        Debug.Log("RightBtn ��!!!");
        right = false;
    }
    public void PressUpBtn()
    {
        Debug.Log("UpBtn ����!!!");
        up = true;
    }
    public void ReleaseUpBtn()
    {
        Debug.Log("UpBtn ��!!!");
        up = false;
    }
    public void PressDownBtn()
    {
        Debug.Log("DownBtn ����!!!");
        down = true;
    }
    public void ReleaseDownBtn()
    {
        Debug.Log("DownBtn ��!!!");
        down = false;
    }
}
