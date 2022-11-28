using Es13_Regex.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Es13_Regex
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnMatch_click(object sender, EventArgs e)
        {
            string option = (sender as Button).Name.Replace("btn", "").ToLower();

            IValidator validator = GetValidator(option);

            ValidateInput(validator, txtInput.Text);
        }

        private static IValidator GetValidator(string option)
        {
            IValidator validator;
            switch (option)
            {
                case "telefono":
                    validator = new TelephoneValidator();
                    break;
                case "classe":
                    validator = new ClassValidator();
                    break;
                case "specializzazione":
                    validator = new SpecValidator();
                    break;
                case "codicefiscale":
                    validator = new CFValidator();
                    break;
                case "indirizzo":
                    validator = new AddressValidator();
                    break;
                case "email":
                    validator = new EmailValidator();
                    break;
                case "importo":
                    validator = new ImportValidator();
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }

            return validator;
        }

        private void ValidateInput(IValidator validator, string input)
        {
            MessageBox.Show(validator.Validate(input) ? 
                "Valid input" : 
                $@"invalid input: ""{input}""");
        }
    }
}
