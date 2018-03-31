using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ppap : MonoBehaviour {

	void OnTrigerStay(Collider other)
    {
        pleyercontlorel.health  -=   10;
        print("run away");
    }
}
