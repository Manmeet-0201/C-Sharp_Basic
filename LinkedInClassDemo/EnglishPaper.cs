using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedInClassDemo
{
    public class EnglishPaper:IScored
    {
        public string Title { get; set; }
        public int MinimumWordCount { get; set; }
        public string PaperText { get; set; }
        public float Score { get; set; }
        public float MaximumScore { get; set; }
        public int WordCount
        {
            get { return PaperText.WordCount(); }
        }

       
    }
}
