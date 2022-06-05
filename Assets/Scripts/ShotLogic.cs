using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotLogic : MonoBehaviour
{
    public float speed = 10; // скорость пули
    public float fireRate = 1; // скорострельность

    public GameObject bullet; // префаб нашей пули

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 1)); // создание луча из точки нажатия мыши на экран, 1 z можно менять, если положение получается не корректным
            RaycastHit hit; // контейнер для результата столкновения луча с мешем

            if (Physics.Raycast(ray, out hit)) // пускаем луч
            {
                Instantiate(bullet, new Vector3(hit.point.x, hit.point.y, hit.point.z), Quaternion.identity); // если попал во что-то, то берем в hit точку соприкосновения point и ставим там указатель
            }
        }
    }
}
