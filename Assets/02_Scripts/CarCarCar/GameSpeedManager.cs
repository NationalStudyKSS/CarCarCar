using UnityEngine;

public class GameSpeedManager : MonoBehaviour
{
    public static GameSpeedManager Instance { get; private set; }

    public float SpeedMultiplier { get; private set; } = 1f;

    private void Awake()
    {
        // ΩÃ±€≈Ê ∆–≈œ: ¡ﬂ∫π πÊ¡ˆ
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
    }

    public void SpeedUp(float multiplier, float duration)
    {
        StopAllCoroutines();
        StartCoroutine(SpeedUpRoutine(multiplier, duration));
    }

    private System.Collections.IEnumerator SpeedUpRoutine(float multiplier, float duration)
    {
        SpeedMultiplier = multiplier;
        yield return new WaitForSeconds(duration);
        SpeedMultiplier = 1f;
    }
}
