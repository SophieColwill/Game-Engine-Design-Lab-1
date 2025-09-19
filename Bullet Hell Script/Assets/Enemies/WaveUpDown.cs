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
        //Add a value to the sine wave
        SineWaveTime += Time.deltaTime * 5;

        //Move Left
        transform.position -= new Vector3(CurrentWaveSpeed(), 0, 0) * Time.deltaTime;

        //Move up & down according to the sine wave
        transform.position = new Vector3(transform.position.x, OriginalY + (Mathf.Sin(SineWaveTime) * ScoreManager.Instance.ModifierSpeed));
    }
}
