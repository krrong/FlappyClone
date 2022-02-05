using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreUp : MonoBehaviour
{
    // Trigger속성 --> Collider끼리 통과 가능
    private void OnTriggerEnter2D(Collider2D other)
    {
        // 통과할 때 점수 증가
        Score.score++;
    }
}
