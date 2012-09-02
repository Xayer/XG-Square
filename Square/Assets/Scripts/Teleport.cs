using UnityEngine;
using System.Collections;

public class Teleport : MonoBehaviour {

    public GameObject TeleportTwo;

	// Use this for initialization
	void Start () 
    {
	
	}

    void OnTriggerEnter(Collider otherObject)
    {
        if (otherObject.tag == "Character") 
            otherObject.gameObject.transform.position = new Vector3(TeleportTwo.transform.position.x + 2, TeleportTwo.transform.position.y + 2, TeleportTwo.transform.position.z);
        
        if (otherObject.tag == "Missile")
            otherObject.gameObject.transform.position = new Vector3(TeleportTwo.transform.position.x, TeleportTwo.transform.position.y + 1, TeleportTwo.transform.position.z);
    }
	// Update is called once per frame
	void Update () 
    {
	
	}
}
