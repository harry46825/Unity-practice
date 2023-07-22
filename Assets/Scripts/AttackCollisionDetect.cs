using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetect : MonoBehaviour
{
    // Start is called before the first frame update
    float Health;
    public GameObject explosion;

    void Start()
    {
        Health = GameObject.Find("Player").GetComponent<PlayerInformation>().PlayerHealth;
    }

    void OnCollisionEnter(Collision collisionInfo) 
    {
        if(collisionInfo.gameObject.layer == LayerMask.NameToLayer("Player"))
        {   
            Instantiate(explosion, collisionInfo.collider.transform.position , collisionInfo.collider.transform.rotation);
            Health -= 2;
            
        }

        Destroy(gameObject);
    }
}
