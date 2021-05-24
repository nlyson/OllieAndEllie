using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;
    public float minZoom = 5.0f;
    public float maxZoom = 15.0f;
    public float offset = 10.0f;
    public float deltaOffset = 5.0f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(player.transform.position.x, offset, player.transform.position.z - offset);

        if( Input.GetKeyUp(KeyCode.Z))
        {
            offset += deltaOffset;
            if (offset > maxZoom)
                offset = minZoom;
        }

    }




}
