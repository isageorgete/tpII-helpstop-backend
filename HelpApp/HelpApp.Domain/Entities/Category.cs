using System;
using HelpApp.Domain.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace HelpApp.Domain.Entities
{
    class Category
    {
        #region Atributos 
        public int Id { get; set; }
        public string Name { get; set; }
        #endregion

        #region Constructors
        public Category(string name)
        {
            Name = name;
        }


        public ICollection<Product> Products { get; set; }
        #endregion
        #region Validacao
        private void ValidationDomain(string name)
        {
            DomainExcceptionValidation.When(string.IsNullOrEmpty(name), 
                "Invalid name, name is required");
            DomainExcceptionValidation.When(name.Length < 3,
                "Invalid name, too short, minimum 3 charecters");
            Name = name;
        }
        #endregion
    }
}
