using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour {

    Vector3 spin;


    // Update is called once per frame
    void Update () {
        spin = new Vector3(5f, 5f, 0f);

        transform.Rotate(spin);
	}
}
