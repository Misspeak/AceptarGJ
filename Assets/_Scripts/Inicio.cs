using UnityEngine;
using System.Collections;

public class Inicio : MonoBehaviour {


	// Update is called once per frame
	void Update () {
		if (Input.anyKey) {
			Application.LoadLevel ("0.1 Negacion");
		}
	}
}
