using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextBigSmallScript : MonoBehaviour
{
    public TMPro.TextMeshProUGUI gameName;
    private float sec = 2.0f;
    private float max = 1.5f;
    private float anothermax = 0.75f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        sec -= Time.deltaTime;
        
        if(sec <= max && sec > anothermax){
            gameName.fontSize=100;
        }else if(sec <= anothermax && sec > 0){
            gameName.fontSize=120;
        }else{
            sec=max;
        }
    }
}
