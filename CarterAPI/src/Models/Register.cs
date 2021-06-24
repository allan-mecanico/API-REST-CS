namespace CarterAPI.Models
{
    public class Register
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
	    public string Email { get; set; }

    	public string Telefone { get; set; }

    	public string Sexo { get; set; }

    	public string Nacimento { get; set; }

        public override string ToString() => Id + Nome + Cpf + Email + Telefone + Sexo + Nacimento ;
         
       
    }
}                   