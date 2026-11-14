namespace SizovVoins9.Classes
{
    public class LightKnight : Knight
    {
        public LightKnight(double healthPoint) :
            base(healthPoint)
        { }
        private double defense = 0.5;
        public override void getAttack(double damage)
        {
            HealthPoint -= damage * 1/defense;
        }


    }
}
