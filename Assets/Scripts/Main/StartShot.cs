using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

/* ボールの特性を纏めたスクリプト
 * 最初にボールに速度を与える
 * QかEが押された時は進行方向を曲げることが出来る
 * 回転機能は一度使うと再度何かに当たって跳ね返るまで使用できない*/
public class StartShot : MonoBehaviour {
    private bool _rollFlag;      //ボールを回転させたかのフラグ
    public float speed = 10.0f; //ボールの速度

    void Start() {
        //GameObjectを30から120の間でランダムに回転させる
        transform.eulerAngles = new Vector3(0, Random.Range(30, 120), 0);
        //GameObjectのローカル軸でのz軸をspeedにする
        gameObject.GetComponent<Rigidbody>().velocity = transform.forward * speed;
        //ボールの進行方向を曲げる機能を有効化する
        _rollFlag = true;
    }

    private void Update() {
        //ボールの回転機能の実装
        if (_rollFlag && Input.GetKey(KeyCode.Q)) {
            //現在の速度ベクトルを取得
            Vector3 tmp = gameObject.GetComponent<Rigidbody>().velocity;
            //45°回転する処理. ベクトルの回転移動をさせてGameObjectのvelocityを書き換えてきます。
            gameObject.GetComponent<Rigidbody>().velocity = new Vector3(
                (float) (Math.Sin(0.25 * Math.PI) * tmp.z * -1.0f + Math.Cos(0.25 * Math.PI) * tmp.x),
                tmp.y,
                (float) (Math.Sin(0.25 * Math.PI) * tmp.x + Math.Cos(0.25 * Math.PI) * tmp.z)
            ).normalized * speed;
            //機能を無効化する
            _rollFlag = false;
        } else if (_rollFlag && Input.GetKey(KeyCode.E)) {
            //上と大体同じことをしています。
            Vector3 tmp = gameObject.GetComponent<Rigidbody>().velocity;
            gameObject.GetComponent<Rigidbody>().velocity = new Vector3(
                (float) (Math.Sin(-0.25 * Math.PI) * tmp.z * -1.0f + Math.Cos(-0.25 * Math.PI) * tmp.x),
                tmp.y,
                (float) (Math.Sin(-0.25 * Math.PI) * tmp.x + Math.Cos(-0.25 * Math.PI) * tmp.z)
            ).normalized * speed;
            _rollFlag = false;
        }
    }

    private void OnCollisionEnter(Collision other) {
        //何かに当たって跳ね返った後に再度進行方向を曲げられるようにする
        _rollFlag = true;
    }
}
