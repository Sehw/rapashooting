using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    // 1. ������ ��������. ���.......................................................................................................................................................................................

    // 2. �÷��̾ �ִ� ��ġ�� ���ؼ� �̵��Ѵ�.


    // ������ ��� �ӷ� ���� �ð�
    public float speed = 1;

    public int probability = 70;

    GameObject player;

    // 0���̸� ��������, 1���̸� �i�ư���
    int selection = 0;


    // Start is called before the first frame update
    void Start()
    {
         player = GameObject.Find("Player");

        // Ȯ���� ���� 1�� �Ǵ� 2���� �̵� ����� ����Ѵ�.
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
            // �¾�� �� ��� �� ������ ��������...................................................��������!
            transform.position += Vector3.down * speed * Time.deltaTime;
        }
        else
        {
            // �÷��̾��� ��ġ�� ã�Ƽ� ���� �̵��������� �����Ѵ�.
            // �÷��̾� ã��

            // �̵��� ������ �÷��̾��� ��ġ�� ����
            Vector3 dir = player.transform.position - transform.position;
            dir.Normalize();
            // �� ������ ��ġ�� �̵��Ѵ�
            transform.position += dir * speed * Time.deltaTime;
        }

        
    }
}
