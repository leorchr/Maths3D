using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrossProduct : MonoBehaviour
{
    public Vector3 vectorPlayer;
    public Vector3 vectorChicken;
    public Vector3 positionPlayer;
    public Vector3 positionChicken;

    public GameObject player;

    private void Start()
    {
        vectorPlayer = player.transform.forward;
        vectorChicken = transform.forward;
    }
    private void Update()
    {
        vectorPlayer = player.transform.forward;
        vectorChicken = transform.forward;
        positionPlayer = player.transform.position;
        positionChicken = transform.position;

        if (Vector3.Distance(positionPlayer,positionChicken) < 1f)
        {
            if (Dotproduct(vectorChicken, vectorPlayer) > 0.8f)
            {
                Debug.Log("Tu regardes son dos je crois, enfin je suis pas sur");
                if (Dotproduct(-vectorChicken, vectorPlayer) < -0.8f)
                {
                    Debug.Log("bonjour");
                }
            }
        }
    }


    Vector3 Crossproduct(Vector3 a, Vector3 b)
    {
        return new Vector3(
            (a.y * b.z - a.z * b.y),
            (a.z * b.x - a.x * b.z),
            (a.x * b.y - a.y * b.x));
    }

    float Dotproduct(Vector3 a, Vector3 b)
    {
        return (
            a.x * b.x+
            a.y * b.y+
            a.z * b.z);
    }
}
