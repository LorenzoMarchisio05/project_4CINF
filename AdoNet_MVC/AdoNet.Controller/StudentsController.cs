namespace AdoNet.Controller
{
    public sealed class StudentsController
    {
        private readonly AdoNetDBController _adoNetDBController;

        public StudentsController(string connectionString)
        {
            _adoNetDBController = new AdoNetDBController(connectionString);
        }
    }
}
