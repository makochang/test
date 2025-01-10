using UnityEngine;

namespace SSShooter
{
    public class StraightMovement : EnemyMovementBase
    {
        public override void Move()
        {
            transform.Translate(direction * speed * Time.deltaTime);
        }

        protected override void Start()
        {
            Initialize(1f, Vector2.left);
        }

        protected override void Update()
        {
            base.Update();
        }
    }
}
