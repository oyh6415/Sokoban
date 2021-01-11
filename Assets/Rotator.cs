using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    void Update()
    {
        transform.Rotate(60*Time.deltaTime, 60 * Time.deltaTime, 60 * Time.deltaTime);
        // Tiem.deltaTime은 화면이 한번 깜박이는 시간 = 한 프레임의 시간
    }
}
