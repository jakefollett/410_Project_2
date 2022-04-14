using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GhostSpeed : MonoBehaviour
{

    int speed;
    public Slider speedSlider;
    public UnityEngine.AI.NavMeshAgent ghost;
    public UnityEngine.AI.NavMeshAgent ghost1;
    public UnityEngine.AI.NavMeshAgent ghost2;
    public UnityEngine.AI.NavMeshAgent ghost3;

    // Update is called once per frame
    void Update()
    {
        ghost.speed = (1 - speedSlider.value) * 1 + speedSlider.value * 4;
        ghost1.speed = (1 - speedSlider.value) * 1 + speedSlider.value * 4;
        ghost2.speed = (1 - speedSlider.value) * 1 + speedSlider.value * 4;
        ghost3.speed = (1 - speedSlider.value) * 1 + speedSlider.value * 4;
    }
}
