using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class SpatialClient
{
    //singleton instance
    static private SpatialClient _instance = null;


    //it's needed for connecing network.
    private NetworkClient network = null;


    //Creator
    private SpatialClient()
    {
    }
    //private void todoGotTexture(NetworkMessage netMsg)
    //{
    //    SpatialBody.Texture msg = netMsg.ReadMessage<SpatialBody.Texture>();
    //    Texture2D tex = new Texture2D(msg.width, msg.height, TextureFormat.RGBA32, false);
    //    tex.LoadRawTextureData(msg.texArray);
    //    tex.Apply();

    //    //ImageObject.
    //}


    private void initialize(string ipAddress)
    {
        //network connect to server
        network = new NetworkClient();
        network.Connect(ipAddress, 8080);
    }


    // instance object for singleton
    static private SpatialClient instance
    {
        get
        {
            if (_instance == null) _instance = new SpatialClient();
            return _instance;
        }
    }

    //interface for singleton
    static public void Start(string ipAddress)
    {
        instance.initialize(ipAddress);
    }

    static public void Send(short head, MessageBase data)
    {
        instance.network.Send(head, data);
    }

    static public void RegisterHander(short e, NetworkMessageDelegate todo)
    {
        instance.network.RegisterHandler(e, todo);
    }

}
