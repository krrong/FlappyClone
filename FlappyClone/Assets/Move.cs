using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed; // 기둥의 이동 속도

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime; // Vector3.left = (-1, 0, 0)
        // Debug.Log(transform.position);
    }
}

// Time.deltaTime = 지난 프레임이 완료되는데 까지 걸린 시간(FPS 보정용으로 사용)