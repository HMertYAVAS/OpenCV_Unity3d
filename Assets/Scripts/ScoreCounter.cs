using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreCounter : MonoBehaviour
{
    public TMPro.TextMeshProUGUI scoreText;

    float sec;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerController.gameOver == false)
        {
            sec += Time.deltaTime;

            scoreText.text = Mathf.Round(sec).ToString();
            if (sec > PlayerPrefs.GetInt("totalScore"))
            {
                PlayerPrefs.SetInt("totalScore", (int)Mathf.Round(sec));
            }
        }
    }
}
