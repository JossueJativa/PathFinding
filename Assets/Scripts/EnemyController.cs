using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour
{
    public Transform objetivo;  // Jugador como objetivo
    private NavMeshAgent agente;

    // Velocidad deseada para el enemigo
    public float velocidadEnemigo = 45f;

    // Start is called before the first frame update
    void Start()
    {
        agente = GetComponent<NavMeshAgent>();

        // Asegúrate de que hay un objetivo asignado
        if (objetivo == null)
        {
            Debug.LogError("No hay un objetivo asignado al enemigo.");
        }
        else
        {
            // Configura la velocidad del NavMeshAgent
            agente.speed = velocidadEnemigo;
        }
    }

    // Update is called once per frame
    void Update()
    {
        // Asegúrate de que hay un objetivo asignado
        if (objetivo != null)
        {
            // Establece el destino del NavMeshAgent al posición del objetivo (jugador)
            agente.destination = objetivo.position;
        }
    }
}
