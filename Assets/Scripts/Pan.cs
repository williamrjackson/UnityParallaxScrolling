using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pan : MonoBehaviour {
    public float speed = 0.25f;
	void Update () {
        transform.position += transform.right * speed * Time.deltaTime;
	}
}
