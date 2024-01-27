using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class temizle : MonoBehaviour
{
  void OnTriggerEnter2D(Collider2D temas)
    {
        float rastgeleX = Random.Range(-1.8f, 1.8f);
        float rastgeleY = Random.Range(10f, 11f);

        if (temas.tag=="Platform")
        {
            temas.transform.position = new Vector3(rastgeleX, temas.transform.position.y + rastgeleY, temas.transform.position.z);
          //  Destroy(temas.gameObject);  
        }
        if (temas.gameObject.tag == "hediye")
        {
            temas.transform.position = new Vector3(rastgeleX, temas.transform.position.y + rastgeleY, temas.transform.position.z);

        }
    }
}
