using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    // 1. 밑으로 내려간다. 계속.......................................................................................................................................................................................

    // 2. 플레이어가 있는 위치를 항해서 이동한다.


    // 움직임 요소 속력 방향 시간
    public float speed = 1;

    public int probability = 70;

    GameObject player;

    // 0번이면 내려가기, 1번이면 쫒아가기
    int selection = 0;


    // Start is called before the first frame update
    void Start()
    {
         player = GameObject.Find("Player");

        // 확률에 따라 1번 또는 2번의 이동 방식을 사용한다.
        int draw = Random.Range(1, 101);

        if(draw < probability)
        {
            selection = 0;
        }
        else
        {
            selection = 1;
        }

    }

    // Update is called once per frame
    void Update()
    {

        if (selection == 0)
        {
            // 태어나면 그 즉시 쭉 밑으로 내려간다...................................................멈추지마!
            transform.position += Vector3.down * speed * Time.deltaTime;
        }
        else
        {
            // 플레이어의 위치를 찾아서 적의 이동방향으로 설정한다.
            // 플레이어 찾기

            // 이동할 방향을 플레이어의 위치로 설정
            Vector3 dir = player.transform.position - transform.position;
            dir.Normalize();
            // 그 설정한 위치로 이동한다
            transform.position += dir * speed * Time.deltaTime;
        }

        
    }
}
