using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class WhenTouch : MonoBehaviour,IPointerDownHandler {

    public static bool isTouch = false;
    public void OnPointerDown(PointerEventData eventData)
    {
        if (gameObject.name == "Button")
            isTouch = true;
    }
    public bool getTouch()
    {
        return isTouch;
    }
    public void setTouch()
    {
        isTouch = false;
    }
   
    // Use this for initialization
    void Start () {
    
  }
  
  // Update is called once per frame
  void Update () {
    
  }
}
