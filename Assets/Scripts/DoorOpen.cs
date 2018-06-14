using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpen : MonoBehaviour
{
    bool isDoorOpen = false;

	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (isDoorOpen)
                this.transform.Translate(0, -4, 0);
            else
                this.transform.Translate(0, 4, 0);
            isDoorOpen = !isDoorOpen;
        }
            
       
	}
}
