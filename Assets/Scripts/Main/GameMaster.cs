using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

/*
 * ゲームの進行状況を管理するスクリプト
 * 的のオブジェクトがいくつ残っているか、
 * ゲーム開始からの時間を記録する。
 * ゲームの終了判定もしている。
 */
public class GameMaster : MonoBehaviour
{
    private int _boxNum = 0;    //的となるオブジェクトの数
    private float _nowTime;     //ゲーム開始からの経過時間
    [SerializeField] private Text nowTimeText;  //経過時間を表示するTextUI
    
    void Start()
    {
        _nowTime = 0;   //時間を初期化
    }

    void Update() {
        _nowTime += Time.deltaTime; //前回のフレームからの経過時間を足すことで現在の時間を更新
        nowTimeText.text = "経過時間:" + _nowTime.ToString("F0") + "秒"; //UIに経過時間を表示

        //的のオブジェクトがすべて消えた時にゲームクリアとしてゲームを終了し、リザルト画面に移動
        if (_boxNum <= 0) {
            EndGame(_nowTime.ToString("F0") + "秒でクリアした!!", true);
        }
        //Escキーが押されたらゲームを終了しタイトルに戻る
        if (Input.GetKey(KeyCode.Escape)) {
            QuitGame();
        }
    }

    //ゲームを中断しタイトルに戻る
    public void QuitGame() {
        SceneManager.LoadScene("Scenes/TitleScene");
    }
    
    //ゲームを終了しタイトル画面に戻る. その際にメッセージとクリアしたかどうかを引数に渡す
    public void EndGame(string resultMessage, bool result) {
        //シングルトンオブジェクトに結果を記録する。
        DataSender.resultMessage = resultMessage;
        DataSender.result = result;
        //リザルト画面に移動
        SceneManager.LoadScene("Scenes/ResultScene");
    }

    //的オブジェクトが追加されたときに呼び出される
    public void OnBoxAdd() {
        _boxNum++;
    }

    //的オブジェクトが破壊されたときに呼び出される
    public void OnBoxDestroy() {
        _boxNum--;
    }
}
