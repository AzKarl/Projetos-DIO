 namespace AbstraindoJogoRPG_POO.src.Entities
{
    public class Wizard : Hero
    {
        public Wizard(string name, int level, string heroType) : base(name, level, heroType){ }

        public override string Attack()
        {
            return this.name + " Lançou magia";
        }

         public string Attack(int bonus)
        {
            if (bonus > 6)
            { 
                return this.name + " Lançou magia super efetiva com bonus de ataque de " + bonus;
            }else 
            {
                 return this.name + " Lançou magia com força fraca com bonus de ataque de " + bonus;            
            }           
        }
    }
}