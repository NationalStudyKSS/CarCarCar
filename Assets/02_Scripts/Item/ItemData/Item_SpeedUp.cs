using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item_SpeedUp : MonoBehaviour, IUsableItem
{
    public void Use()
    {
        Debug.Log("스피드업!");
        Destroy(gameObject);
    }
}
