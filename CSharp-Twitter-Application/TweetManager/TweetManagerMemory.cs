using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TweetManager
{
    public class TweetManagerMemory : TweetManager
    {
        string[] tweets = new string[10];
        int tweetCounter = 0;

        public override string Write(string tweet)
        {
            tweets[tweetCounter++] = tweet;
            return "Tweet posted successullly";
        }

        public override string[] Get() => tweets;

        public override int Count() => tweetCounter;
    }
}
