using UnityEngine;

public class Item_Coin : MonoBehaviour, IUsableItem
{
    public void Use()
    {
        Debug.Log("���� ȹ��!");
        Destroy(gameObject);

        if (ScoreManager.Instance != null)
        {
            ScoreManager.Instance.AddScore(100);
        }
    }
}
