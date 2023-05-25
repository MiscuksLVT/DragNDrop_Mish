using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objekti : MonoBehaviour {
	public GameObject atkritumuMasina;
	public GameObject atrakaPalidziba;
	public GameObject autobuss;

	[HideInInspector]
	public Vector2 atkrMKord;
	[HideInInspector]
	public Vector2 atraPKord;
	[HideInInspector]
	public Vector2 autobussKord;

	public Canvas kanva;

	public AudioSource audioAvots;
	public AudioClip[] skanasKoAtskanot;
	[HideInInspector]
	public bool vaiIstajaVieta=false;
	public GameObject pedejaisVilktais =null;


	void Start () {
		atkrMKord = atkritumuMasina.GetComponent<RectTransform>().localPosition;
        atraPKord = atrakaPalidziba.GetComponent<RectTransform>().localPosition;
        autobussKord = autobuss.GetComponent<RectTransform>().localPosition;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
