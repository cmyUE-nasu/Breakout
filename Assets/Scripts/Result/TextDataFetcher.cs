using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextDataFetcher : MonoBehaviour {
    public Text resultMessageText;
    public Text resultTitleText;
    
    // Start is called before the first frame update
    void Start() {
        resultMessageText.text = DataSender.resultMessage;
        if (DataSender.result) {
            resultTitleText.text = "Game Clear!!";
        }
        else {
            resultTitleText.text = "Game Over...";
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
