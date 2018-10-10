using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sun : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    public float y;
    // Update is called once per frame
    void Update () {

        Transform transform = GetComponent<Transform>();
        Vector3 angle = new Vector3(0, y * Time.deltaTime, 0);
        transform.Rotate(angle);

    }
}
