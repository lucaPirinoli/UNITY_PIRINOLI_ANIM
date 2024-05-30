using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIController : MonoBehaviour
{
    // Start is called before the first frame update
    
    private Animator m_Animator;

    void Start()
    {
        m_Animator = GetComponent<Animator>(); 

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            print("ouou");
            m_Animator.SetBool("isPlayerSeein", true);

        }

    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            print("ouou");
            m_Animator.SetBool("isPlayerSeein", false);

        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
