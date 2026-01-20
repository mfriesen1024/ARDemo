using System;
using UnityEngine;
using UnityEngine.VFX;

public class Boks : MonoBehaviour
{
    [SerializeField] GameObject explosionParent;
    [SerializeField] VisualEffect explosion;
    [SerializeField] Animation animator;
    [SerializeField] AnimationClip explodeClip;
    [SerializeField] int ticks = 60;
    bool triggered = false;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        if (ticks == 0)
        {
            Destroy(gameObject);
        }

        if(triggered)ticks--;
        //Debug.LogError($"");
    }

    void OnTriggerEnter(Collider other)
    {
        explosionParent.SetActive(true);
        explosion.Play();
        animator.clip = explodeClip;
        animator.Play();
        triggered = true;
        //Debug.LogError("bla");
    }
}
