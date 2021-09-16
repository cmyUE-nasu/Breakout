using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* スコアデータを記録するシングルトンオブジェクト */
public static class DataSender {
    public static string resultMessage; //リザルト画面で表示するメッセージ
    public static bool result;          //ゲーム中の経過時間
}
