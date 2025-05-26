using UnityEngine;

public class ItemEffectPlayer : MonoBehaviour
{
    public void PlayEffect(GameObject effectPrefab, Vector3 position, Quaternion rotation)
    {
        if (effectPrefab != null)
        {
            Instantiate(effectPrefab, position, rotation);
        }
    }
}
