namespace ExamenGrupalT3d26._1
{
    internal abstract class Situation
    {
        protected string title;
        protected string description;

        public Situation(string t, string d)
        {
            title = t;
            description = d;
        }

        public abstract void Play(Character player);
    }
}
