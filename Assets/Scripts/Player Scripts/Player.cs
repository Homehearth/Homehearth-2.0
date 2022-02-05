using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float m_walkSpeed = 10.0f;
    public float m_rotationSpeed = 5.0f;
    public GameObject m_bullet;
    private float m_reloadTime = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.forward * Input.GetAxis("Vertical") * m_walkSpeed * Time.deltaTime;
        transform.Rotate(0.0f, Input.GetAxis("Horizontal") * m_rotationSpeed * Time.deltaTime, 0.0f);

        // Shoot!
        if(Input.GetAxis("Jump") > 0 && m_reloadTime <= 0.0f)
        {
            Instantiate(m_bullet, transform.position, Quaternion.identity).GetComponent<BulletScript>().m_direction  = transform.forward;

            m_reloadTime = 0.75f;
        }
        else
        {
            m_reloadTime -= Time.deltaTime;
        }

    }
}
