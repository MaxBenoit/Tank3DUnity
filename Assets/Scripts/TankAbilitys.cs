using UnityEngine;
using System.Collections;

public class TankAbilitys : MonoBehaviour {
    public GameObject bullet;
    Rigidbody rigidbody;
	// Use this for initialization
	void Start () 
    {
        rigidbody = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () 
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(bullet, new Vector3(rigidbody.position.x, rigidbody.position.y + 1, rigidbody.position.z), Quaternion.Euler(new Vector3(rigidbody.rotation.eulerAngles.x, rigidbody.rotation.eulerAngles.y - 90f, rigidbody.rotation.eulerAngles.z)));
        }
	}
}
