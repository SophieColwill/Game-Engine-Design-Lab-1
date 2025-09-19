using UnityEngine;
using UnityEngine.SceneManagement;

public abstract class Enemy : MonoBehaviour
{
    protected abstract void movement();

    private void Update()
    {
        movement();

        if (transform.position.x <= -ScoreManager.Instance.EnemySpawnAreaX)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            SceneManager.LoadScene(0);
            ScoreManager.Instance.MatchEnded();
        }
    }

    protected float CurrentWaveSpeed()
    {
        return ScoreManager.Instance.BaseSpeed + (ScoreManager.Instance.SpeedPerWave * (ScoreManager.Instance.Wave - 1));
    }
}
