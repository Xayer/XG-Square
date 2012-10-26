using UnityEngine;
using System.Collections;

public class Missile : MonoBehaviour 
{
    public float MissileSpeed;

    private float Maxlifetime = 10;
	// Use this for initialization
	void Start () 
    {
        rigidbody.AddForce(transform.forward * MissileSpeed, ForceMode.Impulse);
        Destroy(gameObject, Maxlifetime);
	}

	
	// Update is called once per frame
	void Update () 
    {
	
	}
    void OnTriggerEnter(Collider otherObject)
    { 
        if (otherObject.tag == "Character")
        return;
        Destroy(Instantiate(GameManager.Instance.explosionParticles, 
            transform.position, transform.rotation),
            GameManager.Instance.explosionLifeTime);

        if (otherObject.GetComponent<EnemyBehaviour>() != null)
            otherObject.GetComponent<EnemyBehaviour>().Die();

        if (otherObject.GetComponent<Explosive>() != null)
            otherObject.GetComponent<Explosive>().Explode();
       
        //Play Explosion Sound
        AudioHandler.Instance.PlaySound(AudioHandler.Instance.explosion);

        Destroy(gameObject);
    }
}
