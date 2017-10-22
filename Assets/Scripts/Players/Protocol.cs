using System.Collections;
using System.Collections.Generic;
using UnityEngine.Networking;

//Header Protocol
public class Protocol : MsgType
{
    static public short Connected = MsgType.Connect;

    static public short SendTexture = MsgType.Highest + 1;
}

//Data protocol
public class DataType
{

    public class ClientInfo : MessageBase
    {
        public int clientId;
        public string clientIP;
    }

    public class Texture : MessageBase
    {
        public int width, height;
        public byte[] bytes;
    }
}