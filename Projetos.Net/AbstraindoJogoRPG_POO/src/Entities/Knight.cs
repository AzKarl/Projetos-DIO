namespace AbstraindoJogoRPG_POO.src.Entities
{
    public class Knight : Hero
    {
         public Knight(string name, int level, string heroType) : base(name, level, heroType){ }      
    

     public override string Attack()
        {
            return this.name + " Atacou com sua espada";
        }

         public string Attack(int bonus)
        {
            if (bonus > 6)
            { 
                return this.name + " Atacou com sua espada super efetiva com bonus de ataque de " + bonus;
            }else 
            {
                 return this.name + " Atacou com sua espada com força fraca com bonus de ataque de " + bonus;            
            }           
        }
    }   
}