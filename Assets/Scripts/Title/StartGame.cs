using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//何かボタンが押されたらゲームを開始するスクリプト
public class StartGame : MonoBehaviour
{
    void Update()
    {
        if (Input.anyKey) {
            SceneManager.LoadScene("Scenes/MainScene");
        }
    }
}
