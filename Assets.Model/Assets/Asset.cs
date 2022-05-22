namespace Assets.Model
{
    public class Asset
    {
        public Asset(string name, Group group)
        {
            Name = name;
            Group = group;
        }

        public string Name { get; set; }
        public Group Group { get; set; }
    }

    public enum Group
    {
        RendaFixa,
        RendaVariavel,
        Fundos,
        Acoes,
        TesouroDireto,
        Poupanca,
        Criptomoeda
    }
}