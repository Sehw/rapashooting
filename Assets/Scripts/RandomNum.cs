using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// 1에서 45까지의 정수 중에 하나의 값을 6번 추첨한다
// 각각의 값이 중복되지 않게 뽑는다.



//public class RandomNum : MonoBehaviour
//{
//    public int[] myNumbers = new int[6];
//    void Update()
//    {
//        // 만약에 마우스 버튼을 누르면 숫자를 뽑는다       
//        if (Input.GetMouseButtonDown(0))
//        {
//            // 6개의 수를 추첨한다
//            for (int i = 0; i < myNumbers.Length; i++)
//            {
//                 // 1부터 45까지의 숫자 중 하나를 추첨한다.
//                int num = Random.Range(1, 46);

//                myNumbers[i] = num;

//                for (int j = 0; j < i; j++)
//                {
//                    if (myNumbers[i] == myNumbers[j])
//                    {
//                        //중복 상태
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
        // 만약에 마우스 버튼을 누르면 숫자를 뽑는다       
        if (Input.GetMouseButtonDown(0))
        {
            myNumbers = LottoNum();

        }
    }

    int[] LottoNum()
    {
        //정답 배열
        int[] answer = new int[6];
        //숫자 리스트
        List<int> nums = new List<int>();

        //넘 리스트에 1부터 45까지의 숫자를 담는다
        for (int i = 1; i < 46; i++)
        {
            nums.Add(i);
        }

        for (int i = 0; i < 6; i++)
        {
            //그 중의 랜덤 숫자를 뽑는다
            answer[i] = nums[Random.Range(0, nums.Count + 1)];
            //뽑은 숫자를 리스트에서 제거 한다
            nums.Remove(answer[i]);
        }
        //정답 배열을 반환한다.
        return answer;
    }
}
