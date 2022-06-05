using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;


public class PlayerMovement: MonoBehaviour
{
    NavMeshAgent agent;
    public Transform wayPoints;
    public Transform enemies;
    public float distance;
    public GameObject LastWayPoint;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        foreach (Transform wayPoint in wayPoints)
        {
            foreach (Transform enemy in enemies)
            {
                if (Vector3.Distance(enemy.transform.position, transform.position) > distance)
                {
                    agent.enabled = true;
                    agent.SetDestination(wayPoint.position);
                }
                else agent.enabled = false;
            }
            agent.enabled = true;
            agent.SetDestination(wayPoint.position);
            if (Vector3.Distance(LastWayPoint.transform.position, transform.position) <= 0.1)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
    }
}