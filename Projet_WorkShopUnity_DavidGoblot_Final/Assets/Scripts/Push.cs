using UnityEngine;

public class Push : MonoBehaviour
{

    [SerializeField] float strength = 1.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        Rigidbody rigidbody =  hit.collider.attachedRigidbody;

        if (rigidbody != null && transform.position.y < 2.0f)
        {
            Vector3 forceDirection = hit.gameObject.transform.position - transform.position;
            forceDirection.y = 0.0f;
            forceDirection = forceDirection.normalized;

            rigidbody.AddForceAtPosition(forceDirection * strength, transform.position, ForceMode.Impulse);
        }
    }
}
