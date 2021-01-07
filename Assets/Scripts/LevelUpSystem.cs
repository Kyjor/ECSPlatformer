using UnityEngine;
using  Unity.Entities;

    public class LevelUpSystem : SystemBase
    {
        protected override void OnUpdate()
        {
            Entities.ForEach((ref LevelComponent levelComponent) =>
            {
                levelComponent.level += 1f * Time.DeltaTime;
                Debug.Log(levelComponent.level);
            }).WithoutBurst().Run();
        }
    }
