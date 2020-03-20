using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TweetManager
{
    public class TweetManagerFile : TweetManager
    {
        private string filename = "tweets.txt";

        public override string Write(string tweet)
        {
            System.IO.File.AppendAllLines(filename, new string[] { tweet });
            return "Tweet posted successullly";
        }

        public override string[] Get()
        {
            if (System.IO.File.Exists(filename))
                return System.IO.File.ReadAllLines(filename);
            else
                return null;
        }

        public override int Count()
        {
            if (System.IO.File.Exists(filename))
                return System.IO.File.ReadAllLines(filename).Length;
            else
                return 0;
        }
    }
}
