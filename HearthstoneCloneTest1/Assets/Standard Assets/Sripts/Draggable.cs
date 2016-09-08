using UnityEngine;
using UnityEngine.EventSystems;



public class Draggable : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler{

    public Transform InitialParent = null;

    public void OnBeginDrag(PointerEventData eventData) {
        InitialParent = this.transform.parent;
        this.transform.SetParent(this.transform.parent.parent);
        GetComponent<CanvasGroup>().blocksRaycasts = false;
        
     }

    public void OnDrag(PointerEventData eventData) {
        this.transform.position = eventData.position;
    }

    public void OnEndDrag(PointerEventData eventData) {
        this.transform.SetParent( InitialParent );
        GetComponent<CanvasGroup>().blocksRaycasts = true;
    }


}
