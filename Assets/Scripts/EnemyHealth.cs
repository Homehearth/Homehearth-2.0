using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    // Start is called before the first frame update
    private float m_health = 100.0f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(m_health <= 0)
        {
            GameObject.Destroy(gameObject);
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Bullet"))
        {
            // Lower health and destroy gameObject.
            m_health -= 50;
            GameObject.Destroy(collision.gameObject);
        }
    }
}
