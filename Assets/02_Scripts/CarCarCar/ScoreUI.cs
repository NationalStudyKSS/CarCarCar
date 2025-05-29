using UnityEngine;
using UnityEngine.UI;

public class ScoreUI : MonoBehaviour
{
    [SerializeField] Text scoreText;

    void Start()
    {
        ScoreManager.Instance.OnScoreChanged += UpdateScoreText;
        UpdateScoreText(ScoreManager.Instance.GetScore()); // �ʱ�ȭ
    }

    void UpdateScoreText(int newScore)
    {
        scoreText.text = "Score : " + newScore;
    }

    void OnDestroy()
    {
        if (ScoreManager.Instance != null)
            ScoreManager.Instance.OnScoreChanged -= UpdateScoreText;
    }
}
