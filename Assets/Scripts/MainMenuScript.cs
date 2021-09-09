using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class MainMenuScript : MonoBehaviour
{
    public TMPro.TextMeshProUGUI totalScore;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        totalScore.text = PlayerPrefs.GetInt("totalScore").ToString();
    }

    public void NewGameButton(){
        SceneManager.LoadScene(1);
        PlayerController.gameOver=false;
        GameMenuScript.pauseStatus = false;
        Time.timeScale=1;

    }
    public void QuitGameButton(){
        Application.Quit();
    }
        
}
