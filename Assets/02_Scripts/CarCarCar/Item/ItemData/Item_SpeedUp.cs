using UnityEngine;

public class Item_SpeedUp : MonoBehaviour, IUsableItem
{
    public float _duration = 5f;

    public void Use()
    {
        Debug.Log("스피드업!");

        // 게임 속도 증가
        GameSpeedManager.Instance.SpeedUp(2f, _duration);

        // 플레이어 무적 활성화
        var player = GameObject.FindWithTag("Player")?.GetComponent<PlayerController>();
        if (player != null)
        {
            player.ActivateInvincibility(_duration);
        }

        Destroy(gameObject);
    }
}
