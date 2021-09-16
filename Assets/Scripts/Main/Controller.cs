using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* アタッチしたオブジェクトを
 * 左右の矢印キーで操作出来るようにするコンポーネント
 * フレームレートに関係なく同じ速度で移動できる*/
public class Controller : MonoBehaviour {
    [SerializeField] private float speed = 10;  //移動速度
    void Update() {
        //　箱の外に出ないように特定の位置では入力を制限している
        if (Input.GetKey(KeyCode.LeftArrow) && transform.position.z < 4.4f) {
            //Time.deltaTimeで前フレームからの経過時間を掛ける事でフレームレートに依存せず等速で移動出来る
            transform.position += transform.forward * speed * Time.deltaTime;
        } else if (Input.GetKey(KeyCode.RightArrow) && transform.position.z > -4.4f) {
            transform.position -= transform.forward * speed * Time.deltaTime;
        }
    }
}
