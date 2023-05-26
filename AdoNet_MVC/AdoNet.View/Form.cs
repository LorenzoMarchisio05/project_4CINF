using AdoNet.Controller;
using System.IO;
using System.Windows.Forms;

namespace AdoNet.View
{
    public partial class Form : System.Windows.Forms.Form
    {
        private static readonly string DB_PATH = Path.Combine(Application.StartupPath, "DataSources", "DB_4C_2023.mdf");

        private static readonly string _connectionString = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={DB_PATH};Integrated Security=True;Connect Timeout=30";

        private readonly StudentsController _studentsController;

        public Form()
        {
            _studentsController = new StudentsController(_connectionString);

            InitializeComponent();
        }
    }
}
