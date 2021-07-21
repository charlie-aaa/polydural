using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movePlanets : MonoBehaviour
{
    public GameObject solarSystemGravityObject;
    public GameObject planet1;
    public GameObject planet2;

    public float moveDelay;

    float TimePassed = 0f;
    private float solarSystemGravityForce;
    private float solarSystemGravityForce1;

    void Start() {
        solarSystemGravityForce = planet1.transform.position.x;
        solarSystemGravityForce1 = planet2.transform.position.x;
    }

    void Update()
    {
        TimePassed = TimePassed + 1;
        if (TimePassed >= moveDelay) {
            TimePassed = 0;
            Vector3 relativePos = (solarSystemGravityObject.transform.position) - planet1.transform.position;
            Quaternion rotation = Quaternion.LookRotation(relativePos);
            Quaternion current = planet1.transform.localRotation;
            planet1.transform.localRotation = Quaternion.Slerp(current, rotation, (Time.deltaTime / (moveDelay + solarSystemGravityForce)));
            planet1.transform.Translate(0, 0, solarSystemGravityForce * (Time.deltaTime / (moveDelay + solarSystemGravityForce)));

            Vector3 relativePos1 = (solarSystemGravityObject.transform.position) - planet2.transform.position;
            Quaternion rotation1 = Quaternion.LookRotation(relativePos1);
            Quaternion current1 = planet2.transform.localRotation;
            planet2.transform.localRotation = Quaternion.Slerp(current1, rotation1, (Time.deltaTime / (moveDelay + solarSystemGravityForce)));
            planet2.transform.Translate(0, 0, solarSystemGravityForce1 * (Time.deltaTime / (moveDelay + solarSystemGravityForce)));
        }
    }
}
