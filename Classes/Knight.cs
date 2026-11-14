namespace SizovVoins9.Classes
{
    public class Knight
    {
        public double HealthPoint = 100;
        private double defense = 1;
        public Knight(double healthPoint)
        {
            this.HealthPoint = healthPoint;
        }   
        public virtual void getAttack(double damage)
        {
            HealthPoint -= damage * (1/defense);
        }
        
    }
}
