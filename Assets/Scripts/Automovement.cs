using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Automovement : MonoBehaviour
{
    public UnityEngine.AI.NavMeshAgent navMeshAgent;

    public Transform[] targets;
    private int targetsCounter;

    private bool arrive = false;

    public float distancePercentage;
    public float distanceTraveled;
<<<<<<< HEAD
    private float range = 45f;
    private float distanceBetweenTar;
    private float distancePrevious;
    private float distanceTotal = 1000000.00f;
=======
    private float range = 30f;
    private float distanceBetweenTar;
    private float distancePrevious;
    private float distanceTotal = 3749.302f;
>>>>>>> 08213f40738c9008731357566263d6e61cf9d9b2

    // Start is called before the first frame update
    void Start()
    {
        distancePrevious = Vector3.Distance(transform.position, targets[targetsCounter].position);
    }

    // Update is called once per frame
    void Update()
    {

        carSpec carSpecification = this.GetComponent<carSpec>();

        if (!arrive)
        {
            navMeshAgent.SetDestination(targets[targetsCounter].position);
        }

        distanceBetweenTar = Vector3.Distance(transform.position, targets[targetsCounter].position);

        if (distanceBetweenTar < range)
        {
            arrive = true;
            navMeshAgent.speed = 0;
            if (targetsCounter < targets.Length)
            {
                targetsCounter++;
<<<<<<< HEAD
                if (targetsCounter == targets.Length)
                {
                    targetsCounter = 0;
                }
=======
>>>>>>> 08213f40738c9008731357566263d6e61cf9d9b2
            }
        }
        else
        {
            arrive = false;
            navMeshAgent.speed = carSpecification.speed;
            navMeshAgent.angularSpeed = carSpecification.automoveAngularSpeed;
            navMeshAgent.acceleration = carSpecification.automoveAcceleration;
            distanceTraveled += Mathf.Abs(distanceBetweenTar - distancePrevious);
            distancePercentage = (float)System.Math.Round(distanceTraveled / distanceTotal * 100, 2);
            distancePrevious = Vector3.Distance(transform.position, targets[targetsCounter].position);
<<<<<<< HEAD
            carSpecification.automoveDistanceTraveled = distanceTraveled;
=======
>>>>>>> 08213f40738c9008731357566263d6e61cf9d9b2
        }
    }

    public float returnDistancePercentage()
    {
        return distancePercentage;
    }

    public float returnDistanceTraveled()
    {
        return distanceTraveled;
    }
}
