using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CurrentScore : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // 현재 스코어가 뜨도록 수정
        GetComponent<Text>().text =  "Score : " + Score.score.ToString();
    }

}
