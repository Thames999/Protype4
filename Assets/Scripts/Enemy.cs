using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed;
    private GameObject playerOj;
    private Rigidbody enemyRb;    
    public SpawnManager spawnManager;

    // Start is called before the first frame update
    void Start()
    {
        playerOj = GameObject.Find("Player");
        enemyRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 lookDirection = ((playerOj.transform.position - transform.position).normalized * speed);
        enemyRb.AddForce(lookDirection);        
        
        if (transform.position.y < -10)
        {
            Destroy(gameObject);
        }
        
    }
}
