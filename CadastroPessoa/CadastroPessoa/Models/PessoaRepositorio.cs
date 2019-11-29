using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CadastroPessoa.Models
{
    public class PessoaRepositorio : IPessoaRepositorio
    {
        private List<Pessoa> pessoas = new List<Pessoa>();
        private int _nextId = 1;

        public PessoaRepositorio()
        {
            Add(new Pessoa { Categoria = "Física", Nome = "João Mendes", Endereco = "Avendia x", Bairro = "Aldeota", Cidade = "Fortaleza", Estado = "Ceará" , Telefone = "999999970" , Email = "joao@gmail.com"});
            Add(new Pessoa { Categoria = "Física", Nome = "Antonio Marcos", Endereco = "Avendia j", Bairro = "Messejana", Cidade = "Fortaleza", Estado = "Ceará", Telefone = "999994570", Email = "am@gmail.com" });
            Add(new Pessoa { Categoria = "Física", Nome = "Marcondes", Endereco = "Avendia b", Bairro = "Papicu", Cidade = "Fortaleza", Estado = "Ceará", Telefone = "997599970", Email = "marcon@gmail.com" });
            Add(new Pessoa { Categoria = "Física", Nome = "Manoel", Endereco = "Avendia t", Bairro = "Meíreles", Cidade = "Fortaleza", Estado = "Ceará", Telefone = "889999970", Email = "mano@gmail.com" });
            Add(new Pessoa { Categoria = "Física", Nome = "Paulo Vitor", Endereco = "Avendia k", Bairro = "Parangada", Cidade = "Fortaleza", Estado = "Ceará", Telefone = "999799970", Email = "paulovito@gmail.com" });
            Add(new Pessoa { Categoria = "Física", Nome = "Felipe", Endereco = "Avendia a", Bairro = "Bom Jardim", Cidade = "Fortaleza", Estado = "Ceará", Telefone = "999459970", Email = "felipe@gmail.com" });
        }

        public Pessoa Add(Pessoa item)
        {
            if (item == null)
            {
                throw new ArgumentNullException("item");
            }
            item.Id = _nextId++;
            pessoas.Add(item);
            return item;
        }

        public Pessoa Get(int id)
        {
            return pessoas.Find(p => p.Id == id);
        }

        public IEnumerable<Pessoa> GetAll()
        {
            return pessoas;
        }

        public void Remove(int id)
        {
            pessoas.RemoveAll(p => p.Id == id);
        }

        public bool Update(Pessoa item)
        {
            if (item == null)
            {
                throw new ArgumentNullException("item");
            }

            int index = pessoas.FindIndex(p => p.Id == item.Id);

            if (index == -1)
            {
                return false;
            }
            pessoas.RemoveAt(index);
            pessoas.Add(item);
            return true;
        }
    }
}