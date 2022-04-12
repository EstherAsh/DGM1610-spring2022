using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class scoremanager : MonoBehaviour
{
    public int Score ;
    //keep track if the score
    public TextMeshProUGUI scoreText; //Text object to be modified


    // Start is called before the first frame update
    void Start()
    {
       UpdateScoreText(); 
    }

    // Update is called once per frame
    public void IncreaseScoreText(int amount)
    {
        Score += amount;
        UpdateScoreText();
    }
    public void DecreaseScoreText(int amount)
    {
        Score -= amount;
        UpdateScoreText();
    }
    public void UpdateScoreText()
    {
        print(Score);
        scoreText.text = "Score: "+ Score;
    }
}
