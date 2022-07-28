using Ado;

namespace Projeto01
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            string verificarConexao = Conexao.Conectar();
            if (verificarConexao == "")
            {
                Application.Run(new Form1());
            }
            else
            {
                MessageBox.Show(verificarConexao, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}