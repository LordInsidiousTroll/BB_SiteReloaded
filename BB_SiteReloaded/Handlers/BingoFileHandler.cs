using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using Newtonsoft.Json;

namespace BB_SiteReloaded.Handlers {
    public static class BingoFileHandler {

        private static Random rng = new Random();

        public static List<string> GetAllBingoStrings() {
            string path = @"C:\sites\BB_SiteReloaded\Data\bingoPhrases.json";
            var line = File.ReadAllText(path);
            var lines = JsonConvert.DeserializeObject<List<string>>(line);
            return lines;
        }

        public static List<string> Get25UniqueStrings() {
            var strings = GetAllBingoStrings();
            strings.Shuffle();
            return strings.GetRange(0, 25);
        }

        public static List<List<string>> Get25UniqueStringsAsLists() {
            var strings = GetAllBingoStrings();
            strings.Shuffle();
            List<List<string>> r = new List<List<string>>();
            r.Add(strings.GetRange(0,5));
            r.Add(strings.GetRange(5,5));
            r.Add(strings.GetRange(10,5));
            r.Add(strings.GetRange(15,5));
            r.Add(strings.GetRange(20,5));
            return r;
        }

        public static void Shuffle<T>(this IList<T> list) {
            int n = list.Count;
            while (n > 1) {
                n--;
                int k = rng.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }
    }
}