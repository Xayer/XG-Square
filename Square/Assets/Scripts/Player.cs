using UnityEngine;
using System.Collections;
    
public class Player : MonoBehaviour 
{
    public float Speed;
    public Vector3 Directions;

	// Use this for initialization
	void Start () 
    {

	}
	
	// Update is called once per frame
    void Update()
    {
        transform.Translate(Directions * Time.deltaTime);

        if (Input.GetKey(KeyCode.A))
           {
               Directions.x -= Speed;
            }

        else if (Input.GetKey(KeyCode.D))
            {
                Directions.x -= -Speed;
            }
        else if (Input.GetKey(KeyCode.W))
        {
            Directions.y -= -Speed;
        }
        else
        {
            Directions = Vector3.zero;
        }

    }
    

   
 
}
