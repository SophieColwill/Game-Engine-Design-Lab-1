using UnityEngine;
using TMPro;

public class ScoreDisplayer : MonoBehaviour
{
    public TMP_Text ScoreDisplay;

    void Update()
    {
        if (ScoreManager.Instance.HighScore == 0)
        {
            ScoreDisplay.text = Mathf.Floor(ScoreManager.Instance.CurrentTime).ToString();
        }
        else
        {
            ScoreDisplay.text = Mathf.Floor(ScoreManager.Instance.CurrentTime).ToString() + " / " + Mathf.Floor(ScoreManager.Instance.HighScore).ToString();
        }
    }
}
