namespace ExamenGrupalT3d26._1
{
    internal class potionLife : Character
    {
        public potionLife(string name, int life, int damage) : base(name, life, damage)
        {
            life += 3;
        }
    }
}
