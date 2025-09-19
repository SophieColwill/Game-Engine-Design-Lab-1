using UnityEngine;
using TMPro;

public class ScoreDisplayer : MonoBehaviour
{
    public TMP_Text ScoreDisplay;

    void Update()
    {
        //Get score from Score Manager scirpt. If there is no high score (A.K.A. High Score = 0), display only the current score, otherwise display both.
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
