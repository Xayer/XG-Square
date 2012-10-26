using UnityEngine;
using System.Collections;

public class BoxSpawner : MonoBehaviour 
{
    public GameObject BlackBox;
    public GameObject BlueBox;
    public GameObject GreenBox;
    public GameObject RedBox;
    public GameObject WhiteBox;
    public GameObject YellowBox;

	// Use this for initialization
	void Start () 
    {

	}
	
	// Update is called once per frame
	void Update () 
    {
            if (Input.GetKeyDown(KeyCode.T))
        {
            Instantiate(BlackBox, new Vector3(15, 5, 0.9F), transform.rotation);
        }
            if   (Input.GetKeyDown(KeyCode.Y))
        {
            Instantiate(BlueBox, new Vector3(15, 5, 0.9F), transform.rotation);
        }
            if    (Input.GetKeyDown(KeyCode.U))
        {
            Instantiate(GreenBox, new Vector3(15, 5, 0.9F), transform.rotation);
        }
            if    (Input.GetKeyDown(KeyCode.I))
        {
            Instantiate(RedBox, new Vector3(15, 5, 0.9F), transform.rotation);
        }
            if   (Input.GetKeyDown(KeyCode.O))
        {
            Instantiate(WhiteBox, new Vector3(15, 5, 0.9F), transform.rotation);
        }
            if (Input.GetKeyDown(KeyCode.P))
        {
            Instantiate(YellowBox, new Vector3(15, 5, 0.9F), transform.rotation);
        }
	}
}
