using UnityEngine;

public class Item_Coin : MonoBehaviour, IUsableItem
{
    public void Use()
    {
        Debug.Log("���� ȹ��!");
        Destroy(gameObject);
    }
}