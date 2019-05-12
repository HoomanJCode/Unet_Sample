using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class TargetRpcAttrs : NetworkBehaviour
{
    NetworkConnection con;
    [TargetRpc]
    public void Targetfunc1(NetworkConnection connection)
    {

    }
    [TargetRpc]
    public void Targetfunc2(NetworkConnection connection,string winnerName)
    {

    }
    [Server]
    private void SendWinner()
    {
        Targetfunc1(con);
        Targetfunc2(con,""); 
    }
}
