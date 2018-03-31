using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {

	void OnTrigerEnter (Collider other)
    {
        pleyercontlorel.haveKey = true;
        gameObject.SetActive(false);
        print("u pick up");

    }
}
