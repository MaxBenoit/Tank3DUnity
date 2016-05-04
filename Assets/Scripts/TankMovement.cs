using UnityEngine;
using System.Collections;

public class TankMovement : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        //ManageMesh();
        if (Input.GetKey(KeyCode.A))
        {
            GetComponent<Transform>().Rotate(Vector3.up, -1f);
        }
        if (Input.GetKey(KeyCode.D))
        {
            GetComponent<Transform>().Rotate(Vector3.up, 1f);
        }
        if (Input.GetKey(KeyCode.W))
        {
            GetComponent<Rigidbody>().velocity = new Vector3(-5 * Mathf.Sin(GetComponent<Transform>().rotation.y), 0, -5 * Mathf.Cos(GetComponent<Transform>().rotation.y));
        }
        if (Input.GetKey(KeyCode.S))
        {
            GetComponent<Rigidbody>().velocity = new Vector3(5 * Mathf.Sin(GetComponent<Transform>().rotation.y), 0, 5 * Mathf.Cos(GetComponent<Transform>().rotation.y));
        }
	}

    void ManageMesh()
    {
        if (Input.mousePosition.x > Screen.width / 2 + Screen.width / 8)
        {
            GetComponentInChildren<Transform>().Rotate(Vector3.up, 1f);
        }
        else if (Input.mousePosition.x < Screen.width / 2 - Screen.width / 8)
        {
            GetComponentInChildren<Transform>().Rotate(Vector3.up, -1f);
        }

        if (Input.mousePosition.y > Screen.height / 2 + Screen.height / 8)
        {
            GetComponentInChildren<Transform>().Rotate(Vector3.right, 1f);
        }
        else if (Input.mousePosition.y < Screen.height / 2 - Screen.height / 8)
        {
            GetComponentInChildren<Transform>().Rotate(Vector3.right, -1f);
        }
    }
}
