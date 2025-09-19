using UnityEngine;

public class WaveUpDown : Enemy
{
    float SineWaveTime;
    float OriginalY;

    private void Start()
    {
        OriginalY = transform.position.y;
    }

    protected override void movement()
    {
        SineWaveTime += Time.deltaTime * 5;

        transform.position -= new Vector3(CurrentWaveSpeed(), 0, 0) * Time.deltaTime;
        transform.position = new Vector3(transform.position.x, OriginalY + (Mathf.Sin(SineWaveTime) * ScoreManager.Instance.ModifierSpeed));
    }
}
