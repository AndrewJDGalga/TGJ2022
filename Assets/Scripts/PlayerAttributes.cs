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
        }
        if (collision.gameObject.CompareTag("Dog"))
        {
            health -= 3;
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        
    }
}
