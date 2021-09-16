using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//Spaceキーを押すことでゲームを再開するスクリプト
public class Retry : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKey(KeyCode.Space)) {
            SceneManager.LoadScene("Scenes/MainScene");
        }
    }
}
