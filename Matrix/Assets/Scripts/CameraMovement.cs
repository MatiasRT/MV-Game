using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour {
	[SerializeField] float speed;

	void Update () {
        /*Vector3 rot = Vector3.zero;
		rot += Vector3.right * Input.GetAxis ("Vertical") * Time.deltaTime * speed;
		rot += Vector3.up * Input.GetAxis ("Horizontal") * Time.deltaTime * speed;
		transform.Rotate (rot);
		Debug.Log (rot);*/

        //transform.Rotate (Input.acceleration.x, 0, -Input.acceleration.z);


        /* MOVIMIENTO PARA CELULAR */
        transform.rotation = Quaternion.Euler(new Vector3(0, transform.rotation.eulerAngles.y, (Input.acceleration.x) * 90.0f)); 

        /* MOVIMIENTO CON GIROSCOPIO PARA VR */
        

    }
}
