namespace BibliotecaData
{
    public class Amigo
    {
        //-----------------------------------------------------------------------
        private string _nome;
        private string _sobrenome;
        private DateTime _dataAniversario;

        //-----------------------------------------------------------------------
        public string Nome
        {
            get
            {
                return _nome;
            }
            set
            {
                _nome = value;
            }
        }
        public string Sobrenome
        {
            get
            {
                return _sobrenome;
            }
            set
            {
                _sobrenome = value;
            }
        }
        public DateTime dataAniversario
        {
            get
            {
                return _dataAniversario;
            }
            set
            {
                _dataAniversario = value;
            }
        }
    }
}