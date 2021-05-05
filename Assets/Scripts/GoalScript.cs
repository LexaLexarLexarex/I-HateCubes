using UnityEngine;

public class GoalScript : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        GameObject collideWith = other.gameObject;
        if ( collideWith.tag == gameObject.tag)
        {
            Destroy(other);
        }
    }
}
