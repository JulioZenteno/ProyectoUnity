using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class DropHandler : MonoBehaviour, IDropHandler, IPointerEnterHandler, IPointerExitHandler {

    public void OnDrop(PointerEventData eventData) {
        Draggable DropZone = eventData.pointerDrag.GetComponent<Draggable>();
        if (DropZone != null)
        {
            DropZone.InitialParent = this.transform;

        }
    }

    public void OnPointerEnter(PointerEventData eventData) {

    }

    public void OnPointerExit(PointerEventData eventData) {

      
    }
}
