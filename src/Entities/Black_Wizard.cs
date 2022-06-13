namespace DesafioDIO.src.Entities
{
    public class Black_Wizard : Hero
    {
        public Black_Wizard(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }

        public override string Attack()
        {
            return this.Name + " Lançou Magia Negra";
        }

        public string Attack(int Bonus)
        {
            if (Bonus > 6){
                return this.Name + " Lançou Magia super efetiva com um bonus de" + Bonus;
            }else{
                return this.Name + " Lançou magia com força fraca com bonus de " + Bonus;
            }
            
        }
    }
}
