using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject m_enemy;

    public Transform[] m_spawnPoints = new Transform[4];

    void Start()
    {
        // Spawn an enemy at each spawn point.
        for(int i = 0; i < 4; i++)
        {
            Instantiate(m_enemy, m_spawnPoints[i]);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
