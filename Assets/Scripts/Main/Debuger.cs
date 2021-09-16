using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* デバッグ用のスクリプト
 * ゲームを自動でクリアできる
 */
public class Debuger : MonoBehaviour {
    [SerializeField] private Boolean autoIntercept = false; //自動でボールを跳ね返すか
    [SerializeField] private Boolean highSpeedBall = false; //ボールを速くするか

    [SerializeField] private GameObject player; //Playerオブジェクトをセット
    [SerializeField] private GameObject ball;   //Ballオブジェクトをセット
    
    void Start() {
        // ボールの加速処理
        if (highSpeedBall) {
            ball.GetComponent<StartShot>().speed = 37.0f;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (autoIntercept) {
            if (ball.transform.position.x <= -5.5) {
                player.transform.position = new Vector3(
                    player.transform.position.x,
                    player.transform.position.y,
                    ball.transform.position.z);
            }
        }   
    }
}
