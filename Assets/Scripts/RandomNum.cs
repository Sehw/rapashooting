using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// 1���� 45������ ���� �߿� �ϳ��� ���� 6�� ��÷�Ѵ�
// ������ ���� �ߺ����� �ʰ� �̴´�.



//public class RandomNum : MonoBehaviour
//{
//    public int[] myNumbers = new int[6];
//    void Update()
//    {
//        // ���࿡ ���콺 ��ư�� ������ ���ڸ� �̴´�       
//        if (Input.GetMouseButtonDown(0))
//        {
//            // 6���� ���� ��÷�Ѵ�
//            for (int i = 0; i < myNumbers.Length; i++)
//            {
//                 // 1���� 45������ ���� �� �ϳ��� ��÷�Ѵ�.
//                int num = Random.Range(1, 46);

//                myNumbers[i] = num;

//                for (int j = 0; j < i; j++)
//                {
//                    if (myNumbers[i] == myNumbers[j])
//                    {
//                        //�ߺ� ����
//                        i--;
//                        break;
//                    }

//                }
//            }

//        }
//    }

//}
public class RandomNum : MonoBehaviour
{
    public int[] myNumbers = new int[6];
    void Update()
    {
        // ���࿡ ���콺 ��ư�� ������ ���ڸ� �̴´�       
        if (Input.GetMouseButtonDown(0))
        {
            myNumbers = LottoNum();

        }
    }

    int[] LottoNum()
    {
        //���� �迭
        int[] answer = new int[6];
        //���� ����Ʈ
        List<int> nums = new List<int>();

        //�� ����Ʈ�� 1���� 45������ ���ڸ� ��´�
        for (int i = 1; i < 46; i++)
        {
            nums.Add(i);
        }

        for (int i = 0; i < 6; i++)
        {
            //�� ���� ���� ���ڸ� �̴´�
            answer[i] = nums[Random.Range(0, nums.Count + 1)];
            //���� ���ڸ� ����Ʈ���� ���� �Ѵ�
            nums.Remove(answer[i]);
        }
        //���� �迭�� ��ȯ�Ѵ�.
        return answer;
    }
}
