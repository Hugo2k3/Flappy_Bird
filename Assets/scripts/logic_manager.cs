using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class logic_manager : MonoBehaviour
{
    public Text txtCurScore;
    public static logic_manager instance;



    int score_play ;
    // Start is called before the first frame update
    public void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            DestroyImmediate(this);
        }
        btnRestart.onClick.AddListener(() => {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        });

        score_play = 0;
        UpdateScore();
        isGameStart = false;
        Time.timeScale = 0;
       
    }
    public void StartGame()
    {
        Time.timeScale = 1;
        isGameStart = true;
    }
    public bool isGameStart = false;
    void Start()
    {
      
    }

   public int HighScore
    {
        get => PlayerPrefs.GetInt("HighScore", 0);
        set
        {
            if (value >PlayerPrefs.GetInt("HighScore",0))
            {
                PlayerPrefs.SetInt("HighScore", value);
            }
        }
    }
    private void UpdateScore()
    {
        txtCurScore.text = score_play.ToString();
    }
    public void addScore(int scoreToAdd)
    {
        score_play+= scoreToAdd;
       UpdateScore();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    [Space, Header("Game OVER")]
    public GameObject gameOverScreen;
    public Text score_text;
    public Text scoreHigh_text;
    public Button btnRestart;
    public void ShowGameOver()
    {
        Time.timeScale = 0;
        HighScore = score_play;
        gameOverScreen.SetActive(true);
        score_text.text = string.Format($"Score:{score_play}");
        scoreHigh_text.text = string.Format($"Max Score:{HighScore}");
        return;
    }
}
