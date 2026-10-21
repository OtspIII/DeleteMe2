using System;
using UnityEngine;

public class UpgradeScript : MonoBehaviour
{
    public Rigidbody2D RB;

    public PathPointController Dest;

    void Update()
    {
        Vector2 vel = (Dest.transform.position - transform.position).normalized * 5;
        RB.linearVelocity = vel;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (Dest.gameObject == other.gameObject)
        {
            Dest = Dest.Next;
        }
    }
}

// public class PathPointController : MonoBehaviour
// {
//     public PathPointController Next;
// }
