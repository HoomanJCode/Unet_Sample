using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class SyncEventAttrs : NetworkBehaviour
{
    public delegate void teleport(Vector3 target);
    [SyncEvent]
    public event teleport EventTeleportEvent;

    private void Start()
    {
        EventTeleportEvent += SyncEventAttrs_TeleportEvent;
    }

    [Server]
    public void TeleportPlayerTo(Vector3 target)
    {
        if (EventTeleportEvent != null)
            EventTeleportEvent(target);
    }
    private void SyncEventAttrs_TeleportEvent(Vector3 target)
    {
        //must move player to target point
    }
}
