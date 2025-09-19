using UnityEngine;

public class ScoreManager : Singleton<ScoreManager>
{
    public float HighScore = 0;
    public float CurrentTime = 0;
    public int Wave = 1;

    [Header("EnemySpeeds")]
    public float BaseSpeed;
    public float SpeedPerWave;
    public float ModifierSpeed;
    public float EnemySpawnerSpeedStart;
    public float EnemySpawnerSpeedPerWave;
    public float EnemySpawnAreaX;

    void Update()
    {
        CurrentTime += Time.deltaTime;

        Wave = Mathf.FloorToInt((CurrentTime + 5) / 5);
    }

    public void MatchEnded()
    {
        if (CurrentTime > HighScore)
        {
            HighScore = CurrentTime;
        }
        CurrentTime = 0;
    }
}
