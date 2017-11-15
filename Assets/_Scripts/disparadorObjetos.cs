using UnityEngine;
using System.Collections;
public class disparadorObjetos : MonoBehaviour {
	public Transform Objeto;
	public float Seconds = 3;
	void Start () {
		StartCoroutine(CoroutineShoot());
	}

	IEnumerator CoroutineShoot () {
		while (true) {
			Shoot();
			yield return new WaitForSeconds(Seconds);
		}
	}

	void Shoot () {
		Instantiate(Objeto, transform.position, Quaternion.identity);
	}

}