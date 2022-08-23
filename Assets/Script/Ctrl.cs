using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ctrl : MonoBehaviour
{
    public Transform LvL;
    public float Sens;
    private Vector3 _previousMousePosition;
      

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Vector3 delta = Input.mousePosition - _previousMousePosition;
            LvL.Rotate(0, -delta.x*Sens, 0);
           
        }
       
        _previousMousePosition = Input.mousePosition;
       
    }
}
