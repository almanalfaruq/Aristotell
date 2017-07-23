using UnityEngine;
using System.Collections;

public class Senapan : MonoBehaviour {
	int tap = 0;
	public GameObject kapow;
	public GameObject efekSenapan;
	public GameObject efekMusuh;
	public GameObject inggris;
	public GameObject pedang;
	public GameObject gun;
	public GameObject clue10;
	public GameObject slidebar;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseUpAsButton()
	{
		StartCoroutine (delayDor ());
		tap++;

		if (tap == 10	) {
			
			StartCoroutine (delayKapow ());

		}
	}

	IEnumerator delayDor()
	{
		efekMusuh.SetActive (true);
		efekSenapan.SetActive (true);
		AudioSource audio = GetComponent<AudioSource>();
		audio.Play ();
		yield return new WaitForSeconds (0.5f);
		efekMusuh.SetActive (false);
		efekSenapan.SetActive (false);

	}

	IEnumerator delayKapow()
	{
		kapow.SetActive (true);
		efekSenapan.SetActive (false);
		//inggris.SetActive (false);
		yield return new WaitForSeconds (2f);
		kapow.SetActive (false);
		gun.SetActive (false);
		//Destroy(slidebar);
		slidebar.SetActive(false);
		pedang.SetActive (true);
		yield return new WaitForSeconds (1f);
		clue10.SetActive (true);
		//yield break;

	}
}
