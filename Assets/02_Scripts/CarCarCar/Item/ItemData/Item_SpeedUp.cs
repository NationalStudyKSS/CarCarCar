using UnityEngine;

public class Item_SpeedUp : MonoBehaviour, IUsableItem
{
    public float _duration = 5f;

    public void Use()
    {
        Debug.Log("���ǵ��!");

        // ���� �ӵ� ����
        GameSpeedManager.Instance.SpeedUp(2f, _duration);

        // �÷��̾� ���� Ȱ��ȭ
        var player = GameObject.FindWithTag("Player")?.GetComponent<PlayerController>();
        if (player != null)
        {
            player.ActivateInvincibility(_duration);
        }

        Destroy(gameObject);
    }
}
