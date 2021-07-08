using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemyFactory : MonoBehaviour
{
    // 지정된 시간마다 에너미를 생성하고 싶다

    public GameObject enemySource;
    public float delayTime = 2.0f;

    float ccrrentTime = 0;

    // 현재 시간을 체크해서 지정된 시간이 되었는지 확인한다.
    // enemyfactory의 위치와 동일한 위치에 에너미를 생성한다.

    // 나의 위치와 동일한 위치에 에너미를 생성한다.
    // 현재 시간을 초기화한다.

    // 직전 프레임으로부터 현재 프레임까지 걸린 시간을 현재 시간 변수에 누적한다.

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
