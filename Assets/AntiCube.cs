using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

[DebuggerDisplay("{" + nameof(GetDebuggerDisplay) + "(),nq}")]
public class AntiCube : MonoBehaviour
{
    void Kaboom(GameObject other){
        Destroy(other);// agression: détruire l'autre
        Destroy(gameObject);// suicide
    }
    // Start is called before the first frame update
     void OnCollisionEnter (Collision other) {
        //on récupère le rigidebody de l'autre
        //si le rigidebody n'est pas nul,il existe :kaboom
        Rigidbody otherBody = other.gameObject.GetComponent<Rigidbody>();
        if (otherBody != null){
            Kaboom(other.gameObject);
        }
    }

    private string GetDebuggerDisplay()
    {
        return ToString();
    }
}
