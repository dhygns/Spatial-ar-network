using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ImageObject : MonoBehaviour
{
    public enum OwnerType
    {
        Other, Player, Unknown
    }
    public OwnerType owner = OwnerType.Unknown;

    private void Awake()
    {
        
    }

    // Use this for initialization
    private void Start()
	{

	}

	// Update is called once per frame
	private void Update()
	{
			
	}

    //
    public OwnerType Owner
    {
        set {
            this.owner = value;
        }
    }

    public Texture2D Texture{
        set {
            this.GetComponent<MeshRenderer>().material.mainTexture = value;
        }
    }
}
