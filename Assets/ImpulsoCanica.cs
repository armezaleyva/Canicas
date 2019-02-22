using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImpulsoCanica : MonoBehaviour
{

    Rigidbody2D rigidbody;
    [SerializeField]
    int fuerzaDeImpulso = 5;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        rigidbody.AddForce(Vector2.right * fuerzaDeImpulso, ForceMode2D.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
