using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class VisionCone : MonoBehaviour
{
    private Color colour;
    private Renderer renderer;
    [SerializeField] bool entered;
    // Start is called before the first frame update
    void Start()
    {
        entered = false;
        renderer = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            entered = true;
            renderer.material.color = Color.green;
        }
        
    }
    public void OnTriggerExit2D(Collider2D collision)
    {
        renderer.material.color = Color.red;
    }

}
