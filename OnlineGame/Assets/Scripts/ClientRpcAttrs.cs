using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class ClientRpcAttrs : NetworkBehaviour
{
    
    [Server]
    public void SendName(string name)
    {
        RpcReciveName(name);
    }
    [ClientRpc]//on all clients
    public void RpcReciveName(string name)
    {

    }
}
