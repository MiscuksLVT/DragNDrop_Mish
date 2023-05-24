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

    }

    public void OnDrag(PointerEventData eventData)
    {

    }

    public void OnEndDrag(PointerEventData eventData)
    {

    }

  
	
	
}
