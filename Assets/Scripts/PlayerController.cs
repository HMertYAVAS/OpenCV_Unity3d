using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{

    //kamera açısından dolayı y yerine z boyutunu hareket ettiriyorum.
    //public AudioClip die;
    public AudioSource audioSource;
    FaceDetector faceDetector;
    private GameMenuScript gameMenuScript;
    //float lastY=0;
    float speed = 5f;
    float Xlast;
    float Xfirst;
    float Ylast;
    float Yfirst;
    public static bool gameOver=false;
    

    // Start is called before the first frame update
    void Start()
    {
        gameMenuScript = GameObject.Find("MenuMannager").GetComponent<GameMenuScript>();
        faceDetector = (FaceDetector)FindObjectOfType(typeof(FaceDetector));
        // audioSource =  gameObject.AddComponent<AudioSource>();
        // audioSource.clip = die;

 
    }

    // Update is called once per frame
    void Update()
    {
    CharacterMoveAlg();
    GameArea();
    if(gameOver){
        SceneManager.LoadScene(2);
    }
    }


    void CharacterMoveAlg(){
        if(Xfirst == 0){
            Xfirst=faceDetector.FaceX;
            Yfirst=faceDetector.FaceY;
        }

        Xlast = faceDetector.FaceX - Xfirst;
        Ylast = faceDetector.FaceY - Yfirst;

        if(Xlast>0){
            Xlast=1;
        }if(Xlast<0){
            Xlast=-1;
        }

        if(Ylast>0){
            Ylast=1;
        }if(Ylast<=0){
            Ylast=-1;
        }

         float step = speed * Time.deltaTime;
    //float normX = Mathf.Clamp(faceDetector.FaceX - lastX, -1, 1);
    //float normY = Mathf.Clamp(faceDetector.FaceY-lastY,-1,1);

    transform.position = Vector3.MoveTowards(transform.position,new Vector3 (transform.position.x + Xlast, transform.position.y - Ylast, transform.position.z ),step);
    }
    void GameArea(){
        if(this.gameObject.tag == "Player" && transform.position.x > 10.0f  || transform.position.x < -10.0f || transform.position.y > 10.0f || transform.position.y < -10.0f){
            gameOver=true;
        }
    }
    void OnCollisionEnter(Collision other){
        if(other.gameObject.tag == "Enemy"){
            // Debug.Log("enemy");
            gameOver=true;
            GameMenuScript.pauseStatus = true;
            
        }

    }


}