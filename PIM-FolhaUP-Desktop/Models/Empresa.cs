using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace PIM_FolhaUP_Desktop.Models
{
    public class Empresa
    {
        private long cnpj;
        private string razaosocial;
        private string endereco; 
        private DateTime dataabertura;
        private bool situacaocadastral;
        private string telefone;
        private string email;
        private string senha;

        public Empresa(long _cnpj, string _razaosocial, string _endereco, DateTime _dataabertura, bool _situacaocadastral, string _telefone, string _email, string _senha)
        {
            this.setCNPJ(_cnpj);
            this.setRazaoSocial(_razaosocial);
            this.setEndereco(_endereco);
            this.setDataAbertura(_dataabertura);
            this.setSituacaoCadastral(_situacaocadastral);
            this.setTelefone(_telefone);
            this.setEmail(_email);
            this.setSenha(_senha);
        }

        public Empresa()
        { 

        }

        public long getCNPJ()
        {
            return cnpj;
        }

        public void setCNPJ(long cnpj)
        {
            this.cnpj = cnpj;
        }

        public string getRazaoSocial()
        {
            return razaosocial;
        }

        public void setRazaoSocial(string razaosocial)
        {
            this.razaosocial = razaosocial;
        }

        public DateTime getDataAbertura()
        {
            return dataabertura;
        }

        public void setDataAbertura(DateTime dataabertura)
        {
            this.dataabertura = dataabertura;
        }

        public string getEmail()
        {
            return email;
        }

        public void setEmail(string email)
        {
            this.email = email;
        }

        public string getSenha()
        {
            return senha;
        }

        public void setSenha(string senha)
        {
            this.senha = senha;
        }

        public String getEndereco()
        {
            return endereco;
        }

        public void setEndereco(string endereco)
        {
            this.endereco = endereco;
        }

        public bool getSituacaoCadastral()
        {
            return situacaocadastral;
        }

        public void setSituacaoCadastral(bool situacaocadastral)
        {
            this.situacaocadastral = situacaocadastral;
        }

        public string getTelefone()
        {
            return telefone;
        }

        public void setTelefone(string telefone)
        {
            this.telefone = telefone;
        }

    }
}
