using ExcelDataReader;

namespace Pick5Grammar.src
{
    public class Excel
    {
        private readonly string _inFile;
        private readonly int _numOutput;
        public Excel(string inFile, int numOutput = 5)
        {
            _inFile = inFile;
            _numOutput = numOutput;
        }

        
    }
}