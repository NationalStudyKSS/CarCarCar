using UnityEngine;

public class ItemSoundPlayer : MonoBehaviour
{
    public void PlaySound(AudioClip clip, Vector3 position)
    {
        if (clip != null)
        {
            AudioSource.PlayClipAtPoint(clip, position);
        }
    }
}
