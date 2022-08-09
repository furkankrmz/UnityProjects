using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveByTouch : MonoBehaviour
{
   // Update is called once per frame
    void Update()
    {
        /*
         *tr =nesneyi dokundu�umuz noktaya ta��ma
         *eng = move the object to the point where we touch it
        
        if(Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0); //paramatremiz ka� dokunu� sonra i�lemi ger�ekle�tirece�imizi belirtiyor
            Vector3 touchPosition = Camera.main.ScreenToWorldPoint(touch.position);
            touchPosition.z = 0f;
            transform.position = touchPosition;
        }*/
        for(int i = 0; i < Input.touchCount; i++)//don't forget to activate gizmos
        {
            Vector3 touchPosition = Camera.main.ScreenToWorldPoint(Input.touches[i].position);
            Debug.DrawLine(Vector3.zero, touchPosition, Color.red);
        }

    }
}
