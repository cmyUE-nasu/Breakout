using UnityEngine;

public class KabeOut : MonoBehaviour
{
    private void OnCollisionEnter(Collision other) {
        GameObject.Find("Master").GetComponent<GameMaster>().EndGame("ゲーム失敗... また挑戦しよう", false);
    }
}
