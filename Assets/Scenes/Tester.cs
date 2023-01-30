using System.Collections;
using System.Collections.Generic;
using TouchSocket.Core;
using TouchSocket.Rpc.TouchRpc;
using TouchSocket.Sockets;
using UnityEngine;

public class Tester : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        TcpTouchRpcClient client = new TcpTouchRpcClient();
        client.Setup(new TouchSocketConfig()
            .SetRemoteIPHost("192.168.3.108:7790")
            .SetVerifyToken("FFDRpc"));
        client.Connect();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
