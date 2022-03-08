namespace AbstraindoJogoRPG_POO.src.Entities
{
    public class Ninja : Hero
    {
         public Ninja(string name, int level, string heroType) : base(name, level, heroType){ }      
    

     public override string Attack()
        {
            return this.name + " Atacou com seu punho";
        }

         public string Attack(int bonus)
        {
            if (bonus > 6)
            { 
                return this.name + " Atacou com seu super punho com bonus de ataque de " + bonus;
            }else 
            {
                 return this.name + " Atacou com seu punho com força fraca com bonus de ataque de " + bonus;            
            }           
        }
    }   
}