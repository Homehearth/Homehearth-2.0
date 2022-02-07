using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovementScript : MonoBehaviour
{
    // Start is called before the first frame update
    public float m_walkSpeed = 5.0f;
    public float m_rotateSpeed = 50.0f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Find players, for show only one exists.
        GameObject[] players = GameObject.FindGameObjectsWithTag("Player");
        transform.position = Vector3.MoveTowards(transform.position, players[0].transform.position, Time.deltaTime * m_walkSpeed);

        Vector3 targetDir = players[0].transform.position - transform.position;
        float singleStep = m_rotateSpeed * Time.deltaTime;
        Vector3 rotateTowards = Vector3.RotateTowards(transform.forward, targetDir, singleStep, 0.0f);

        transform.rotation = Quaternion.LookRotation(rotateTowards);
    }
}
