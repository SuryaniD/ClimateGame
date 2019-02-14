using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Scoring : MonoBehaviour
{
    [SerializeField]
    private Text Hscore;
    [SerializeField]
    private Text Score;
    private int score_int;
    private Scene scene;
    public static float timeS;
    public static bool newscore;

    // Use this for initialization
    void Start()
    {
        Hscore.text = "HIGHSCORE: " + PlayerPrefs.GetInt("Highscore", 0);
        scene = SceneManager.GetActiveScene();
        if (scene.name == "RunBoyRun")
        {
            timeS = 0;
        }
    }

    // Update is called once per frame
    void Update()
    {
        scene = SceneManager.GetActiveScene();

        if (scene.name == "RunBoyRun")
        {
            timeS += Time.deltaTime;
        }

        Mathf.Round(timeS);
        score_int = (int)timeS;

        Score.text = "SCORE: " + score_int;

        if (Kill.dead == true && score_int > PlayerPrefs.GetInt("Highscore", 0))
        {
            PlayerPrefs.SetInt("Highscore", score_int);
            Hscore.text = "HIGHSCORE: " + PlayerPrefs.GetInt("Highscore", 0);
            newscore = true;
        }
    }
}
