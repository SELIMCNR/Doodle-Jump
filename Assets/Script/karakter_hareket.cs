using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class karakter_hareket : MonoBehaviour
{
    public float hiz;
    public Rigidbody2D doodle;
    private float hareketInput;
    public Text skorYazi;
    int skor;
      public Transform hedef;

    // Update is called once per frame
    float minX = -1.8f;
    float maxX = 1.8f;

    void Update()
    {
        skorYazi.text = "Skor : " + skor;
        hareketInput = Input.GetAxis("Horizontal");
        doodle.velocity = new Vector2(hiz * hareketInput,doodle.velocity.y);

        transform.position = new Vector3(
            Mathf.Clamp(transform.position.x, minX, maxX),
            transform.position.y,
           transform.position.z
        );

    }

    private void OnCollisionEnter2D(Collision2D temas)
    {

        if(temas.gameObject.tag == "bitis")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            zýpla.ziplamaGucu = 6f;
        }
        
        if(temas.gameObject.tag == "Platform")
        {
            skor += Random.Range(9, 49);
        }
        if(temas.gameObject.tag == "hediye")
        {
            zýpla.ziplamaGucu += 0.1f;
            skor += Random.Range(100, 200);
            float rastgeleX = Random.Range(-1.8f, 1.8f);
            float rastgeleY = Random.Range(10f, 11f);
            Vector3 klonPozisyonu = new Vector3(rastgeleX,rastgeleY);

            Instantiate(temas.gameObject, klonPozisyonu, Quaternion.identity);
            Destroy(temas.gameObject);

  
}
    }
}
