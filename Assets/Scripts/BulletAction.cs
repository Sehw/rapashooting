using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletAction : MonoBehaviour
{
    // 나는 생성되면 그냥 위쪽으로 쭉 갈란다...
    // 생성되면 위로 계속 나아간다...

    public float bulletSpeed = 10;
    public GameObject col;

    // 부딪힌 대상이 Enemy라면 폭발 이펙트 오브젝트를 생성한 뒤 이펙트를 실행한다

    public GameObject explosionPrefab;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = new Vector3(0, 1, 0);

        transform.position += direction * bulletSpeed * Time.deltaTime;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (col.gameObject.tag == "Enemy")
        {
            
            GameObject go = Instantiate(explosionPrefab, col.transform.position, Quaternion.identity);
            ParticleSystem ps = go.GetComponent<ParticleSystem>();
            ps.Play();

            Collider[] cols = Physics.OverlapSphere(transform.position, 6.0f, 1<<8);

            for (int i = 0; i < cols.Length; i++)
            {
                Destroy(cols[i].gameObject);
            }


            Destroy(gameObject);
        }
    }
}

