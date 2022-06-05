using UnityEngine;

[RequireComponent(typeof(Rigidbody))]

public class ProjectileActions : MonoBehaviour
{


    void Start()
    {
        // уничтожить объект по истечению указанного времени (секунд), если пуля никуда не попала
        Destroy(gameObject, 5);
    }

    private void Update()
    {
    }

    void OnTriggerEnter(Collider coll)
    {
        if (!coll.isTrigger) // чтобы пуля не реагировала на триггер
        {
            switch (coll.tag)
            {
                case "Enemy":
                    Destroy(coll.gameObject);
                    break;
            }
            Destroy(gameObject);
        }
    }
}
