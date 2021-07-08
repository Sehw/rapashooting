using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 사용자가 마우스 왼쪽 버튼을 클릭하면 총알을 생성하고 싶다.

// 만약에 마우스 왼쪽을 클릭하면
// 총알이 어디서 생성되고 싶다.
// 총알의 개수를 조절하고 싶다.(플레이어가 업그레이드를 하면 총알의 개수를 하나씩 증가하고 싶다)

public class PlayerFire : MonoBehaviour
{
    public GameObject bulletFactory;

    public GameObject firePosition;

    public float between = 8.0f;
    public int bulletCount = 1;

    // 총알을 담을 탄창 변수
    //public GameObject[] magazine = new GameObject[20];
    public List<GameObject> magazine = new List<GameObject>();
    public int magazineSize = 20;

    public GameObject wareHouse;

    // Start is called before the first frame update
    void Start()
    {
        // 탄창의 총알을 가득 채운다
        for(int i = 0; i < magazineSize; i++)
        {
            GameObject go = Instantiate(bulletFactory);
            //magazine[i] = go;
            magazine.Add(go);

            // 생성된 총알들을 비활성화한다.'
            go.SetActive(false);
            // 비활성화된 총알들을 창고에 자식 오브젝트로 등록한다.
            go.transform.parent = wareHouse.transform;

        }


    }

    // Update is called once per frame
    void Update()
    {
        //만약 내가 총알을 발사하고 싶어서 마우스 왼쪽 버튼을 누르면~
        if (Input.GetButtonDown("Fire1"))
        {
            ////총알을 생성한다.
            //gameobject bullet = instantiate(bulletfactory);
            //// 총구에서 총알이 나타난다.
            //bullet.transform.position = fireposition.transform.position;
            FireNormal();
        }
        
    }

    void FireNormal()
    {
        if (bulletFactory != null)
        {
            //비활성화 된 총알이 누군지 검색한다.
            //for (int i = 0; i < magazine.Length; i++)
            //{
            //    만일 활성화 되어 있다면
            //    if (!magazine[i].activeInHierarchy)
            //    {
            //        magazine[i].SetActive(true);
            //        magazine[i].transform.position = firePosition.transform.position;
            //        magazine[i].transform.rotation = Quaternion.Euler(new Vector3(0, 0, 0));
            //        break;
            //    }
            //}

            // 가장 첫번째 총알을 활성화한다.
            if(magazine.Count > 0)
            {
                magazine[0].SetActive(true);
                magazine[0].transform.position = firePosition.transform.position;
                // 활성화된 총알은 리스트로부터 제거한다.
                magazine.RemoveAt(0);
            }
        }
    }
    //void FireSpecial()쓰지마 쓰면 바로 팅김
    //{
    //    1.앵커를 최대 범위의 좌측(전체 범위 길이 * 0.5)으로 잡는다.
    //    Vector3 anchor = new Vector3(between * -0.5f, 1.2f, 0);

    //    2.앵커 위치로부터 이동 간격 = 전체 범위 / (총알 갯수 = 1)
    //    float term = between / (float)(bulletCount + 1);

    //    3.총알의 갯수만큼 반복해서 앵커 위치에서 이동 간격만큼 떨어진 곳에 총알을 생성한다.
    //    for (int i = 0; i < bulletCount; i++)
    //    {
    //        GameObject go = Instantiate(bulletFactory);
    //        go.transform.position = transform.position + anchor + new Vector3(term * (i = 1), 0, 0);
    //    }
    //}

    void FireSpecial2()
    {
        // 1. 전체 범위의 길이를 정한다.
        float range = between * (bulletCount - 1);

        // 2. 앵커를 최대 범위의 좌측으로 잡는다.
        Vector3 anchor = new Vector3(range * -0.5f, 1.2f, 0);

        // 3. 총알의 갯수만큼 반복해서 앵커 위치에서 이동 간격만큼 떨어진 곳에 총알을 생성한다.
        for (int i = 0; i < bulletCount; i++)
        {
            GameObject go = Instantiate(bulletFactory);
            go.transform.position = transform.position + anchor + new Vector3(between * i, 0, 0);
        }
    }
    
    

}
