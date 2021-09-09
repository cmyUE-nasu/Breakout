using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameMaster : MonoBehaviour
{
    public int boxNum;
    public float nowTime;
    public Text nowTimeText;
    
    // Start is called before the first frame update
    void Start()
    {
        nowTime = 0;
    }

    // Update is called once per frame
    void Update() {
        nowTime += Time.deltaTime;
        nowTimeText.text = "経過時間:" + nowTime.ToString("F0") + "秒";

        if (boxNum <= 0) {
            EndGame(nowTime.ToString("F0") + "秒でクリアした!!", true);
        }
        if (Input.GetKey(KeyCode.Escape)) {
            QuitGame();
        }
    }

    public void QuitGame() {
        SceneManager.LoadScene("Scenes/TitleScene");
    }
    public void EndGame(string resultMessage, bool result) {
        DataSender.resultMessage = resultMessage;
        DataSender.result = result;
        SceneManager.LoadScene("Scenes/ResultScene");
    }
}
