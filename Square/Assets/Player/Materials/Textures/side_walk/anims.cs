using UnityEngine;
using System.Collections;

public class MYCLASSNAME : MonoBehaviour 
{

Texture2D[] Walk;
public var framesPerSecond= 10.0f;
public 

	void  Update ()
{
    
	int index = Time.time * framesPerSecond;
    index = index % Walk.Length;
    renderer.material.mainTexture = Walk[index];
}
}