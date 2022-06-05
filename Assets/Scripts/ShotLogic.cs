using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotLogic : MonoBehaviour
{
    public float speed = 10; // �������� ����
    public float fireRate = 1; // ����������������

    public GameObject bullet; // ������ ����� ����

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 1)); // �������� ���� �� ����� ������� ���� �� �����, 1 z ����� ������, ���� ��������� ���������� �� ����������
            RaycastHit hit; // ��������� ��� ���������� ������������ ���� � �����

            if (Physics.Raycast(ray, out hit)) // ������� ���
            {
                Instantiate(bullet, new Vector3(hit.point.x, hit.point.y, hit.point.z), Quaternion.identity); // ���� ����� �� ���-��, �� ����� � hit ����� ��������������� point � ������ ��� ���������
            }
        }
    }
}
