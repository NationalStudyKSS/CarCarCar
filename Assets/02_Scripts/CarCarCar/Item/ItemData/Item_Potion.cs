using UnityEngine;

public class Item_Potion : MonoBehaviour, IUsableItem
{
    public void Use()
    {
        Debug.Log("ü�� ȸ��!");
        Destroy(gameObject);
    }
}
