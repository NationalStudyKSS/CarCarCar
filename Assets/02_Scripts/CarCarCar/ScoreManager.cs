using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance { get; private set; }
    [SerializeField] Item_Coin _coin;

    private int _score;
    private float _timeElapsed;

    public event System.Action<int> OnScoreChanged;

    void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
    }

    void Update()
    {
        _timeElapsed += Time.deltaTime;
        if (_timeElapsed >= 1f)
        {
            AddScore(100);
            _timeElapsed -= 1f;
        }
    }

    public void AddScore(int value)
    {
        _score += value;
        OnScoreChanged?.Invoke(_score);
    }

    public int GetScore() => _score;
}
