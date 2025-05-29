using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyButtonCallBack : MonoBehaviour
{
    public void OnClickMyBtn(string msg)
    {
        Debug.Log(msg);
    }

    public void OnClickNumberBtn(int num)
    {
        Debug.Log(num + "번 버튼 눌림!!!");
    }
}
