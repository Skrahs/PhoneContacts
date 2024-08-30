using Newtonsoft.Json;
using PhoneContacts.Models;
using System.IO;

namespace PhoneContacts.Services
{
    public class GestioneFile
    {
        public static void SalvaRubricaSuFile(Rubrica rubrica, string filePath)
        {
            var json = JsonConvert.SerializeObject(rubrica.GetContatti(), Formatting.Indented);
            File.WriteAllText(filePath, json);
        }

        public static Rubrica CaricaRubricaDaFile(string filePath)
        {
            if (!File.Exists(filePath))
            {
                return new Rubrica(); 
            }

            var json = File.ReadAllText(filePath);
            var contatti = JsonConvert.DeserializeObject<List<Contatto>>(json);
            Rubrica rubrica = new Rubrica();
            rubrica.SetContatti(contatti);
            return rubrica;
        }
    }
}
