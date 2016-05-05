using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour 
{
    Rigidbody rigidbody;
	// Use this for initialization
	void Start () 
    {
        rigidbody = GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void FixedUpdate () 
    {
        Vector3 movement = transform.right * 20f * Time.deltaTime;
        rigidbody.MovePosition(rigidbody.position - movement);
	}

    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.name == "Terrain")
        {
            Destroy(gameObject);
        }
    }
}
