using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ������� �Է��� �޾Ƽ� ���� �Ǵ� �¿�� �̵��ϰ� �ʹ�.
// ����� �Է�: �¿� ȭ��ǥ Ű, ���� ȭ��ǥ Ű, WASD Ű
// �̵� �ʿ� ���: �ӵ�(����, �ӷ�), �ð�



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
    //    //    print("���� ȭ��ǥ Ű �Է���...");
    //    //}

    //    float h = Input.GetAxisRaw("Horizontal");
    //    float v = Input.GetAxisRaw("Vertical");

    //    Vector3 direction = new Vector3(h, v, 0);

    //    direction.Normalize();


    //    // direction�� ������ ������ �̵��ϰ� �ʹ�.
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

    //    // ���� Shift Ű�� ���� ������ ������ �ӵ��� 2��� �����Ѵ�.
    //    // ���� Shift Ű���� ���� ���� �ٽ� ���� �ӵ���� ���ƿ´�.

    //    // 1. ���࿡ Shift Ű�� ���ȴٸ�
    //    //if (Input.GetKey(KeyCode.LeftShift))
    //    //{
    //    //    2.�����ִ� ���� moveSpeed�� ���� 2��� �Ѵ�.
    //    //    transform.position += direction * (2 * moveSpeed) * Time.deltaTime;

    //    //}
    //    //����Ʈ Ű ������ �ٽ� ��������
    //    //else
    //    //{
    //    //    transform.position += direction * moveSpeed * Time.deltaTime;

    //    //}
    //    //if (Input.GetKeyDown(KeyCode.LeftShift))
    //    //{
    //    //    // 2. �����ִ� ���� moveSpeed�� ���� 2��� �Ѵ�.
    //    //    moveSpeed = moveSpeed * 2;

    //    //}
    //    //// ����Ʈ Ű ������ �ٽ� ��������
    //    //else if (Input.GetKeyUp(KeyCode.LeftShift))
    //    //{
    //    //    moveSpeed = moveSpeed / 2;

    //    //}
    //    //transform.position += direction * moveSpeed * Time.deltaTime;
        

    //}
}
