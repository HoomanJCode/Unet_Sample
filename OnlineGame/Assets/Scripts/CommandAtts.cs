using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class CommandAtts : NetworkBehaviour
{
    [Client]
    private void SendName()
    {
        CmdReciveName("");
    }

    [Command(channel =1)]
    private void CmdReciveName(string name)
    {

    }
}
