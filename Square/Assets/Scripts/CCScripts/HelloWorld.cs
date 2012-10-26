using UnityEngine;
using System.Collections;

public class HelloWorld : MonoBehaviour {

	// Use this for initialization
	void Start () 
    {
        writetwotimes("Bitch Please");

	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void writetwotimes(string message )
    {
        Debug.Log(message);
        Debug.Log(message);
    }

}
