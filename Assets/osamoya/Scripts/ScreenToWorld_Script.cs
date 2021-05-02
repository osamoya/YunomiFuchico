using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ScreenToWorld_Script : MonoBehaviour, IPointerClickHandler
{
    public void OnPointerClick(PointerEventData eventData)
    {
        //throw new System.NotImplementedException();
        Debug.Log(gameObject.name + " がクリックされた!");
    }

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("HelloWorld!");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
