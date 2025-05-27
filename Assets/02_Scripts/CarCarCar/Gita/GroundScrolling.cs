using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundScrolling : MonoBehaviour
{
    public float speedZ;
    public float limitZ;
    public Vector3 originPos;
    public Transform tr;

    public void Start()
    {
        tr=GetComponent<Transform>();
    }

    private void Update()
    {
        tr.Translate(0, 0, -speedZ * Time.deltaTime);

        if (tr.position.z < limitZ)
        {
            tr.position = originPos;
        }
    }
}
