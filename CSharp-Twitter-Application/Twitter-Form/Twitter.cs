﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TweetManager;

namespace Twitter_Form
{
    public partial class Twitter : Form
    {
        TweetManagerFile tm = new TweetManagerFile();
        public Twitter()
        {
            InitializeComponent();
        }

        private void Twitter_Load(object sender, EventArgs e)
        {
            refreshTweets();
        }

        private void btnPost_Click(object sender, EventArgs e)
        {
            string msg = tm.Post(txtTweet.Text);
            lblStatus.Text = msg;
            refreshTweets();
        }

        void refreshTweets()
        {
            lstTweets.Items.Clear();
            string[] tweets = tm.Get();
            int tweetCount = tm.Count();
            for (int i = 0; i < tweetCount; i++)
            {
                lstTweets.Items.Add(tweets[i]);
            }
        }
    }
}
