using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
[NetworkSettings(channel =1,sendInterval =0.4f)]
public class NetworkedPlayerManager : NetworkBehaviour
{
    public static NetworkedPlayerManager myPlayer;
    [SerializeField]
    private Animator animator;
    [SyncVar]
    private Vector3 recivedPosition;
    [SyncVar]
    private bool pressedInputs;
    void Start()
    {
        if (isLocalPlayer)
            myPlayer = this;
    }
    // Update is called once per frame
    void Update()
    {
        if (isLocalPlayer)
        {
            CmdRecivedInputs(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"),
                Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D));
        }
        if (isClient)
        {
            transform.position = Vector3.Lerp(transform.position, recivedPosition, Time.deltaTime * 2);
            animator.SetBool("Moving", pressedInputs);
        }
        if (pressedInputs)
        {
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.LookRotation(recivedPosition - transform.position), Time.deltaTime * 5);
        }
    }
    private Vector3 targetPoint;
    [Command]
    private void CmdRecivedInputs(float hor, float ver, bool pressed)
    {
        targetPoint.x = hor;
        targetPoint.z = ver;
        transform.position += -targetPoint / 4;
        recivedPosition = transform.position;
        pressedInputs = pressed;
    }
}
