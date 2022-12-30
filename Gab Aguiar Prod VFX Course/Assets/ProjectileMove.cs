using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;

public class ProjectileMove : MonoBehaviour
{
    public float speed;
    public VisualEffect mainVFX;
    public VisualEffect hitVFX;

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.right * speed * Time.deltaTime;
    }

    private void OnTriggerEnter(Collider other)
    {
        mainVFX.Stop();
        mainVFX.SetBool("isAlive", false);
        speed = 0.0f;
        GetComponent<Collider>().enabled = false;
        //hitVFX.Play();

    }
}
