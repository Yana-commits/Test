using UnityEngine;
using Zenject;

public class LocationInastaller : MonoInstaller
{
    //public Vector3 fieldPoint;

    [SerializeField]
    private int fieldSize;

    [SerializeField]
    private BaseField fieldPrefab;

    [SerializeField]
    private Base basePrefab;

    [SerializeField]
    private EnemyBase enemyBasePrefab;
    public override void InstallBindings()
    {
        FieldInstall();
        BaseInstall();
        EnemyBaseInstall();
    }

    private void FieldInstall()
    {
        BaseField field = Container
                   .InstantiatePrefabForComponent<BaseField>(fieldPrefab, Vector2.zero, Quaternion.identity, null);

        Container.
            Bind<BaseField>().FromInstance(field).AsSingle();
    }

    private void BaseInstall()
    {
        Base _base = Container
                       .InstantiatePrefabForComponent<Base>(basePrefab, new Vector2(0, -fieldSize/2), Quaternion.identity, null);
        Container.
           Bind<Base>().FromInstance(_base).AsSingle();
    }

    private void EnemyBaseInstall()
    {
        EnemyBase enemyBase = Container
                       .InstantiatePrefabForComponent<EnemyBase>(enemyBasePrefab, new Vector2(0, fieldSize / 2), Quaternion.identity, null);
        Container.
           Bind<EnemyBase>().FromInstance(enemyBase).AsSingle();
    }
}