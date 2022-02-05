using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// unity의 UI를 가져와 사용하기 위해 추가
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    // 외부에서 접근해서 사용하기 위해 static
    public static int score = 0;
    public static int bestScore = 0;

    // Start is called before the first frame update
    void Start()
    {
        // 점수 초기화
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        // int를 문자형 자료형으로 변경
        GetComponent<Text>().text = score.ToString();
    }
}
