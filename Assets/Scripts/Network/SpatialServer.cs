using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class SpatialServer
{

    //instance for Singleton
    static private SpatialServer _instance;

    //creator
    private SpatialServer()
    {
        Debug.Log("Created Server");
    }


    //init for server port
    private void initialize()
    {
        //initial
        Debug.Log("Listening at " + Network.player.ipAddress + ":" + 8080);
        NetworkServer.Listen(8080);
    }

    // Use this for initialization
    //void Start () {


    //}

    // Update is called once per frame
    //void Update () {
    //       //if(Input.GetKeyDown("q")) {
    //       //    Debug.Log("clicked");
    //       //    byte[] bytes = new byte[] {
    //       //        255, 0, 0, 255, 0, 255, 0, 255,
    //       //        0, 0, 255, 255, 0, 0, 0, 255
    //       //    };

    //       //    SpatialProtocol.Body.Texture msg = new SpatialProtocol.Body.Texture();
    //       //    msg.width = 2; msg.height = 2; msg.texArray = bytes;

    //       //    NetworkServer.SendToAll(SpatialProtocol.Head.SendTexture, msg);
    //       //}
    //}

    //interface for singleton
    static private SpatialServer instance
    {
        get
        {
            if (_instance == null) _instance = new SpatialServer();
            return _instance;
        }
    }

    static public void Start()
    {
        instance.initialize();
    }

    static public void Send(int id, short head, MessageBase data)
    {
        NetworkServer.SendToClient(id, head, data);
    }

    static public void SendToAll(short head, MessageBase data)
    {
        NetworkServer.SendToAll(head, data);
    }

    static public void RegisterHander(short e, NetworkMessageDelegate todo)
    {
        NetworkServer.RegisterHandler(e, todo);
    }
}
