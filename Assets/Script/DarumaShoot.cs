using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DarumaShoot : MonoBehaviour
{
    Rigidbody m_darumaRB = default;
    bool m_Ground = false;
    Vector3 m_Moveforce = default;
    float x = 5;
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
            m_darumaRB.AddForce(transform.forward *200.0f, ForceMode.Impulse);
            m_Ground = false;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            m_Ground = true;
        }
    }
    private void OnCollisionExit(Collision collision)
    {
       //m_Ground = false;
    }

}
