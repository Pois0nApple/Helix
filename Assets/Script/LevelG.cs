
using UnityEngine;
using Random = System.Random;
public class LevelG : MonoBehaviour
{
    public GameObject[] PlatformPrefabs;
    public GameObject FirstPlayerPrefab;
    public int MinPlatforms;
    public int MaxPlatforms;
    public float Distance;
    public Transform FinishPlatform;
    public Transform CylinderRoot;
    public float CylinderScale = 1f;
    public Game Game;

    private void Awake ()
    {
        int LvlIndex = Game.LvlIndex;
        Random random =  new Random(LvlIndex);
        int platformsCount = RandomRange(random, MinPlatforms, MaxPlatforms + 1);

        for (int i = 0; i < platformsCount; i++)
        {
            int prefabIndex = RandomRange(random, 0, PlatformPrefabs.Length);
            GameObject platformPrefab = i== 0 ? FirstPlayerPrefab : PlatformPrefabs[prefabIndex];
            GameObject platform = Instantiate(platformPrefab, transform);
            platform.transform.localPosition = CalculatePlatformP(i);
            
            if (i >0)
               
                platform.transform.localRotation = Quaternion.Euler(0, RandomRange(random, 0, 360f), 0);
        }

        FinishPlatform.localPosition = CalculatePlatformP(platformsCount);

        CylinderRoot.localScale = new Vector3(1, platformsCount*Distance + CylinderScale, 1);
    }

    private int RandomRange(Random random, int min, int maxExcl)
    {
        int number = random.Next();
        int length = maxExcl - min;
        number %= length;
        return min+number;
    }

    private float RandomRange(Random random, float min, float max)
    {
        float t = (float) random.NextDouble();
        return Mathf.Lerp(min, max, t);
    }
    private Vector3 CalculatePlatformP(int platformIndex)
    {
        return new Vector3(0, -Distance * platformIndex, 0);
    }
}
