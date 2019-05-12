using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
public class MyNetworkManager : NetworkManager
{
    // Start is called before the first frame update
    NetworkClient connection;
    void Start()
    {
        
#if UNITY_SERVER
        StartServer();
            Debug.Log("Server started!");
#else
        connection = StartClient();
#endif
    }

    // Update is called once per frame
    void Update()
    {
    }
}
