using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zıpla : MonoBehaviour
{
    public static float ziplamaGucu=6;
    private Vector2 karakterHizi;
    private Rigidbody2D fizik;


    private void OnCollisionEnter2D(Collision2D temas)
    {
        if (temas.relativeVelocity.y<=0)
        {
            fizik = temas.collider.GetComponent<Rigidbody2D>();
            if (fizik != null)
            {
                karakterHizi = fizik.velocity;
                karakterHizi.y = ziplamaGucu;
                fizik.velocity = karakterHizi;
            }
        }
  
    }
}
