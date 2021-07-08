using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletAction : MonoBehaviour
{
    // ���� �����Ǹ� �׳� �������� �� ������...
    // �����Ǹ� ���� ��� ���ư���...

    public float bulletSpeed = 10;
    public GameObject col;

    // �ε��� ����� Enemy��� ���� ����Ʈ ������Ʈ�� ������ �� ����Ʈ�� �����Ѵ�

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

