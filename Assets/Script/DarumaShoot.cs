using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DarumaShoot : MonoBehaviour
{
    Rigidbody m_darumaRB = default;
    bool m_Ground = false;
    // Start is called before the first frame update
    void Start()
    {
        m_darumaRB = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump") && m_Ground)
        {

        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        m_Ground = true;
    }
    private void OnCollisionExit(Collision collision)
    {
        m_Ground = false;
    }

}
