using AlocArmario.Controller;
using AlocArmario.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlocArmario.View.Cadastro
{
    public partial class CadastroUsuario : Form
    {
        const string LOWER = "abcdefghijklmnopqrstuvwxyz";
        const string UPPER = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        const string NUMBER = "0123456789";
        const string SPECIAL = @"~!@#$%^&*():;[]{}<>,.?/\|";

        UsuarioController uc;
        Usuario usuario;

        public CadastroUsuario()
        {
            InitializeComponent();

            uc = new UsuarioController();
            usuario = new Usuario();

            var provedor = new AssociatedMetadataTypeTypeDescriptionProvider(typeof(Usuario));
            TypeDescriptor.AddProvider(provedor, typeof(Usuario));
        }

        private bool TemNumero(string senha)
        {
            bool resultado = false;
            char[] numeros = NUMBER.ToCharArray();
            foreach (char c in numeros)
                if (senha.Contains(c))
                {
                    resultado = true;
                    break;
                }
                else
                    resultado = false; 
            
            return resultado; 
        }

        private bool TemEspecial(string senha)
        {
            bool resultado = false;
            char[] especiais = SPECIAL.ToCharArray();
            foreach (char c in especiais)
                if (senha.Contains(c))
                {
                    resultado = true;
                    break;
                }
                else
                    resultado = false;

            return resultado;
        }

        private bool EstaVazio()
        {
            bool resultado = false;

            if (txbNome.Text.Length == 0)
                resultado = true;
            if (txbPront.Text.Length == 0)
                resultado = true;
            if (txbSenha.Text.Length == 0)
                resultado = true;
            if (txbConfirmaSenha.Text.Length == 0)
                resultado = true;

            return resultado;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (EstaVazio())
            {
                MessageBox.Show("Preencha todos os campos", "Novo Usuário", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (txbPront.Text.Length != 7)
            {
                MessageBox.Show("O prontuário deve conter 7 caracteres", "Novo Usuário", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (txbSenha.Text.Length < 8)
            {
                MessageBox.Show("A senha deve conter ao mínimo 8 caracteres", "Novo Usuário", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (!TemNumero(txbSenha.Text))
            {
                MessageBox.Show("A senha deve conter ao mínimo 1 caractere numérico de 0 à 9", "Novo Usuário", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (!TemEspecial(txbSenha.Text))
            {
                MessageBox.Show("A senha deve conter ao mínimo 1 caractere especial: " + SPECIAL, "Novo Usuário", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (txbSenha.Text != txbConfirmaSenha.Text)
            {
                MessageBox.Show("As senhas não coincidem", "Novo Usuário", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            usuario.Nome = txbNome.Text;
            usuario.Prontuario = txbPront.Text;
            usuario.Senha = txbSenha.Text;            

            string resultado = uc.Inserir(usuario);
            switch (resultado)
            {
                case "ok":
                    break;
                case "okadmin":
                    break;
                case "erro":
                    break;
            }
        }
    }
}
