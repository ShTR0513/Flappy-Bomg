using System.Collections;
using System.Collections.Generic;
//using System.Diagnostics;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody2D rigidbody;
    public int force;
    public GameObject restartButton;

    void Start()
    {
        Time.timeScale = 1;
        rigidbody = GetComponent<Rigidbody2D>();
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rigidbody.AddForce(Vector2.up * force, ForceMode2D.Impulse);
        }
    }

    private void OnCollisionEnter2D (Collision2D collision)
    {
        if (collision.collider.tag == "Enemy")
        {
            Destroy(gameObject);
            Time.timeScale = 0;
            restartButton.SetActive(true);
        }
       
    }

}
