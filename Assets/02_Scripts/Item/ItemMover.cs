using UnityEngine;

public class ItemMover : MonoBehaviour
{
    private ItemData _itemData;

    public void Initialize(ItemData itemdata)
    {
        _itemData = itemdata;
    }

    void Update()
    {
        if (_itemData != null)
        {
              
            transform.Translate(0, 0, -_itemData.MoveSpeed * Time.deltaTime);
        }
    }
}
