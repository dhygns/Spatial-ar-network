using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ImageObjectManager : MonoBehaviour
{

    //for Singleton
    static private ImageObjectManager _instance = null;

    //for prefab creating
    public GameObject PrefabImageObject;

    void Start() 
    {
        
    }

    void Update()
    {

    }

    public void _createObject(Texture2D tex) {
        Instantiate(PrefabImageObject,this.transform);

    }



    //interface for singleton
    static private ImageObjectManager instance {
        get
        {
            if (_instance == null) _instance = new ImageObjectManager();
            return _instance;
        }
    }

    static public void CreateObject(Texture2D tex)
    {
        instance._createObject(tex);
    }


}
