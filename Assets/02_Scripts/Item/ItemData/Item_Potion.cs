using UnityEngine;

public class Item_Potion : MonoBehaviour, IUsableItem
{
    public void Use()
    {
        Debug.Log("체력 회복!");
        Destroy(gameObject);
    }
}
