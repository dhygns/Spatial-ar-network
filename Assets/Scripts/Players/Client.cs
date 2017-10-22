using System.Collections;
using UnityEngine;

public class Client : MonoBehaviour
{

    private void Awake()
    {
        //Start Server
        SpatialClient.Start("192.168.219.105");


        //Regist Handler
        SpatialClient.RegisterHander(
            Protocol.Connected,
            (netMsg) =>
            {
                Debug.Log("Perfactly Connected");
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
