/**using UnityEngine;

public class NPCGenerator : MonoBehaviour
{
    public GameObject npcPrefab; // Arrastra el Prefab del NPC aqu�
    public int numberOfNPCs = 100; // N�mero de copias del NPC que deseas crear
    public Terrain terrain; // Arrastra el terreno aqu�
    public float maxRadius = 210f; // Radio m�ximo para la posici�n x,z

    void Start()
    {
        // Centro del terreno
        Vector3 terrainCenter = new Vector3(250f, 0f, 250f);

        // Genera las copias del NPC
        for (int i = 0; i < numberOfNPCs; i++)
        {
            Vector3 randomOffset = Random.insideUnitCircle * maxRadius;
            Vector3 spawnPosition = terrainCenter + new Vector3(randomOffset.x, 0f, randomOffset.y);
            float terrainHeight = terrain.SampleHeight(spawnPosition);
            spawnPosition.y = terrainHeight;
            Instantiate(npcPrefab, spawnPosition, Quaternion.identity);
        }
    }
}**/

/*using UnityEngine;

public class NPCGenerator : MonoBehaviour
{
    public GameObject[] npcPrefabs; // Lista de Prefabs de NPC, arrastra todos los modelos aqu�
    public int numberOfNPCs = 1000; // N�mero de copias del NPC que deseas crear
    public Terrain terrain; // Arrastra el terreno aqu�
    public float maxRadius = 210f; // Radio m�ximo para la posici�n x,z

    void Start()
    {
        // Centro del terreno
        Vector3 terrainCenter = new Vector3(250f, 0f, 250f);

        // Genera las copias del NPC
        for (int i = 0; i < numberOfNPCs; i++)
        {
            // Selecciona un Prefab de NPC al azar de la lista
            GameObject randomNPCPrefab = npcPrefabs[Random.Range(0, npcPrefabs.Length)];

            Vector3 randomOffset = Random.insideUnitCircle * maxRadius;
            Vector3 spawnPosition = terrainCenter + new Vector3(randomOffset.x, 0f, randomOffset.y);
            float terrainHeight = terrain.SampleHeight(spawnPosition);
            spawnPosition.y = terrainHeight;

            // Instancia el NPC con el modelo seleccionado
            Instantiate(randomNPCPrefab, spawnPosition, Quaternion.identity);
        }
    }
}*/

using UnityEngine;

public class NPCGenerator : MonoBehaviour
{
    public GameObject[] npcPrefabs; // Lista de Prefabs de NPC, arrastra todos los modelos aqu�
    public int numberOfNPCs = 100; // N�mero de copias del NPC que deseas crear
    public Terrain terrain; // Arrastra el terreno aqu�
    public float maxRadius = 210f; // Radio m�ximo para la posici�n x,z
    public float minHeightAboveTerrain = 2f; // Altura m�nima sobre el terreno

    void Start()
    {
        // Centro del terreno
        Vector3 terrainCenter = new Vector3(250f, 0f, 250f);

        // Genera las copias del NPC
        for (int i = 0; i < numberOfNPCs; i++)
        {
            // Selecciona un Prefab de NPC al azar de la lista
            GameObject randomNPCPrefab = npcPrefabs[Random.Range(0, npcPrefabs.Length)];

            Vector3 randomOffset = Random.insideUnitCircle * maxRadius;
            Vector3 spawnPosition = terrainCenter + new Vector3(randomOffset.x, 0f, randomOffset.y);
            float terrainHeight = terrain.SampleHeight(spawnPosition);

            // Ajusta la altura de generaci�n para que est� por encima del terreno
            spawnPosition.y = terrainHeight + minHeightAboveTerrain;

            // Instancia el NPC con el modelo seleccionado
            Instantiate(randomNPCPrefab, spawnPosition, Quaternion.identity);
        }
    }
}


