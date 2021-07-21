using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movePlanets : MonoBehaviour
{
    public GameObject solarSystemGravityObject;
    public GameObject planet1;
    public GameObject planet2;

    public float moveDelay;

    public float planetForce;
    public float planetForce1;

    void Update()
    {
        Vector3 relativePos = (solarSystemGravityObject.transform.position) - planet1.transform.position;
        Quaternion rotation = Quaternion.LookRotation(relativePos);
        Quaternion current = planet1.transform.localRotation;
        planet1.transform.localRotation = Quaternion.Slerp(current, rotation, (Time.deltaTime / (moveDelay + planetForce / 10)));
        planet1.transform.Translate(0, 0, planetForce * (Time.deltaTime / (moveDelay + planetForce / 10)));

        Vector3 relativePos1 = (solarSystemGravityObject.transform.position) - planet2.transform.position;
        Quaternion rotation1 = Quaternion.LookRotation(relativePos1);
        Quaternion current1 = planet2.transform.localRotation;
        planet2.transform.localRotation = Quaternion.Slerp(current1, rotation1, (Time.deltaTime / (moveDelay + planetForce1 / 10)));
        planet2.transform.Translate(0, 0, planetForce1 * (Time.deltaTime / (moveDelay + planetForce1 / 10)));
    }
}
