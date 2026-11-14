namespace SizovVoins9.Classes
{
    public class HeavyKnight : Knight
    {
        public HeavyKnight(double healthPoint) :
    base(healthPoint)
        { }
        private double defense = 1.5;
        public override void getAttack(double damage)
        {
            HealthPoint -= damage * 1 / defense;
        }

    }
}
