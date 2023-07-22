using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetect : MonoBehaviour
{
    // Start is called before the first frame update
    float Health;
    public GameObject explosion;
    public GameObject explosionPosition;

    void Start()
    {
        explosionPosition = GameObject.Find("mixamorig:Hips");
        Health = GameObject.Find("Player").GetComponent<PlayerInformation>().PlayerHealth;
    }

    void OnCollisionEnter(Collision collisionInfo) 
    {
        if(collisionInfo.gameObject.layer == LayerMask.NameToLayer("Player"))
        {   
            Instantiate(explosion, explosionPosition.transform.position , transform.rotation);
            Health -= 2;
        }

        Debug.Log(explosionPosition.transform.position);

        Destroy(gameObject);
    }
}
