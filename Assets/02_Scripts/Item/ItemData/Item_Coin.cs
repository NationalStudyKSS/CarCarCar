using UnityEngine;

public class Item_Coin : MonoBehaviour, IUsableItem
{
    public void Use()
    {
        Debug.Log("ÄÚÀÎ È¹µæ!");
        Destroy(gameObject);
    }
}