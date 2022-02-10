using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    private Camera mainCamera;
    public GameObject player;
    [Range (0, 20)]
    public float distanceOffset = 10;

    private void Awake()
    {
        mainCamera = GetComponent<Camera>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 playerPos = player.transform.position;
        mainCamera.transform.position = new Vector3(playerPos.x, playerPos.y + distanceOffset, playerPos.z - 8.7f);
        mainCamera.transform.LookAt(player.transform);
    }
}
