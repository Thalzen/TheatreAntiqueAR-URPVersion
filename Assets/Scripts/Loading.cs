using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Loading : MonoBehaviour
{
    public UnityEvent use;
    

    public void Use()
    {
        use.Invoke();
        
    }
}
