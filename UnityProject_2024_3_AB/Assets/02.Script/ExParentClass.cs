using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExParentClass : MonoBehaviour
{
    private int protectedValueParent;
    public class ExChildClass : ExParentClass
    {
        void Start()
        {
            Debug.Log(protectedValueParent);
        }
    }
}
