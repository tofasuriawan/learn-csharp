using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TweetManager
{
    public abstract class TweetManager
    {
        int maxTweets = 10;
        public string Post(string tweet)
        {
            if (tweet.Length > 140)
                return "Error: Tweet is longer than 140";

            if (Count() >= maxTweets)
                return "Error: Max tweets reached";

            return Write(tweet);
        }

        public abstract string[] Get();
        public abstract int Count();
        public abstract string Write(string tweet);

        public List<string> Search(string term)
        {
            List<string> result = new List<string>();
            for (int i = 0; i < Count(); i++)
            {
                if (Get()[i].Contains(term))
                    result.Add(Get()[i]);
            }
            return result;
        }
    }
}
