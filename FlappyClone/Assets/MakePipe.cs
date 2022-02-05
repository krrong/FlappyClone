using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakePipe : MonoBehaviour
{

    public GameObject pipe; // public으로 선언해서 unity에서 만들어놓은 object 받아올 수 있음
    public float timeDiff;
    float timer = 0;
    

    void Start()
    {
        
    }

    void Update()
    {
        timer += Time.deltaTime;

        // timeDiff초가 흘렀으면
        if (timer > timeDiff)
        {
            // pipe 생성
            GameObject newpipe = Instantiate(pipe);

            // pipe의 위치 수정
            newpipe.transform.position = new Vector3(0.84f, Random.Range(-1.7f, 4.1f), 0);

            timer = 0;

            // 5초 이후에 생성한 객체 삭제
            Destroy(newpipe, 5.0f);
        }
        
    }
}
