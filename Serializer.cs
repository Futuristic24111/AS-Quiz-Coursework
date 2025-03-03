using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Quiz_Coursework.Classes
{
    public class Serializer
    {
        public static bool SerializePlayer()
        {
            try
            {
                double Score = StartScreen.Player.Score;
                try
                {
                    string tempFile = Path.GetTempFileName();
                    using (var sw = new StreamWriter(tempFile))
                    {
                        string[] parts = new string[2];
                        string toAdd1 = Player.Username;
                        string toAdd2 = Convert.ToString(Score);
                        parts[0] = toAdd1;
                        parts[1] = toAdd2;
                        string line = string.Join(",", parts);
                        sw.WriteLine(line);
                    }
                    File.Delete(@"LastPlayer.bin");
                    File.Move(tempFile, @"LastPlayer.bin");
                }
                catch (IOException ioexp)
                {
                    MessageBox.Show("Error: {0}", ioexp.Message);
                }

                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }
        public static string objectDeSerialized = string.Empty;
        public static string DeserializePlayer()
        {
            string line = null;
            using (var sr = new StreamReader(@"LastPlayer.bin"))
            {
                while ((line = sr.ReadLine()) != null)
                {
                    return line;
                }
            }
            return line;
        }
    }
}
