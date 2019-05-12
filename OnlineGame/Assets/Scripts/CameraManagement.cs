using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManagement : MonoBehaviour
{
    private Vector3 target
    {
        get
        {
            if (NetworkedPlayerManager.myPlayer == null)//player not spawned
                return transform.position;
            return NetworkedPlayerManager.myPlayer.transform.position;
        }
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, target, Time.deltaTime);
    }
}
