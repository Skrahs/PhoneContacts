namespace PhoneContacts.Models
{
    public class Contatto
    {
        public string Nome { get; set; }
        public string NumeroTelefono { get; set; }
        public string Email { get; set; }

        public Contatto(string nome, string numeroTelefono, string email)
        {
            Nome = nome;
            NumeroTelefono = numeroTelefono;
            Email = email;
        }

        public override string ToString()
        {
            return $"Nome: {Nome}, Telefono: {NumeroTelefono}, Email: {Email}";
        }
    }
}
