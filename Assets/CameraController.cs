using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    public float panCoefficient;
    public float zoomCoefficient;

    // Start is called before the first frame update
    void Start() {
        
    }

    // Update is called once per frame
    void Update() {

        transform.Translate(new Vector3(Input.GetAxis("hori")* panCoefficient, Input.GetAxis("vert") * panCoefficient, Input.GetAxis("scroll") * zoomCoefficient));

        Debug.Log(Input.GetAxis("scroll"));

        if (Input.GetKeyDown("space")) {
            transform.SetPositionAndRotation(new Vector3(0, 5, 0), Quaternion.Euler(90, 0, 0));
        }

    }
}
