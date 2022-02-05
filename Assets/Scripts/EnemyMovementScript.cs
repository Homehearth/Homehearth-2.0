using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovementScript : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform m_player;
    public float m_walkSpeed = 5.0f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, m_player.transform.position, Time.deltaTime * m_walkSpeed);
    }
}
