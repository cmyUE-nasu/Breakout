using System.Collections.Generic;
using UnityEngine;

/*
 的となるブロックを生成するScript
 
*/
public class BoxInit : MonoBehaviour
{

    [SerializeField] private GameObject boxObjPrefab; //的のブロックのPrefabを渡す
    [SerializeField] private GameObject boxesObj;     //ブロックを格納するEmptyObjectを渡す

    private void Awake() {
        //ゲームの進行状況を管理するオブジェクト
        GameObject masterObj = GameObject.Find("Master");
        //横に８個、縦に５個並べる
        for (int x = 0; x < 8; x++) {
            for (int y = 0; y < 5; y++) {
                //Prefabをインスタンス化する
                GameObject targetBox = Instantiate(boxObjPrefab, boxesObj.transform);
                //位置を初期化する
                targetBox.transform.position = new Vector3((2f + (1f * y)), 0.4f, (-4.2f + (1.2f * x)));
                //DestroyerComponentのmasterObjを設定する
                targetBox.GetComponent<Destroyer>().masterObj = masterObj;
                //targetBoxが一つ増えたことを知らせる
                masterObj.GetComponent<GameMaster>().OnBoxAdd();
            }
        }
    }
}
