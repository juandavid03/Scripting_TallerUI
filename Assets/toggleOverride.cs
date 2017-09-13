//Tomado y adaptado de https://forum.unity.com/threads/best-way-to-override-onclick-with-onpointerdown-for-toggle.390915/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class toggleOverride : Toggle
{
    public override void OnPointerClick(PointerEventData eventData)
    {
        //Vacio para que no haga nada en el click.
    }

    public override void OnPointerDown(PointerEventData eventData)
    {
        base.OnPointerDown(eventData);
        base.OnSubmit(eventData);
    }
}
