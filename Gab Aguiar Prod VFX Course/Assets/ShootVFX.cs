using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootVFX : MonoBehaviour
{
    public GameObject vfxPrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(vfxPrefab, transform.position, transform.rotation, transform);
        }
    }
}
