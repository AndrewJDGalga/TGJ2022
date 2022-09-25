
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerAttributes : MonoBehaviour
{
    [SerializeField] int health;
    // Start is called before the first frame update
    void Start()
    {
        health = 5;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Soldier"))
        {
            health -= 1;
            Debug.Log("Hit by Soldier");
        }
        if (collision.gameObject.CompareTag("Dog"))
        {
            health -= 3;
            Debug.Log("Hit by Dog");
        }
        if (collision.gameObject.CompareTag("Trap"))
        {
            health -= 2;
            Destroy(collision.gameObject);
            Debug.Log("hurt by mine");
        }

    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        
    }
}
