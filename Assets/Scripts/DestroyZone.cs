using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyZone : MonoBehaviour
{
    public PlayerFire pFire;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name != "Player")
        {

            if(collision.gameObject.name == "Bullet(Clone)")
            {
                collision.gameObject.SetActive(false);

                pFire.magazine.Add(collision.gameObject);
            }
        }
    }

}
