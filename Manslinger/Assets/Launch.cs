using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Launch : MonoBehaviour
{
    public GameObject projectile;
    //public Rigidbody projectileRigidbody;

    //public float explosionForce;
    //public Vector3 explosionPosition;
    //public float explosionRadius;

    //public Vector3 launchForce;
    public Vector3 launchDirection;
    public float launchPower;

    private Rigidbody projectileRigidBody;

    // Start is called before the first frame update
    void Start()
    {
        //projectileRigidbody = GetComponentInChildren<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            projectileRigidBody = Instantiate(projectile, transform.position, Quaternion.identity).transform.Find("Root/Hips").GetComponent<Rigidbody>(); // yeah I know this is not great
            //projectileRigidbody.AddExplosionForce(explosionForce, explosionPosition, explosionRadius);
            //projectileRigidbody.AddForce(launchForce); // LOL don't apply force on the rigidbody I give in public
            projectileRigidBody.AddForce(launchDirection * launchPower);
        }
    }

    //private Vector3 CalculateExplosionPosition()
    //{
    //    return transform.position - new Vector3(0, 0, 3);
    //}
}
