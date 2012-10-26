using UnityEngine;
using System.Collections;

public class Shooting : MonoBehaviour 
{
    public GameObject MissilePrefab;

    private Transform crosshairTransform;
    private Transform rocketlauncherTransform;

	// Use this for initialization
	void Start () 
    {
        Screen.showCursor = false;
        crosshairTransform = GameObject.Find("Crosshair").transform;
        rocketlauncherTransform = GameObject.Find("RocketLauncher").transform;
	}
	
	// Update is called once per frame
	void Update () 
    {
        MoveCrosshairandRocketLauncher();
        CheckInput();
	}
    void MoveCrosshairandRocketLauncher()
    {
     
        Vector3 MousePos = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x,Input.mousePosition.y,Mathf.Abs(Camera.main.transform.position.z)));

        crosshairTransform.position = new Vector3(MousePos.x, MousePos.y, crosshairTransform.position.z);
        rocketlauncherTransform.LookAt(new Vector3(MousePos.x, MousePos.y, rocketlauncherTransform.position.z));
    }

    void CheckInput()
    {
        if(Input.GetMouseButton(0))
        {
            {

                //Increment speed variable (Remember Time.DeltaTime)

            }

            {
                if (Input.GetMouseButtonUp(0))
                {
                    GameObject missile= 
                        Instantiate(MissilePrefab, 
                        rocketlauncherTransform.position, 
                        rocketlauncherTransform.rotation) as GameObject;
                    //Assign speed variable to missile speed

                    missile.GetComponent<Missile>().MissileSpeed = 10;

                    //Reset missile speed
                }

            }
        }
    }
}
