using UnityEngine;

[CreateAssetMenu(fileName = "NewItem", menuName = "Item/Create New Item")]
public class ItemData : ScriptableObject
{
    public ItemType ItemType;       // 아이템 타입

    public string ItemName;         // 아이템 이름
    public float MoveSpeed;         // 아이템 이동 속도
    public float ItemChance;        // 아이템 등장 확률
    public float SpawnSpan;         // 아이템 등장 주기
    public GameObject ItemEffect;   // 아이템 획득 이펙트
    public AudioClip ItemSound;    // 아이템 획득 사운드
    public string Description;      // 아이템 설명
    public int Amount;              // 아이템 수치
}