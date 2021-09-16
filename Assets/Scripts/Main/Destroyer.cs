using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

/*
 * 的のオブジェクトにアタッチするスクリプト
 * 何かに衝突したときにアタッチされているGameObjectを破壊し、
 * GameMaster内の的の数を記録するメンバから１を引く
 */
public class Destroyer : MonoBehaviour {
     private GameObject _masterObj; //ゲームの進行状況を管理するオブジェクト
     public GameObject masterObj {
         set { _masterObj = value; }
     }
    
    private void OnCollisionEnter(Collision other) {
        //GameMasterに的が一つ減ったのを通知する
        _masterObj.GetComponent<GameMaster>().OnBoxDestroy();
        //自身を破壊
        Destroy(gameObject);
    }
}
