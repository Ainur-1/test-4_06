using UnityEngine;

[RequireComponent(typeof(Rigidbody))]

public class ProjectileActions : MonoBehaviour
{


    void Start()
    {
        // ���������� ������ �� ��������� ���������� ������� (������), ���� ���� ������ �� ������
        Destroy(gameObject, 5);
    }

    private void Update()
    {
    }

    void OnTriggerEnter(Collider coll)
    {
        if (!coll.isTrigger) // ����� ���� �� ����������� �� �������
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
