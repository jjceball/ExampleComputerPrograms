using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace SNSD
{
    [TestFixture]
    public class GGTests
    {
        private GirlsGeneration GG;

        [SetUp]
        public void initializeGG()
        {
            GG = new GirlsGeneration();
        }

        [TearDown]
        public void clearGG()
        {
            GG = null;
        }
        
        [Test]
        public void testMain()
        {
            string g1 = GG.InitializeGirls();
            string g2 = GG.InitializeSongs();
            string g3 = GG.InitializeBiases();
            Assert.IsNotNullOrEmpty(g1);
            Assert.IsNotNullOrEmpty(g2);
            Assert.IsNotNullOrEmpty(g3);
        }

        [Test]
        public void testInitializeGirls()
        {
            string g1 = GG.InitializeGirls();
            Assert.IsNotNullOrEmpty(g1);
        }

        [Test]
        public void testInitializeSongs()
        {
            string g2 = GG.InitializeSongs();
            Assert.IsNotNullOrEmpty(g2);
        }

        [Test]
        public void testInitializeBiases()
        {
            string g3 = GG.InitializeBiases();
            Assert.IsNotNullOrEmpty(g3);
        }

        // Testing Girls
        [Test]
        public void testTaeyeon()
        {
            Members _member = GG.Taeyeon();
            Assert.AreEqual(_member.memberName, "Taeyeon");
            Assert.AreEqual(_member.memberRank, 3);
            Assert.AreEqual(_member.memberPosition, "Vocal Line");
            Assert.AreEqual( _member.funnyMember, false);
        }

        [Test]
        public void testTiffany()
        {
            Members _member = GG.Tiffany();
            Assert.AreEqual(_member.memberName, "Tiffany");
            Assert.AreEqual(_member.memberRank, 1);
            Assert.AreEqual(_member.memberPosition, "Vocal Line");
            Assert.AreEqual(_member.funnyMember, false);
        }

        [Test]
        public void testYuri()
        {
            Members _member = GG.Yuri();
            Assert.AreEqual(_member.memberName, "Yuri");
            Assert.AreEqual(_member.memberRank, 2);
            Assert.AreEqual(_member.memberPosition, "Dance Line");
            Assert.AreEqual(_member.funnyMember, true);
        }

        [Test]
        public void testSunny()
        {
            Members _member = GG.Sunny();
            Assert.AreEqual(_member.memberName, "Sunny");
            Assert.AreEqual(_member.memberRank, 4);
            Assert.AreEqual(_member.memberPosition, "Vocal Line");
            Assert.AreEqual(_member.funnyMember, true);
        }

        [Test]
        public void testHyoyeon()
        {
            Members _member = GG.Hyoyeon();
            Assert.AreEqual(_member.memberName, "Hyoyeon");
            Assert.AreEqual(_member.memberRank, 7);
            Assert.AreEqual(_member.memberPosition, "Dance Line");
            Assert.AreEqual(_member.funnyMember, false);
        }

        [Test]
        public void testYoona()
        {
            Members _member = GG.Yoona();
            Assert.AreEqual(_member.memberName, "Yoona");
            Assert.AreEqual(_member.memberRank, 8);
            Assert.AreEqual(_member.memberPosition, "Dance Line");
            Assert.AreEqual(_member.funnyMember, false);
        }

        [Test]
        public void testSooYoung()
        {
            Members _member = GG.SooYoung();
            Assert.AreEqual(_member.memberName, "SooYoung");
            Assert.AreEqual(_member.memberRank, 6);
            Assert.AreEqual(_member.memberPosition, "Dance Line");
            Assert.AreEqual(_member.funnyMember, true);
        }

        [Test]
        public void testSeohyun()
        {
            Members _member = GG.Seohyun();
            Assert.AreEqual(_member.memberName, "Seohyun");
            Assert.AreEqual(_member.memberRank, 5);
            Assert.AreEqual(_member.memberPosition, "Vocal Line");
            Assert.AreEqual(_member.funnyMember, false);
        }

        // Test Songs
        [Test]
        public void testGee()
        {
            Songs _song = GG.Gee();
            Assert.AreEqual(_song.songName, "Gee");
            Assert.AreEqual(_song.songLanguage, "Korean and Japanese");
            Assert.AreEqual(_song.danceableSong, true);
        }

        [Test]
        public void testIntoTheNewWorld()
        {
            Songs _song = GG.IntoTheNewWorld();
            Assert.AreEqual(_song.songName, "Into The New World");
            Assert.AreEqual(_song.songLanguage, "Korean");
            Assert.AreEqual(_song.danceableSong, false);
        }

        [Test]
        public void testCatchMeIfYouCan()
        {
            Songs _song = GG.CatchMeIfYouCan();
            Assert.AreEqual(_song.songName, "Catch Me If You Can");
            Assert.AreEqual(_song.songLanguage, "Korean");
            Assert.AreEqual(_song.danceableSong, true);
        }

        [Test]
        public void testIGotABoy()
        {
            Songs _song = GG.IGotABoy();
            Assert.AreEqual(_song.songName, "I Got A Boy");
            Assert.AreEqual(_song.songLanguage, "Korean");
            Assert.AreEqual(_song.danceableSong, true);
        }

        // Test Biases
        [Test]
        public void testBiasTiffany()
        {
            Biases _bias = GG.biasTiffany();
            Assert.AreEqual(_bias.biasName, "Tiffany");
            Assert.AreEqual(_bias.biasRank, 1);
            Assert.AreEqual(_bias.phoneWallpaper, true);
        }

        [Test]
        public void testBiasYuri()
        {
            Biases _bias = GG.biasYuri();
            Assert.AreEqual(_bias.biasName, "Yuri");
            Assert.AreEqual(_bias.biasRank, 2);
            Assert.AreEqual(_bias.phoneWallpaper, true);
        }

        [Test]
        public void testBiasTaeyeon()
        {
            Biases _bias = GG.biasTaeyeon();
            Assert.AreEqual(_bias.biasName, "Taeyeon");
            Assert.AreEqual(_bias.biasRank, 3);
            Assert.AreEqual(_bias.phoneWallpaper, false);
        }

        [Test]
        public void testBiasSunny()
        {
            Biases _bias = GG.biasSunny();
            Assert.AreEqual(_bias.biasName, "Sunny");
            Assert.AreEqual(_bias.biasRank, 4);
            Assert.AreEqual(_bias.phoneWallpaper, false);
        }


    }
}
