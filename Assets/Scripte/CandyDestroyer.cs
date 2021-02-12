using UnityEngine;
using System.Collections;

public class CandyDestroyer : MonoBehaviour {

	public CandyHolder candyHolder;
	public int reward;
	public GameObject effectPrefab;
	public Vector3 effectRotation;

	void OnTriggerEnter(Collider other){

		if (other.gameObject.tag == "Candy") {
			Destroy (other.gameObject);
			candyHolder.AddCandy (reward);

			if (effectPrefab != null)
				Instantiate (effectPrefab, other.transform.position, Quaternion.Euler (effectRotation));
		}


	}
}
