using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 사용자의 입력을 받아서 상하 또는 좌우로 이동하고 싶다.
// 사용자 입력: 좌우 화살표 키, 상하 화살표 키, WASD 키
// 이동 필요 요소: 속도(방향, 속력), 시간



public class PlayerMove : MonoBehaviour
{
    public float moveSpeed = 0.1f;
    float finalSpeed;
    

    //// Start is called before the first frame update
    //void Start()
    //{
        
    //}

    //// Update is called once per frame
    //void Update()
    //{
    //    //if (input.getkeydown(keycode.uparrow))
    //    //{
    //    //    print("윗쪽 화살표 키 입력중...");
    //    //}

    //    float h = Input.GetAxisRaw("Horizontal");
    //    float v = Input.GetAxisRaw("Vertical");

    //    Vector3 direction = new Vector3(h, v, 0);

    //    direction.Normalize();


    //    // direction에 정해진 방향대로 이동하고 싶다.
    //    // p = pO + vt

    //    if (Input.GetKeyDown(KeyCode.LeftShift))
    //    {
    //        finalSpeed = moveSpeed * 2;
    //    }

    //    else if (Input.GetKeyUp(KeyCode.LeftShift))
    //    {
    //        finalSpeed = moveSpeed;
    //    }

    //    Vector3 arrivePos = transform.position * direction * finalSpeed * Time.deltaTime;

    //    Ray ray = new Ray(transform.position, direction);
    //    RaycastHit hitInfo;

    //    if (Physics.Raycast(ray,out hitInfo, arrivePos.magnitude))
    //    {
    //        transform.position = hitInfo.point;
    //    }
    //    else
    //    {
    //        rb.velocity = direction * finalSpeed;
    //    }

    //    // 좌측 Shift 키를 누른 상태일 때에는 속도가 2배로 증가한다.
    //    // 좌측 Shift 키에서 손을 떼면 다시 원래 속도대로 돌아온다.

    //    // 1. 만약에 Shift 키가 눌렸다면
    //    //if (Input.GetKey(KeyCode.LeftShift))
    //    //{
    //    //    2.눌려있는 동안 moveSpeed의 값을 2배로 한다.
    //    //    transform.position += direction * (2 * moveSpeed) * Time.deltaTime;

    //    //}
    //    //쉬프트 키 놓으면 다시 돌려놓기
    //    //else
    //    //{
    //    //    transform.position += direction * moveSpeed * Time.deltaTime;

    //    //}
    //    //if (Input.GetKeyDown(KeyCode.LeftShift))
    //    //{
    //    //    // 2. 눌려있는 동안 moveSpeed의 값을 2배로 한다.
    //    //    moveSpeed = moveSpeed * 2;

    //    //}
    //    //// 쉬프트 키 놓으면 다시 돌려놓기
    //    //else if (Input.GetKeyUp(KeyCode.LeftShift))
    //    //{
    //    //    moveSpeed = moveSpeed / 2;

    //    //}
    //    //transform.position += direction * moveSpeed * Time.deltaTime;
        

    //}
}
