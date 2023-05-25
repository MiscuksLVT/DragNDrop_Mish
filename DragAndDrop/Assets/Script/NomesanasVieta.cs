using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.EventSystems;

public class NomesanasVieta : MonoBehaviour, IDropHandler{
	private float vietasZRot, velkObjZrot, rotacijaStarpiba;
	private Vector2 vietasIzm, VelkObjIzm;
	private float xIzmeruStarpm, yIzmeruStarp;
	public Objekti objektuScript;



    public void OnDrop(PointerEventData eventData)
    {
        if (eventData.pointerDrag!=null)
        {
            if (eventData.pointerDrag.tag.Equals(tag))
            {

            }
            else
            {

            }
        }
    }
}
