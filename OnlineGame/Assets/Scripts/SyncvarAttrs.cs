using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class SyncvarAttrs : NetworkBehaviour
{
    public struct st
    {
        int a, b;
        Vector2 c;
        Quaternion d;
    }
    [SyncVar]
    public float health=100;
    //int 
    //bool
    //uint and other
    //vector3, quat ,gameobject(network identity)
    //struct with basic types

    [SyncVar(hook = "DataRecived")]
    public st data ;

    public void DataRecived(st data)//on client
    {
        //if using hooks, must set var manually
        this.data = data;
    }
    [Server]
    public void setHealth(int health=0)
    {
        this.health = health;
    }
}
