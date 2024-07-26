namespace PersonalProject.Client
{
    public class StandDataTable
    {
        private int ID { get; set; }
        private string Name { get; set; }
        private char Power { get; set; }
        private char Speed { get; set; }
        private char Range { get; set; }
        private char Persistence { get; set; }
        private char Precision { get; set; }
        private char Potential { get; set; }
        private string? Desc { get; set; }

        private readonly List<StandDataTable> Stands =
        [
            new(){
                ID=1,
                Name="Star Platinum",
                Power= 'A',
                Speed='A',
                Range='C',
                Persistence='A',
                Precision='A',
                Potential='A',
                Desc=String.Empty,
            },
            new(){
                ID=2,
                Name="The World",
                Power= 'A',
                Speed='A',
                Range='C',
                Persistence='A',
                Precision='B',
                Potential='B',
                Desc=String.Empty,
            },
            new(){
                ID=3,
                Name="King Crimson",
                Power= 'A',
                Speed='A',
                Range='E',
                Persistence='E',
                Precision='?',
                Potential='?',
                Desc=String.Empty,
            },

            ];

        public StandDataTable[] GetStands() => [.. Stands];

        
     

}
}
