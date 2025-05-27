using UnityEngine;

public class Item : MonoBehaviour
{
    [SerializeField] ItemData _data;
    [SerializeField] ItemMover _mover;
    [SerializeField] ItemEffectPlayer _effectPlayer;
    [SerializeField] ItemSoundPlayer _soundPlayer;

    private IUsableItem _usable;

    void Awake()
    {
        _mover.Initialize(_data);
        _usable = GetComponent<IUsableItem>();
    }

    public void UseItem()
    {
        _usable?.Use();

        // ItemData�� �ִ� �����հ� ���� Ȱ��
        _effectPlayer?.PlayEffect(_data.ItemEffect, transform.position, transform.rotation);
        //Debug.Log("����Ʈ ����");
        _soundPlayer?.PlaySound(_data.ItemSound, transform.position);
        //Debug.Log("���� ����");

        Destroy(gameObject);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            UseItem();
        }
    }
}
