using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//Escキーを押すことでタイトルに戻るスクリプト
public class ReturnTitle : MonoBehaviour
{
    void Update() {
        if (Input.GetKey(KeyCode.Escape)) {
            SceneManager.LoadScene("Scenes/TitleScene");
        }
    }
}
