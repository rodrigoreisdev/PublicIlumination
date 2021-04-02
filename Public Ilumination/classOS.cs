using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Public_Ilumination
{
    public class classOS
    {
        int id;
        string nome;
        string dataAbertura;
        string dataFechamento;
        int poste;
        string endereco;
        string[] defeitos;
        string[] servicos;
        string status; 

        public int Id { get => id;}
        public string Nome { get => nome; set => nome = value; }
        public string DataAbertura { get => dataAbertura; set => dataAbertura = value; }
        public string DataFechamento { get => dataFechamento; set => dataFechamento = value; }
        public int Poste { get => poste; set => poste = value; }
        public string Endereco { get => endereco; set => endereco = value; }
        public string Status { get => status; set => status = value; }
        public string[] Defeitos { get => defeitos; set => defeitos = value; }
        public string[] Servicos { get => servicos; set => servicos = value; }

        public classOS(int id) 
        {
            this.id = id;
        }


    }

}
