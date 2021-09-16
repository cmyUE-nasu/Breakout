using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/*
 * ゲームの結果を記録したシングルトンオブジェクトから
 * データを読み取り、UIに表示させるスクリプト
 */
public class TextDataFetcher : MonoBehaviour {
    [SerializeField] private Text resultMessageText;
    [SerializeField] private Text resultTitleText;
    
    void Start() {
        resultMessageText.text = DataSender.resultMessage;
        if (DataSender.result) {
            resultTitleText.text = "Game Clear!!";
        }
        else {
            resultTitleText.text = "Game Over...";
        }
    }
}
