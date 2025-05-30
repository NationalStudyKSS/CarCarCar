using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoolTimeSystem : MonoBehaviour
{
    public float curTime;
    public float coolTime = 2f;
    public bool isClicked = false;
    public Image _image;

    // Start is called before the first frame update
    void Start()
    {
        _image.fillAmount = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        if(isClicked)
        {
            curTime += Time.deltaTime;
            _image.fillAmount = curTime / coolTime;
            if (curTime >= coolTime)
            {
                curTime = 0f;
                isClicked = false;
            }
        }
    }

    public void OnclickStartBtn()
    {
        isClicked = true;
    }
}
