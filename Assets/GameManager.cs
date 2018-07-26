using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if(Input.GetMouseButtonDown(0)){

			print("Mouse clicked!");

			RaycastHit hit;
			Ray ray = Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0f));

			print(ray.origin);

			if(Physics.Raycast(ray, out hit, 100.0f)){
				if(hit.transform != null ){

					GameObject touchedObj = hit.transform.gameObject;
					print(touchedObj.name);
					touchedObj.SetActive(false);


				}

			}

		}
	}
}
