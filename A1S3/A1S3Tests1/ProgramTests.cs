﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using A1S3;
using System.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A1S3.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void MainTest()
        {
            
        }

        [TestMethod()]
        public void Q1_GetWordsTest()
        {
            string path = @"E:\c#\New folder\test.txt";
            string[] word = File.ReadAllLines(path);
             CollectionAssert.Equals(word, Program.Q1_GetWords(path));
        }

        [TestMethod()]
        public void Q2_IsInWordsTest()
        {
            string[] words = new string[5] { "hello", "c#", "bye","good" ,"bad"};
            string word = "c#";
            Assert.AreEqual(true,Program.Q2_IsInWords(words,word));
        }

        [TestMethod()]
        public void Q3_GetWordsOfTweetTest()
        {
            string word = "c#ad asd";
            
            string[] s = word.Split('#',' ' );
            string[] a = Program.Q3_GetWordsOfTweet(word);
            CollectionAssert.Equals(s, a);
        }

        [TestMethod()]
        public void Q4_GetPopChargeOfTweetTest()
        {
            string tweet = "salam,khoby chekhabar";
            string[] poswords =new string[1] { "salam" };
            string[] negwords = new string[1] { "khoby" };
            Assert.AreEqual(0,Program.Q4_GetPopChargeOfTweet(tweet, poswords,negwords));
        }

        [TestMethod()]
        public void Q5_GetAvgPopChargeOfTweetsTest()
        {
            string[] tweets = new string[3] { "salam,khoby chekhabar","salam","salam" };
            string[] poswords = new string[1] { "salam" };
            string[] negwords = new string[1] { "khoby" };
            double s = (double)2 / 3;
            Assert.AreEqual(s, Program.Q5_GetAvgPopChargeOfTweets(tweets, negwords, poswords));
        }
    }
}