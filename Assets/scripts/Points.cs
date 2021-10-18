using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Points : MonoBehaviour
{
    public static Points instance;
    public Text ScoreT;
    public Text HighScoreT;

    int score = 0;
    int highscore = 0;

    private void Awake(){
        instance = this;
    }
    void Start()
    {
        highscore = PlayerPrefs.GetInt("highscore", score);
        ScoreT.text = score.ToString() + " Points";
        HighScoreT.text = "Highscore: " + highscore.ToString();
    }

    // Update is called once per frame
    public void AddPoint() {
        score +=500;
        ScoreT.text = score.ToString() + " Points";
            if (score>highscore)
                highscore = score;
                PlayerPrefs.SetInt("highscore", score);
    }
}
