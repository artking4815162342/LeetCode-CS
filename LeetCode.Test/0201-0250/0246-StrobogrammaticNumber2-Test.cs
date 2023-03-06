﻿using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public sealed class _0246_StrobogrammaticNumber2_Test
    {
        [TestMethod]
        public void FindStrobogrammatic0()
        {
            var solution = new _0247_StrobogrammaticNumber2();
            var result = solution.FindStrobogrammatic(0);
            AssertHelper.AssertArray(new List<string>(), result);
        }

        [TestMethod]
        public void FindStrobogrammatic1()
        {
            var solution = new _0247_StrobogrammaticNumber2();
            var result = solution.FindStrobogrammatic(1);
            AssertHelper.AssertCollectionAnyOrder(new List<string> {"0", "1", "8"}, result);
        }

        [TestMethod]
        public void FindStrobogrammatic2()
        {
            var solution = new _0247_StrobogrammaticNumber2();
            var result = solution.FindStrobogrammatic(2);
            AssertHelper.AssertCollectionAnyOrder(new List<string> {"11", "69", "88", "96"}, result);
        }

        [TestMethod]
        public void FindStrobogrammatic4()
        {
            var solution = new _0247_StrobogrammaticNumber2();
            var result = solution.FindStrobogrammatic(4);
            AssertHelper.AssertCollectionAnyOrder(
                new List<string>
                {
                    "1001", "1111", "1691", "1881", "1961", "6009", "6119", "6699", "6889", "6969", "8008", "8118",
                    "8698", "8888", "8968", "9006", "9116", "9696", "9886", "9966"
                }, result);
        }

        [TestMethod]
        public void FindStrobogrammatic6()
        {
            var solution = new _0247_StrobogrammaticNumber2();
            var result = solution.FindStrobogrammatic(6);
            AssertHelper.AssertCollectionAnyOrder(
                new List<string>
                {
                    "100001", "101101", "106901", "108801", "109601", "110011", "111111", "116911", "118811", "119611",
                    "160091", "161191", "166991", "168891", "169691", "180081", "181181", "186981", "188881", "189681",
                    "190061", "191161", "196961", "198861", "199661", "600009", "601109", "606909", "608809", "609609",
                    "610019", "611119", "616919", "618819", "619619", "660099", "661199", "666999", "668899", "669699",
                    "680089", "681189", "686989", "688889", "689689", "690069", "691169", "696969", "698869", "699669",
                    "800008", "801108", "806908", "808808", "809608", "810018", "811118", "816918", "818818", "819618",
                    "860098", "861198", "866998", "868898", "869698", "880088", "881188", "886988", "888888", "889688",
                    "890068", "891168", "896968", "898868", "899668", "900006", "901106", "906906", "908806", "909606",
                    "910016", "911116", "916916", "918816", "919616", "960096", "961196", "966996", "968896", "969696",
                    "980086", "981186", "986986", "988886", "989686", "990066", "991166", "996966", "998866", "999666"
                }, result);
        }
    }
}