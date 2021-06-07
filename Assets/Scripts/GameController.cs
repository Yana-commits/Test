using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class GameController : MonoBehaviour
{
    private int fieldSize = 40;

    public List<Vector2Int> positions;

    private BaseField field;
   
    private Base _base;

    private Player player;
    public Player Player
    {
        get
        {
            return player;
        }

        set
        {
            player = value;
        }
    }

    private Enemy enemy;
    public Enemy Enemy
    {
        get
        {
            return enemy;
        }

        set
        {
            enemy = value;
        }
    }

    private EnemyBase enemyBase;
   
    [Inject]
    private GameObject navMesh;

    [Inject]
    private void Construct(BaseField field,Base _base,EnemyBase enemyBase)
    {
        this.field = field;
        this._base = _base;
         this.enemyBase = enemyBase;
    }

    private void Awake()
    {
        FillPositions();
    }
    void Start()
    {
        InitializeLevel();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void FillPositions()
    { 
        positions = new List<Vector2Int> {
            new Vector2Int(0, fieldSize / 2),
            new Vector2Int(0,-fieldSize / 2),
            new Vector2Int(0,-fieldSize / 2 - 1),
            new Vector2Int(0, -fieldSize / 2+1),
             new Vector2Int(0,fieldSize / 2+1),
             new Vector2Int(0,fieldSize / 2 - 1)
        };
    }

    public void InitializeLevel()
    {
        _base.transform.SetParent(field.transform);
        enemyBase.transform.SetParent(field.transform);
        field.transform.SetParent(navMesh.transform);
    }
}
