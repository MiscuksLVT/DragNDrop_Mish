using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragAndDrop : MonoBehaviour,IBeginDragHandler,IDragHandler,IEndDragHandler {
    //Uzglat noradi uz objelkti skriptu\
    public Objekti objektiSkripts;
    //Uzglaba noradi uz katra objekta CanvasGroup
    private CanvasGroup kanvasGrupa;
    private RectTransform velkObjektutransf;

    void Start()
    {
        kanvasGrupa = GetComponent<CanvasGroup>();
        velkObjektutransf= GetComponent<RectTransform>();

    }


    public void OnBeginDrag(PointerEventData eventData)
    {
        objektiSkripts.pedejaisVilktais = null;
        kanvasGrupa.alpha = 0.6f;
        kanvasGrupa.blocksRaycasts= false;
    }

    public void OnDrag(PointerEventData eventData)
    {
        velkObjektutransf.anchoredPosition += eventData.delta / objektiSkripts.kanva.scaleFactor;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        objektiSkripts.pedejaisVilktais = eventData.pointerDrag;
        kanvasGrupa.alpha = 1f;
        if (objektiSkripts.vaiIstajaVieta == false)
            kanvasGrupa.blocksRaycasts = true;
        else
            objektiSkripts.pedejaisVilktais = null;
        objektiSkripts.vaiIstajaVieta = false;


    }

  
	
	
}
