using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kamere_takip : MonoBehaviour
{
    public Transform hedef;

    private void Update()
    {
        if (hedef.position.y>transform.position.y)
        {
            transform.position = new Vector3(transform.position.x, hedef.position.y, transform.position.z);
        }




    }
}
