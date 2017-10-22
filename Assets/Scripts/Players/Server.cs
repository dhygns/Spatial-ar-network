using System.Collections;
using UnityEngine;

public class Server : MonoBehaviour
{

    private void Awake()
    {
        SpatialServer.Start();

        SpatialServer.RegisterHander(
            Protocol.Connected,
            (netMsg) =>
            {
                DataType.ClientInfo info = new DataType.ClientInfo();
                info.clientId = netMsg.conn.connectionId;
                info.clientIP = netMsg.conn.address;
                Debug.Log("Perfactly Connected" + netMsg.conn.address);

                SpatialServer.Send(netMsg.conn.connectionId, Protocol.Connected, info);
            }
        );
    }

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
