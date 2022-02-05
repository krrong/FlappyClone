using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Replay : MonoBehaviour
{
    // 게임 재실행
    public void ReplayGame()
    {
        SceneManager.LoadScene("PlayScene");
    }
}
