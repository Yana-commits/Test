using UnityEngine;
using Zenject;

public class GameInstaller : MonoInstaller
{
    [SerializeField]
    private GameObject navMesh;

    public override void InstallBindings()
    {
        Container.BindInstance(navMesh);

        Container.Bind<BulletPool>().FromComponentInHierarchy().AsSingle().NonLazy();
    }

}