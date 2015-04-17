using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace SNSD
{
    public class GirlsGeneration
    {
        // Girls Variables within Class
        Members _member = new Members();
        string mName;
        int mRank;
        string mPosition;
        Boolean mFunny;
        string isFunny;

        // Songs Variables within Class
        Songs _song = new Songs();
        string sName;
        string sLanguage;
        Boolean letsDance;
        string isDanceable;

        // Biases Variables within Class
        Biases _fav = new Biases();
        string bName;
        int bRank;
        Boolean wallpaper;
        string phone;
        string whyAmIBiased;

        public void printMemberInfo()
        {
            // Print Member Info
            Console.WriteLine("Hi I'm " + mName + "!");
            Console.WriteLine("My member rank in SNSD is " + mRank);
            Console.WriteLine("My position in SNSD is on the " + mPosition);
            Console.WriteLine("Do members think I am funny? " + isFunny);
            Console.WriteLine();
        }

        public void printSongInfo()
        {
            // Print Song Info
            Console.WriteLine("The name of this SNSD song is " + sName);
            Console.WriteLine("The language of this SNSD song is " + sLanguage);
            Console.WriteLine("Is this song danceable? " + isDanceable);
            Console.WriteLine();
        }

        public void printBiasInfo()
        {
            // Print Bias Info
            Console.WriteLine("Hi I'm " + bName + " and I am one of Jay's biases");
            Console.WriteLine("My rank in the top 4 is " + bRank);
            Console.WriteLine("Am I on Jay's phone as a wallpaper? " + phone);
            Console.WriteLine("Why am I one of Jay's biases? Because I am the" + whyAmIBiased);
            Console.WriteLine();
        }

        // Main Method
        public static void Main(string[] args)
        {
            GirlsGeneration GG = new GirlsGeneration();

            string g1 = GG.InitializeGirls();
            Console.WriteLine(g1);
            Console.WriteLine();

            string g2 = GG.InitializeSongs();
            Console.WriteLine(g2);
            Console.WriteLine();

            string g3 = GG.InitializeBiases();
            Console.WriteLine(g3);
            Console.WriteLine();
        }

        // Initialize Girls 
        public string InitializeGirls()
        {
            Taeyeon();
            Tiffany();
            Yuri();
            Sunny();
            Hyoyeon();
            Yoona();
            SooYoung();
            Seohyun();

            return "The 8 Members are set.";
        }

        // Initialize Songs
        public string InitializeSongs()
        {
            Gee();
            IntoTheNewWorld();
            CatchMeIfYouCan();
            IGotABoy();

            return "The favorite songs are listed";
        }

        // Initalize Biases
        public string InitializeBiases()
        {
            biasTiffany();
            biasYuri();
            biasTaeyeon();
            biasSunny();

            return "The Bias List is complete";
        }

        // Seohyun
        public Members Seohyun()
        {     
            mName = _member.memberName = "Seohyun";
            mRank = _member.memberRank = 5;
            mPosition = _member.memberPosition = "Vocal Line";
            mFunny = _member.funnyMember = false;
            isFunny = _member.isFunny(mFunny);

            printMemberInfo();
            return _member;
        }

        // SooYoung
        public Members SooYoung()
        {
            mName = _member.memberName = "SooYoung";
            mRank = _member.memberRank = 6;
            mPosition = _member.memberPosition = "Dance Line";
            mFunny = _member.funnyMember = true;
            isFunny = _member.isFunny(mFunny);

            printMemberInfo();
            return _member;
        }

        // Yoona
        public Members Yoona()
        {
            mName = _member.memberName = "Yoona";
            mRank = _member.memberRank = 8;
            mPosition = _member.memberPosition = "Dance Line";
            mFunny = _member.funnyMember = false;
            isFunny = _member.isFunny(mFunny);

            printMemberInfo();
            return _member;
        }

        // Hyoyeon
        public Members Hyoyeon()
        {
            mName = _member.memberName = "Hyoyeon";
            mRank = _member.memberRank = 7;
            mPosition = _member.memberPosition = "Dance Line";
            mFunny = _member.funnyMember = false;
            isFunny = _member.isFunny(mFunny);

            printMemberInfo();
            return _member;
        }

        // Sunny
        public Members Sunny()
        {
            mName = _member.memberName = "Sunny";
            mRank = _member.memberRank = 4;
            mPosition = _member.memberPosition = "Vocal Line";
            mFunny = _member.funnyMember = true;
            isFunny = _member.isFunny(mFunny);

            printMemberInfo();
            return _member;
        }

        // Yuri
        public Members Yuri()
        {
            mName = _member.memberName = "Yuri";
            mRank = _member.memberRank = 2;
            mPosition = _member.memberPosition = "Dance Line";
            mFunny = _member.funnyMember = true;
            isFunny = _member.isFunny(mFunny);

            printMemberInfo();
            return _member;
        }

        // Tiffany
        public Members Tiffany()
        {
            mName = _member.memberName = "Tiffany";
            mRank =_member.memberRank = 1;
            mPosition = _member.memberPosition = "Vocal Line";
            mFunny = _member.funnyMember = false;
            isFunny = _member.isFunny(mFunny);

            printMemberInfo();
            return _member;
        }

        // Taeyeon
        public Members Taeyeon()
        {
            mName = _member.memberName = "Taeyeon";
            mRank = _member.memberRank = 3;
            mPosition = _member.memberPosition = "Vocal Line";
            mFunny = _member.funnyMember = false;
            isFunny = _member.isFunny(mFunny);

            printMemberInfo();
            return _member;
        }

        // I Got A Boy
        public Songs IGotABoy()
        {
            sName = _song.songName = "I Got A Boy";
            sLanguage = _song.songLanguage = "Korean";
            letsDance = _song.danceableSong = true;
            isDanceable = _song.isDanceable(letsDance);

            printSongInfo();
            return _song;
        }

        // Catch Me If You Can
        public Songs CatchMeIfYouCan()
        {
            sName = _song.songName = "Catch Me If You Can";
            sLanguage = _song.songLanguage = "Korean";
            letsDance = _song.danceableSong = true;
            isDanceable = _song.isDanceable(letsDance);

            printSongInfo();
            return _song;
        }
        
        // IntoTheNewWorld
        public Songs IntoTheNewWorld()
        {
            sName = _song.songName = "Into The New World";
            sLanguage = _song.songLanguage = "Korean";
            letsDance = _song.danceableSong = false;
            isDanceable = _song.isDanceable(letsDance);

            printSongInfo();
            return _song;
        }

        // Gee
        public Songs Gee()
        {
            sName = _song.songName = "Gee";
            sLanguage = _song.songLanguage = "Korean and Japanese";
            letsDance = _song.danceableSong = true;
            isDanceable = _song.isDanceable(letsDance);

            printSongInfo();
            return _song;
        }

        // Sunny Bias
        public Biases biasSunny()
        {
            bName = _fav.biasName = "Sunny";
            bRank = _fav.biasRank = 4;
            wallpaper = _fav.phoneWallpaper = false;
            phone = _fav.onPhone(wallpaper);
            whyAmIBiased = _fav.biased = "Cutest Member";

            printBiasInfo();
            return _fav;
        }

        // Taeyeon Bias
        public Biases biasTaeyeon()
        {
            bName = _fav.biasName = "Taeyeon";
            bRank = _fav.biasRank = 3;
            wallpaper = _fav.phoneWallpaper = false;
            phone = _fav.onPhone(wallpaper);
            whyAmIBiased = _fav.biased = "Most Talented Member";

            printBiasInfo();
            return _fav;
        }

        // Yuri Bias
        public Biases biasYuri()
        {
            bName = _fav.biasName = "Yuri";
            bRank = _fav.biasRank = 2;
            wallpaper = _fav.phoneWallpaper = true;
            phone = _fav.onPhone(wallpaper);
            whyAmIBiased = _fav.biased = "Sexiest Member";

            printBiasInfo();
            return _fav;
        }

        // Tiffany Bias
        public Biases biasTiffany()
        {
            bName = _fav.biasName = "Tiffany";
            bRank = _fav.biasRank = 1;
            wallpaper = _fav.phoneWallpaper = true;
            phone = _fav.onPhone(wallpaper);
            whyAmIBiased = _fav.biased = "Prettiest Member";

            printBiasInfo();
            return _fav;
        }
    }
}
