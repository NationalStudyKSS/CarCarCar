using UnityEngine;

[CreateAssetMenu(fileName = "NewItem", menuName = "Item/Create New Item")]
public class ItemData : ScriptableObject
{
    public ItemType ItemType;       // ������ Ÿ��

    public string ItemName;         // ������ �̸�
    public float MoveSpeed;         // ������ �̵� �ӵ�
    public float ItemChance;        // ������ ���� Ȯ��
    public float SpawnSpan;         // ������ ���� �ֱ�
    public GameObject ItemEffect;   // ������ ȹ�� ����Ʈ
    public AudioClip ItemSound;    // ������ ȹ�� ����
    public string Description;      // ������ ����
    public int Amount;              // ������ ��ġ
}