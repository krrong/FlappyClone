// 외부 모듈 import 
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class BirdJump : MonoBehaviour
{
    Rigidbody2D rb;
    public float jumpPower;

    // Start is called before the first frame update --> 시작할 때만 실행
    void Start()
    {
        // Debug.Log("start");

        rb = GetComponent<Rigidbody2D>();   // 컴포넌트를 얻기 위해 사용
    }

    // Update is called once per frame --> 매 프레임마다 실행
    void Update()
    {
        // Debug.Log("update");

        // 왼쪽 버튼이 클릭되었을 때 (0이면 왼쪽 버튼)
        if (Input.GetMouseButtonDown(0))
        {
            GetComponent<AudioSource>().Play();
            rb.velocity = Vector2.up * jumpPower; // Vector2는 2차원 좌표 Vector2.up = (0, 1)

        }
    }

    // 콜라이더들끼리 서로 충돌했을 때 실행하는 함수
    private void OnCollisionEnter2D(Collision2D other)
    {
        if(Score.score > Score.bestScore)
        {
            Score.bestScore = Score.score;
        }

        // Scene을 이동하기 위해 SceneManager사용
        SceneManager.LoadScene("GameOverScene");
    }
}
