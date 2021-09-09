using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMenuScript : MonoBehaviour
{
    public static bool pauseStatus;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void FixedUpdate() {
    }

    public void MenuButton(){
        SceneManager.LoadScene(0);
    }
    public void NewGameButton(){
        SceneManager.LoadScene(1);
        PlayerController.gameOver=false;
    }

}
