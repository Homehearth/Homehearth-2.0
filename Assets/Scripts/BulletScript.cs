using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector3 m_direction = new Vector3();
    public float m_speed = 10.0f;
    private float m_lifeTime = 0.5f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Move in direction of player.
        transform.position += m_direction * m_speed;
        m_lifeTime -= Time.deltaTime;

        // Destroy when life time is exceeded.
        if(m_lifeTime < 0.0f)
        {
            GameObject.Destroy(gameObject);
        }
    }
}
