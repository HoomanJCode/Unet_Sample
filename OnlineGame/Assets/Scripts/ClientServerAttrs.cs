using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class ClientServerAttrs : NetworkBehaviour
{
    [Client]
    public void SendPosition()
    {

    }
    [ClientCallback]
    public void SendPosition2()
    {

    }
    [Server]
    public void CalcPosition()
    {

    }
    [ServerCallback]
    public void CalcPosition2()
    {

    }
    private void Start()
    {
        SendPosition2();//running on client
        CalcPosition2();//running at server
    }
}
