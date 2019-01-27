namespace Pick5Grammar.Models
{
    public sealed class GrammarReference
    {
        public string Concept {get;set;}
        public string Proficiency {get;set;}
        public string Minna {get;set;}
        public string DXJG {get;set;}
        public string SoMatoMe {get;set;}
        public string Journal {get;set;}

        public override string ToString()
        {
            string formattedString = $@"{Concept}
                Proficiency: {Proficiency}
                Minna Reference: {Minna}
                DXJG Reference: {DXJG}
                So Matome: {SoMatoMe}
                Journal: {Journal}";

            return formattedString;
        }
    }
}