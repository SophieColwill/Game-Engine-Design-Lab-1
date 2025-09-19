using NUnit.Framework;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    float timeTillNextSpawn;
    public float SpawnAreaY;

    public EnemyWaveCounter[] SpawnableEnemies;

    private void Update()
    {
        timeTillNextSpawn += Time.deltaTime * (ScoreManager.Instance.EnemySpawnerSpeedStart + ((ScoreManager.Instance.Wave - 1) * ScoreManager.Instance.EnemySpawnerSpeedPerWave));
        if (timeTillNextSpawn >= 1)
        {
            timeTillNextSpawn -= 1;

            if (ScoreManager.Instance.Wave < SpawnableEnemies[1].requiredWave)
            {
                SpawnEnemy(SpawnableEnemies[0].spawnableEnemy);
            }
            else
            {
                int maxNumber = SpawnableEnemies.Length;
                for (int i = 0; i < SpawnableEnemies.Length; i++)
                {
                    if (ScoreManager.Instance.Wave < SpawnableEnemies[i].requiredWave)
                    {
                        maxNumber = i;
                    }
                }

                int RandomEnemy = Random.Range(0, maxNumber);
                SpawnEnemy(SpawnableEnemies[RandomEnemy].spawnableEnemy);
            }
        }
    }

    void SpawnEnemy(Enemy spawnEnemy)
    {
        Instantiate(spawnEnemy.gameObject, new Vector3(ScoreManager.Instance.EnemySpawnAreaX, Random.Range(-SpawnAreaY, SpawnAreaY)), spawnEnemy.transform.rotation);
    }
}

[System.Serializable]
public class EnemyWaveCounter
{
    public Enemy spawnableEnemy;
    public int requiredWave;
}