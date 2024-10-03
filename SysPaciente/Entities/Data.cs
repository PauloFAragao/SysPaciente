using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Diagnostics;

namespace SysPaciente.Entities
{
    internal class Data
    {
        //------------------------------------- pacientes -------------------------------------

        // método que vai pegar 50 clientes do banco de dados e exibir
        public static DataTable ShowClients()
        {
            // Objeto do tipo DataTable
            DataTable dtResult = new DataTable("clients");

            // Objeto da conexão com o banco de dados
            using (SqlConnection sqlCon = new SqlConnection(Connection.Cn))
            {
                try
                {
                    // Abrindo a conexão ao banco de dados
                    sqlCon.Open();

                    // Comando SQL - que está no banco de dados
                    using (SqlCommand sqlCmd = new SqlCommand("sp_show_clients", sqlCon))
                    {
                        // chamando um procedimento armazenado no banco de dados.
                        sqlCmd.CommandType = CommandType.StoredProcedure;

                        // Objeto que vai guardar informações da tabela
                        using (SqlDataAdapter sqlDat = new SqlDataAdapter(sqlCmd))
                        {
                            // Preenchendo o DataTable
                            sqlDat.Fill(dtResult);
                        }
                    }
                }
                catch (Exception ex)
                {
                    dtResult = null;
                    Debug.WriteLine("Exception: " + ex.Message);
                }
            }

            return dtResult;
        }

        // método que vai pesquisar um passiente pelo nome
        public static DataTable SearchClienteName(string name)
        {
            // Objeto do tipo DataTable
            DataTable dtResult = new DataTable("clients");

            // Objeto da conexão com o banco de dados
            using (SqlConnection sqlCon = new SqlConnection(Connection.Cn))
            {
                try
                {
                    // Abrindo a conexão ao banco de dados
                    sqlCon.Open();

                    // Configurando o comando SQL
                    using (SqlCommand sqlCmd = new SqlCommand("sp_search_clientName", sqlCon))
                    {
                        // chamando um procedimento armazenado no banco de dados.
                        sqlCmd.CommandType = CommandType.StoredProcedure;

                        // Adicionando o parâmetro ao comando SQL
                        sqlCmd.Parameters.Add(CreateSqlParameter(name, "@name", 100));

                        // Criando o DataAdapter
                        using (SqlDataAdapter sqlDat = new SqlDataAdapter(sqlCmd))
                        {
                            // Preenchendo o DataTable
                            sqlDat.Fill(dtResult);
                        }
                    }
                }
                catch (Exception ex)
                {
                    dtResult = null;
                    Debug.WriteLine("Exception: " + ex.Message);
                }
            }
            return dtResult;
        }

        // método que vai pesquisar um passiente pelo nome
        public static DataTable SearchClienteCPF(string cpf)
        {
            // Objeto do tipo DataTable
            DataTable dtResult = new DataTable("clients");

            // Objeto da conexão com o banco de dados
            using (SqlConnection sqlCon = new SqlConnection(Connection.Cn))
            {
                try
                {
                    // Abrindo a conexão ao banco de dados
                    sqlCon.Open();

                    // Configurando o comando SQL
                    using (SqlCommand sqlCmd = new SqlCommand("sp_search_clientCPF", sqlCon))
                    {
                        // chamando um procedimento armazenado no banco de dados.
                        sqlCmd.CommandType = CommandType.StoredProcedure;

                        // Adicionando o parâmetro ao comando SQL
                        sqlCmd.Parameters.Add(CreateSqlParameter(cpf, "@cpf", 100));

                        // Criando o DataAdapter
                        using (SqlDataAdapter sqlDat = new SqlDataAdapter(sqlCmd))
                        {
                            // Preenchendo o DataTable
                            sqlDat.Fill(dtResult);
                        }
                    }
                }
                catch (Exception ex)
                {
                    dtResult = null;
                    Debug.WriteLine("Exception: " + ex.Message);
                }
            }
            return dtResult;
        }

        // método que vai pesquisar um paciente pelo id e retornar o nome, o telefone e a data de nascimento
        public static string[] SearchCliente(int idClient)
        {
            string[] str = new string[3];

            // Objeto da conexão com o banco de dados
            using (SqlConnection sqlCon = new SqlConnection(Connection.Cn))
            {
                try
                {
                    // Abrindo a conexão ao banco de dados
                    sqlCon.Open();

                    // Configurando o comando SQL
                    using (SqlCommand sqlCmd = new SqlCommand("sp_search_client_name", sqlCon))
                    {
                        // chamando um procedimento armazenado no banco de dados.
                        sqlCmd.CommandType = CommandType.StoredProcedure;

                        // Adicionando o parâmetro ao comando SQL
                        sqlCmd.Parameters.Add(CreateSqlParameter(idClient, "@idClient"));

                        //executando e capturando o a resposta da procidure
                        SqlDataReader reader = sqlCmd.ExecuteReader();
                        if (reader.Read())
                        {
                            str[0] = reader["name"].ToString(); // Capturando o nome do cliente
                            str[1] = reader["telephone"].ToString(); // Capturando o telefone
                            str[2] = reader["dateOfBirth"].ToString(); // Capturando a data de nascimento

                            Debug.WriteLine("Name: " + reader["name"].ToString());
                            Debug.WriteLine("telephone: " + reader["telephone"].ToString());
                            Debug.WriteLine("dateOfBirth: " + reader["dateOfBirth"].ToString());
                        }
                    }
                }
                catch (Exception ex)
                {
                    str = null;
                    Debug.WriteLine("Exception: " + ex.Message);
                }
            }

            return str;
        }

        // método que vai inserir um cliente no banco de dados
        public static string InsertClient(string name, string telephone, DateTime dateOfBirth, string street, string houseNumber,
            string neighborhood, string city, string cep, string state, string complement, string idNumber, string cpf)
        {
            string resp = "";

            // Cria uma conexão com o banco de dados e garante que ela será fechada e liberada corretamente após o uso.
            using (SqlConnection sqlCon = new SqlConnection(Connection.Cn))
            {
                try
                {
                    // Abrindo conexão
                    sqlCon.Open();

                    // Cria um comando SQL que vai chamar uma stored procedure
                    using (SqlCommand sqlCmd = new SqlCommand("sp_insert_client", sqlCon))
                    {
                        // chamando um procedimento armazenado no banco de dados.
                        sqlCmd.CommandType = CommandType.StoredProcedure;

                        // Parâmetro sql para o nome do paciente
                        sqlCmd.Parameters.Add(CreateSqlParameter(name, "@name", 100));

                        // Parâmetro sql para o telefone
                        sqlCmd.Parameters.Add(CreateSqlParameter(telephone, "@telephone", 20));

                        // Parâmetro sql para a data de nascimento
                        sqlCmd.Parameters.Add(CreateSqlParameter(dateOfBirth, "@dateOfBirth"));

                        // Parâmetro sql para o nome da rua
                        sqlCmd.Parameters.Add(CreateSqlParameter(street, "@street", 50));

                        // Parâmetro sql para o número da casa
                        sqlCmd.Parameters.Add(CreateSqlParameter(houseNumber, "@houseNumber", 10));

                        // Parâmetro sql para o Bairro
                        sqlCmd.Parameters.Add(CreateSqlParameter(neighborhood, "@neighborhood", 50));

                        // Parâmetro sql para a cidade
                        sqlCmd.Parameters.Add(CreateSqlParameter(city, "@city", 50));

                        // Parâmetro sql para o cep
                        sqlCmd.Parameters.Add(CreateSqlParameter(cep, "@cep", 9));

                        // Parâmetro sql para o estado
                        sqlCmd.Parameters.Add(CreateSqlParameter(state, "@state", 25));

                        // Parâmetro sql para o complemento
                        sqlCmd.Parameters.Add(CreateSqlParameter(complement, "@complement", 50));

                        // Parâmetro sql para o número da identidade
                        sqlCmd.Parameters.Add(CreateSqlParameter(idNumber, "@idNumber", 15));

                        // Parâmetro sql para o número do cpf
                        sqlCmd.Parameters.Add(CreateSqlParameter(cpf, "@cpf", 11));

                        // Executa o comando e captura o código de retorno
                        int returnCode = Convert.ToInt32(sqlCmd.ExecuteScalar());
                        if (returnCode == 0)
                            resp = "Registro inserido com sucesso.";
                        else
                            resp = $"Erro ao inserir registro. Código: {returnCode}";
                    }
                }
                catch (Exception ex)
                {
                    resp = $"Erro: {ex.Message}";
                    Debug.WriteLine("Exception: " + ex.Message);
                }
            }

            return resp;
        }

        // método que vai Editar um cliente no banco de dados
        public static string EditClient(int idClient, string telephone, DateTime dateOfBirth, string street, string houseNumber,
            string neighborhood, string city, string cep, string state, string complement)
        {
            string resp = "";

            // Cria uma conexão com o banco de dados e garante que ela será fechada e liberada corretamente após o uso.
            using (SqlConnection sqlCon = new SqlConnection(Connection.Cn))
            {
                try
                {
                    // Abrindo conexão
                    sqlCon.Open();

                    // Cria um comando SQL que vai chamar uma stored procedure
                    using (SqlCommand sqlCmd = new SqlCommand("sp_edit_client", sqlCon))
                    {
                        // chamando um procedimento armazenado no banco de dados.
                        sqlCmd.CommandType = CommandType.StoredProcedure;

                        // Parâmetro sql para o id do banco de dados
                        sqlCmd.Parameters.Add(CreateSqlParameter(idClient, "@idClient"));

                        // Parâmetro sql para o telefone
                        sqlCmd.Parameters.Add(CreateSqlParameter(telephone, "@telephone", 20));

                        // Parâmetro sql para a data de nascimento
                        sqlCmd.Parameters.Add(CreateSqlParameter(dateOfBirth, "@dateOfBirth"));

                        // Parâmetro sql para o nome da rua
                        sqlCmd.Parameters.Add(CreateSqlParameter(street, "@street", 50));

                        // Parâmetro sql para o número da casa
                        sqlCmd.Parameters.Add(CreateSqlParameter(houseNumber, "@houseNumber", 10));

                        // Parâmetro sql para o Bairro
                        sqlCmd.Parameters.Add(CreateSqlParameter(neighborhood, "@neighborhood", 50));

                        // Parâmetro sql para a cidade
                        sqlCmd.Parameters.Add(CreateSqlParameter(city, "@city", 50));

                        // Parâmetro sql para o cep
                        sqlCmd.Parameters.Add(CreateSqlParameter(cep, "@cep", 9));

                        // Parâmetro sql para o estado
                        sqlCmd.Parameters.Add(CreateSqlParameter(state, "@state", 25));

                        // Parâmetro sql para o complemento
                        sqlCmd.Parameters.Add(CreateSqlParameter(complement, "@complement", 50));

                        // Executa o comando e captura o código de retorno
                        int returnCode = Convert.ToInt32(sqlCmd.ExecuteScalar());
                        if (returnCode == 0)
                            resp = "Registro editado com sucesso.";
                        else
                            resp = $"Erro ao editar registro. Código: {returnCode}";
                    }
                }
                catch (Exception ex)
                {
                    resp = $"Erro: {ex.Message}";
                    Debug.WriteLine("Exception: " + ex.Message);
                }
            }

            return resp;
        }

        // método que vai Editar todos os dados do cliente no banco de dados
        public static string EditClientAdm(int idClient, string name, string telephone, DateTime dateOfBirth, string street,
            string houseNumber, string neighborhood, string city, string cep, string state, string complement, string idNumber, string cpf)
        {
            string resp = "";

            // Cria uma conexão com o banco de dados e garante que ela será fechada e liberada corretamente após o uso.
            using (SqlConnection sqlCon = new SqlConnection(Connection.Cn))
            {
                try
                {
                    // Abrindo conexão
                    sqlCon.Open();

                    // Cria um comando SQL que vai chamar uma stored procedure
                    using (SqlCommand sqlCmd = new SqlCommand("sp_edit_client_admin", sqlCon))
                    {
                        // chamando um procedimento armazenado no banco de dados.
                        sqlCmd.CommandType = CommandType.StoredProcedure;

                        // Parâmetro sql para o id do banco de dados
                        sqlCmd.Parameters.Add(CreateSqlParameter(idClient, "@idClient"));

                        // Parâmetro sql para o nome do paciente
                        sqlCmd.Parameters.Add(CreateSqlParameter(name, "@name", 100));

                        // Parâmetro sql para o telefone
                        sqlCmd.Parameters.Add(CreateSqlParameter(telephone, "@telephone", 20));

                        // Parâmetro sql para a data de nascimento
                        sqlCmd.Parameters.Add(CreateSqlParameter(dateOfBirth, "@dateOfBirth"));

                        // Parâmetro sql para o nome da rua
                        sqlCmd.Parameters.Add(CreateSqlParameter(street, "@street", 50));

                        // Parâmetro sql para o número da casa
                        sqlCmd.Parameters.Add(CreateSqlParameter(houseNumber, "@houseNumber", 10));

                        // Parâmetro sql para o Bairro
                        sqlCmd.Parameters.Add(CreateSqlParameter(neighborhood, "@neighborhood", 50));

                        // Parâmetro sql para a cidade
                        sqlCmd.Parameters.Add(CreateSqlParameter(city, "@city", 50));

                        // Parâmetro sql para o cep
                        sqlCmd.Parameters.Add(CreateSqlParameter(cep, "@cep", 9));

                        // Parâmetro sql para o estado
                        sqlCmd.Parameters.Add(CreateSqlParameter(state, "@state", 25));

                        // Parâmetro sql para o complemento
                        sqlCmd.Parameters.Add(CreateSqlParameter(complement, "@complement", 50));

                        // Parâmetro sql para o número da identidade
                        sqlCmd.Parameters.Add(CreateSqlParameter(idNumber, "@idNumber", 15));

                        // Parâmetro sql para o número do cpf
                        sqlCmd.Parameters.Add(CreateSqlParameter(cpf, "@cpf", 11));

                        // Executa o comando e captura o código de retorno
                        int returnCode = Convert.ToInt32(sqlCmd.ExecuteScalar());
                        if (returnCode == 0)
                            resp = "Registro editado com sucesso.";
                        else
                            resp = $"Erro ao editar registro. Código: {returnCode}";
                    }
                }
                catch (Exception ex)
                {
                    resp = $"Erro: {ex.Message}";
                    Debug.WriteLine("Exception: " + ex.Message);
                }
            }

            return resp;
        }

        // método para deletar um paciente
        public static string DeleteClient(int idClient)
        {
            string resp = "";

            // Cria uma conexão com o banco de dados e garante que ela será fechada e liberada corretamente após o uso.
            using (SqlConnection sqlCon = new SqlConnection(Connection.Cn))
            {
                try
                {
                    // Abrindo conexão
                    sqlCon.Open();

                    // Cria um comando SQL que vai chamar uma stored procedure
                    using (SqlCommand sqlCmd = new SqlCommand("sp_delete_client", sqlCon))
                    {
                        // chamando um procedimento armazenado no banco de dados.
                        sqlCmd.CommandType = CommandType.StoredProcedure;

                        // Parâmetro sql para o id do banco de dados
                        sqlCmd.Parameters.Add(CreateSqlParameter(idClient, "@idClient"));

                        // Executa o comando e captura o código de retorno
                        int returnCode = Convert.ToInt32(sqlCmd.ExecuteScalar());
                        if (returnCode == 0)
                            resp = "Registro deletado com sucesso.";
                        else
                            resp = $"Erro ao deletar registro. Código: {returnCode}";
                    }
                }
                catch (Exception ex)
                {
                    resp = $"Erro: {ex.Message}";
                    Debug.WriteLine("Exception: " + ex.Message);
                }
            }

            return resp;
        }

        //------------------------------------- consultas -------------------------------------

        // método que vai pegar as consultas da data no banco de dados
        public static DataTable SearchWithDate(DateTime date)
        {
            // Objeto do tipo DataTable
            DataTable dtResult = new DataTable("consultations");

            // Objeto da conexão com o banco de dados
            using (SqlConnection sqlCon = new SqlConnection(Connection.Cn))
            {
                try
                {
                    // Abrindo a conexão ao banco de dados
                    sqlCon.Open();

                    // Comando SQL - que está no banco de dados
                    using (SqlCommand sqlCmd = new SqlCommand("sp_search_with_date", sqlCon))
                    {
                        // chamando um procedimento armazenado no banco de dados.
                        sqlCmd.CommandType = CommandType.StoredProcedure;

                        // Adicionando o parâmetro ao comando SQL
                        sqlCmd.Parameters.Add(CreateSqlParameter(date, "@consultationDate"));

                        // Objeto que vai guardar informações da tabela
                        using (SqlDataAdapter sqlDat = new SqlDataAdapter(sqlCmd))
                        {
                            // Preenchendo o DataTable
                            sqlDat.Fill(dtResult);
                        }
                    }
                }
                catch (Exception ex)
                {
                    dtResult = null;
                    Debug.WriteLine("Exception: " + ex.Message);
                }
            }
            return dtResult;
        }

        // método que vai pegar as consultas da data com nome no banco de dados
        public static DataTable SearchWithDateAndName(DateTime date, string name)
        {
            // Objeto do tipo DataTable
            DataTable dtResult = new DataTable("consultations");

            // Objeto da conexão com o banco de dados
            using (SqlConnection sqlCon = new SqlConnection(Connection.Cn))
            {
                try
                {
                    // Abrindo a conexão ao banco de dados
                    sqlCon.Open();

                    // Comando SQL - que está no banco de dados
                    using (SqlCommand sqlCmd = new SqlCommand("sp_search_with_date_and_name", sqlCon))
                    {
                        // chamando um procedimento armazenado no banco de dados.
                        sqlCmd.CommandType = CommandType.StoredProcedure;

                        // parametro da data
                        sqlCmd.Parameters.Add(CreateSqlParameter(date, "@consultationDate"));

                        // parametro do nome
                        sqlCmd.Parameters.Add(CreateSqlParameter(name, "@name", 100));

                        // Objeto que vai guardar informações da tabela
                        using (SqlDataAdapter sqlDat = new SqlDataAdapter(sqlCmd))
                        {
                            // Preenchendo o DataTable
                            sqlDat.Fill(dtResult);
                        }
                    }
                }
                catch (Exception ex)
                {
                    dtResult = null;
                    Debug.WriteLine("Exception: " + ex.Message);
                }
            }
            return dtResult;
        }

        // método que vai inserir os dados da consulta marcada
        public static string InsertConsultation(DateTime date, TimeSpan timeOfConsultation, int idClient, int status)
        {
            string resp = "";

            // Cria uma conexão com o banco de dados e garante que ela será fechada e liberada corretamente após o uso.
            using (SqlConnection sqlCon = new SqlConnection(Connection.Cn))
            {
                try
                {
                    // Abrindo conexão
                    sqlCon.Open();

                    // Cria um comando SQL que vai chamar uma stored procedure
                    using (SqlCommand sqlCmd = new SqlCommand("sp_insert_consultation", sqlCon))
                    {
                        // chamando um procedimento armazenado no banco de dados.
                        sqlCmd.CommandType = CommandType.StoredProcedure;

                        // Parâmetro sql para a data da consulta
                        sqlCmd.Parameters.Add(CreateSqlParameter(date, "@consultationDate"));

                        // Parâmetro sql para a hora da consulta
                        sqlCmd.Parameters.Add(CreateSqlParameter(timeOfConsultation, "@timeOfConsultation"));

                        // Parâmetro sql para o id do cliente que vai se consultar
                        sqlCmd.Parameters.Add(CreateSqlParameter(idClient, "@idClient"));

                        // Parâmetro sql para o status da consulta
                        sqlCmd.Parameters.Add(CreateSqlParameter(status, "@status"));

                        // Executa o comando e captura o código de retorno
                        int returnCode = Convert.ToInt32(sqlCmd.ExecuteScalar());
                        if (returnCode == 0)
                            resp = "Registro inserido com sucesso.";
                        else
                            resp = $"Erro ao inserir registro. Código: {returnCode}";
                    }
                }
                catch (Exception ex)
                {
                    resp = $"Erro: {ex.Message}";
                    Debug.WriteLine("Exception: " + ex.Message);
                }
            }

            return resp;
        }

        // método que vai editar os dados da consulta
        public static string EditConsultation(int idConsultation, DateTime date, TimeSpan timeOfConsultation, int idClient, int status)
        {
            string resp = "";

            // Cria uma conexão com o banco de dados e garante que ela será fechada e liberada corretamente após o uso.
            using (SqlConnection sqlCon = new SqlConnection(Connection.Cn))
            {
                try
                {
                    // Abrindo conexão
                    sqlCon.Open();

                    // Cria um comando SQL que vai chamar uma stored procedure
                    using (SqlCommand sqlCmd = new SqlCommand("sp_edit_consultation", sqlCon))
                    {
                        // chamando um procedimento armazenado no banco de dados.
                        sqlCmd.CommandType = CommandType.StoredProcedure;

                        // Parâmetro sql para o id da consulta
                        sqlCmd.Parameters.Add(CreateSqlParameter(idConsultation, "@idConsultation"));

                        // Parâmetro sql para a data da consulta
                        sqlCmd.Parameters.Add(CreateSqlParameter(date, "@consultationDate"));

                        // Parâmetro sql para a hora da consulta
                        sqlCmd.Parameters.Add(CreateSqlParameter(timeOfConsultation, "@timeOfConsultation"));

                        // Parâmetro sql para o id do cliente que vai se consultar
                        sqlCmd.Parameters.Add(CreateSqlParameter(idClient, "@idClient"));

                        // Parâmetro sql para o status da consulta
                        sqlCmd.Parameters.Add(CreateSqlParameter(status, "@status"));

                        // Executa o comando e captura o código de retorno
                        int returnCode = Convert.ToInt32(sqlCmd.ExecuteScalar());
                        if (returnCode == 0)
                            resp = "Registro editado com sucesso.";
                        else
                            resp = $"Erro ao editar registro. Código: {returnCode}";
                    }
                }
                catch (Exception ex)
                {
                    resp = $"Erro: {ex.Message}";
                    Debug.WriteLine("Exception: " + ex.Message);
                }
            }

            return resp;
        }

        // método que vai editar o status da consulta
        public static string EditConsultationStatus(int idConsultation, int status)
        {
            string resp = "";

            // Cria uma conexão com o banco de dados e garante que ela será fechada e liberada corretamente após o uso.
            using (SqlConnection sqlCon = new SqlConnection(Connection.Cn))
            {
                try
                {
                    // Abrindo conexão
                    sqlCon.Open();

                    // Cria um comando SQL que vai chamar uma stored procedure
                    using (SqlCommand sqlCmd = new SqlCommand("sp_edit_consultation_status", sqlCon))
                    {
                        // chamando um procedimento armazenado no banco de dados.
                        sqlCmd.CommandType = CommandType.StoredProcedure;

                        // Parâmetro sql para o id da consulta
                        sqlCmd.Parameters.Add(CreateSqlParameter(idConsultation, "@idConsultation"));

                        // Parâmetro sql para o status da consulta
                        sqlCmd.Parameters.Add(CreateSqlParameter(status, "@status"));

                        // Executa o comando e captura o código de retorno
                        int returnCode = Convert.ToInt32(sqlCmd.ExecuteScalar());
                        if (returnCode == 0)
                            resp = "Registro editado com sucesso.";
                        else
                            resp = $"Erro ao editar registro. Código: {returnCode}";
                    }
                }
                catch (Exception ex)
                {
                    resp = $"Erro: {ex.Message}";
                    Debug.WriteLine("Exception: " + ex.Message);
                }
            }

            return resp;
        }

        // método que vai deletar uma consulta
        public static string DeleteConsultation(int idConsultation)
        {
            string resp = "";

            // Cria uma conexão com o banco de dados e garante que ela será fechada e liberada corretamente após o uso.
            using (SqlConnection sqlCon = new SqlConnection(Connection.Cn))
            {
                try
                {
                    // Abrindo conexão
                    sqlCon.Open();

                    // Cria um comando SQL que vai chamar uma stored procedure
                    using (SqlCommand sqlCmd = new SqlCommand("sp_delete_consultation", sqlCon))
                    {
                        // chamando um procedimento armazenado no banco de dados.
                        sqlCmd.CommandType = CommandType.StoredProcedure;

                        // Parâmetro sql para o id do banco de dados
                        sqlCmd.Parameters.Add(CreateSqlParameter(idConsultation, "@idConsultation"));

                        // Executa o comando e captura o código de retorno
                        int returnCode = Convert.ToInt32(sqlCmd.ExecuteScalar());
                        if (returnCode == 0)
                            resp = "Registro deletado com sucesso.";
                        else
                            resp = $"Erro ao deletar registro. Código: {returnCode}";
                    }
                }
                catch (Exception ex)
                {
                    resp = $"Erro: {ex.Message}";
                    Debug.WriteLine("Exception: " + ex.Message);
                }
            }

            return resp;
        }

        //------------------------------------- configurações -------------------------------------

        // método que vai ler as configurações no banco de dados
        public static Settings GetSettings()
        {
            Settings settings;

            using (SqlConnection sqlCon = new SqlConnection(Connection.Cn))
            {
                try
                {
                    sqlCon.Open();

                    // Cria um comando SQL que vai chamar uma stored procedure e adiconona os parametres 
                    SqlCommand sqlCmd = FillSqlCommandOutPut(sqlCon);

                    // chamando um procedimento armazenado no banco de dados.
                    sqlCmd.CommandType = CommandType.StoredProcedure;

                    // executar a procedure
                    sqlCmd.ExecuteNonQuery();

                    // capturar o retorno
                    settings = CaptureOutPuts(sqlCmd);

                    // garantir que o recurso seja liberado
                    sqlCmd?.Dispose();
                }
                catch (Exception ex)
                {
                    Debug.WriteLine("Exception: " + ex);

                    settings = null;
                }
            }
            return settings;
        }

        // método que vai colocar os sqlParameters dentro do SqlCommand
        private static SqlCommand FillSqlCommandOutPut(SqlConnection sqlCon)
        {
            SqlCommand sqlCmd = new SqlCommand("sp_read_configurations", sqlCon);

            // Parâmetro output para trabalho as segudas
            sqlCmd.Parameters.Add(CreateSqlParameter("@workOnMondays", SqlDbType.Bit));

            // Parâmetro output para trabalho as terças
            sqlCmd.Parameters.Add(CreateSqlParameter("@workOnTuesdays", SqlDbType.Bit));

            // Parâmetro output para trabalho as quartas
            sqlCmd.Parameters.Add(CreateSqlParameter("@workOnWednesdays", SqlDbType.Bit));

            // Parâmetro output para trabalho as quitas
            sqlCmd.Parameters.Add(CreateSqlParameter("@workOnThursdays", SqlDbType.Bit));

            // Parâmetro output para trabalho as sextas
            sqlCmd.Parameters.Add(CreateSqlParameter("@workOnFridays", SqlDbType.Bit));

            // Parâmetro output para trabalho as sabados
            sqlCmd.Parameters.Add(CreateSqlParameter("@workOnSaturdays", SqlDbType.Bit));

            // Parâmetro output para trabalho as sabados
            sqlCmd.Parameters.Add(CreateSqlParameter("@workOnSundays", SqlDbType.Bit));

            // Parâmetro output para o inicio do horario de trabalho as segundas
            sqlCmd.Parameters.Add(CreateSqlParameter("@startOfWorkOnMondays", SqlDbType.Time));

            // Parâmetro output para o final do horario de trabalho as segundas
            sqlCmd.Parameters.Add(CreateSqlParameter("@endOfWorkOnMondays", SqlDbType.Time));

            // Parâmetro output para o inicio do horario de trabalho as terças
            sqlCmd.Parameters.Add(CreateSqlParameter("@startOfWorkOnTuesdays", SqlDbType.Time));

            // Parâmetro output para o final do horario de trabalho as terças
            sqlCmd.Parameters.Add(CreateSqlParameter("@endOfWorkOnTuesdays", SqlDbType.Time));

            // Parâmetro output para o inicio do horario de trabalho as quartas
            sqlCmd.Parameters.Add(CreateSqlParameter("@startOfWorkOnWednesdays", SqlDbType.Time));

            // Parâmetro output para o final do horario de trabalho as quartas
            sqlCmd.Parameters.Add(CreateSqlParameter("@endOfWorkOnWednesdays", SqlDbType.Time));

            // Parâmetro output para o inicio do horario de trabalho as quintas
            sqlCmd.Parameters.Add(CreateSqlParameter("@startOfWorkOnThursdays", SqlDbType.Time));

            // Parâmetro output para o final do horario de trabalho as quintas
            sqlCmd.Parameters.Add(CreateSqlParameter("@endOfWorkOnThursdays", SqlDbType.Time));

            // Parâmetro output para o inicio do horario de trabalho as sextas
            sqlCmd.Parameters.Add(CreateSqlParameter("@startOfWorkOnFridays", SqlDbType.Time));

            // Parâmetro output para o final do horario de trabalho as sextas
            sqlCmd.Parameters.Add(CreateSqlParameter("@endOfWorkOnFridays", SqlDbType.Time));

            // Parâmetro output para o inicio do horario de trabalho aos sabados
            sqlCmd.Parameters.Add(CreateSqlParameter("@startOfWorkOnSaturdays", SqlDbType.Time));

            // Parâmetro output para o final do horario de trabalho aos sabados
            sqlCmd.Parameters.Add(CreateSqlParameter("@endOfWorkOnSaturdays", SqlDbType.Time));

            // Parâmetro output para o inicio do horario de trabalho aos domingos
            sqlCmd.Parameters.Add(CreateSqlParameter("@startOfWorkOnSundays", SqlDbType.Time));

            // Parâmetro output para o final do horario de trabalho aos domingos
            sqlCmd.Parameters.Add(CreateSqlParameter("@endOfWorkOnSundays", SqlDbType.Time));

            // Parâmetro output para o inicio do horario de almoço as segundas
            sqlCmd.Parameters.Add(CreateSqlParameter("@startOfBreakOnMondays", SqlDbType.Time));

            // Parâmetro output para o final do horario de almoço as segundas
            sqlCmd.Parameters.Add(CreateSqlParameter("@endOfBreakOnMondays", SqlDbType.Time));

            // Parâmetro output para o inicio do horario de almoço as terças
            sqlCmd.Parameters.Add(CreateSqlParameter("@startOfBreakOnTuesdays", SqlDbType.Time));

            // Parâmetro output para o final do horario de almoço as terças
            sqlCmd.Parameters.Add(CreateSqlParameter("@endOfBreakOnTuesdays", SqlDbType.Time));

            // Parâmetro output para o inicio do horario de almoço as quartas
            sqlCmd.Parameters.Add(CreateSqlParameter("@startOfBreakOnWednesdays", SqlDbType.Time));

            // Parâmetro output para o final do horario de almoço as quartas
            sqlCmd.Parameters.Add(CreateSqlParameter("@endOfBreakOnWednesdays", SqlDbType.Time));

            // Parâmetro output para o inicio do horario de almoço as quintas
            sqlCmd.Parameters.Add(CreateSqlParameter("@startOfBreakOnThursdays", SqlDbType.Time));

            // Parâmetro output para o final do horario de almoço as quintas
            sqlCmd.Parameters.Add(CreateSqlParameter("@endOfBreakOnThursdays", SqlDbType.Time));

            // Parâmetro output para o inicio do horario de almoço as sextas
            sqlCmd.Parameters.Add(CreateSqlParameter("@startOfBreakOnFridays", SqlDbType.Time));

            // Parâmetro output para o final do horario de almoço as sextas
            sqlCmd.Parameters.Add(CreateSqlParameter("@endOfBreakOnFridays", SqlDbType.Time));

            // Parâmetro output para o inicio do horario de almoço aos sabados
            sqlCmd.Parameters.Add(CreateSqlParameter("@startOfBreakOnSaturdays", SqlDbType.Time));

            // Parâmetro output para o final do horario de almoço aos sabados
            sqlCmd.Parameters.Add(CreateSqlParameter("@endOfBreakOnSaturdays", SqlDbType.Time));

            // Parâmetro output para o inicio do horario de almoço aos domingos
            sqlCmd.Parameters.Add(CreateSqlParameter("@startOfBreakOnSundays", SqlDbType.Time));

            // Parâmetro output para o final do horario de almoço aos domingos
            sqlCmd.Parameters.Add(CreateSqlParameter("@endOfBreakOnSundays", SqlDbType.Time));

            // Parâmetro output para o tempo médio das consultas
            sqlCmd.Parameters.Add(CreateSqlParameter("@standardConsultationTime", SqlDbType.Int));

            return sqlCmd;
        }

        // método que vai capturar os resultados
        private static Settings CaptureOutPuts(SqlCommand sqlCmd)
        {
            Settings settings = new Settings();

            // recuperando se trabalha as segundas
            settings.workOnMondays = Convert.ToBoolean(sqlCmd.Parameters["@workOnMondays"].Value);

            // recuperando se trabalha as terças
            settings.workOnTuesdays = Convert.ToBoolean(sqlCmd.Parameters["@workOnTuesdays"].Value);

            // recuperando se trabalha as quartas
            settings.workOnWednesdays = Convert.ToBoolean(sqlCmd.Parameters["@workOnWednesdays"].Value);

            // recuperando se trabalha as quintas
            settings.workOnThursdays = Convert.ToBoolean(sqlCmd.Parameters["@workOnThursdays"].Value);

            // recuperando se trabalha as sextas
            settings.workOnFridays = Convert.ToBoolean(sqlCmd.Parameters["@workOnFridays"].Value);

            // recuperando se trabalha aos sabados
            settings.workOnSaturdays = Convert.ToBoolean(sqlCmd.Parameters["@workOnSaturdays"].Value);

            // recuperando se trabalha aos domingos
            settings.workOnSundays = Convert.ToBoolean(sqlCmd.Parameters["@workOnSundays"].Value);

            // tentando recuperar os horarios do inicio do trabalho as segundas ---
            if (TimeSpan.TryParse(
                sqlCmd.Parameters["@startOfWorkOnMondays"].Value.ToString(),
                out TimeSpan startOfWorkOnMondays))
                settings.startOfWorkOnMondays = startOfWorkOnMondays;

            // tentando recuperar os horarios do final do trabalho as segundas
            if (TimeSpan.TryParse(
                sqlCmd.Parameters["@endOfWorkOnMondays"].Value.ToString(),
                out TimeSpan endOfWorkOnMondays))
                settings.endOfWorkOnMondays = endOfWorkOnMondays;

            // tentando recuperar os horarios do inicio do trabalho as terças ---
            if (TimeSpan.TryParse(
                sqlCmd.Parameters["@startOfWorkOnTuesdays"].Value.ToString(),
                out TimeSpan startOfWorkOnTuesdays))
                settings.startOfWorkOnTuesdays = startOfWorkOnTuesdays;

            // tentando recuperar os horarios do final do trabalho as terças
            if (TimeSpan.TryParse(
                sqlCmd.Parameters["@endOfWorkOnTuesdays"].Value.ToString(),
                out TimeSpan endOfWorkOnTuesdays))
                settings.endOfWorkOnTuesdays = endOfWorkOnTuesdays;

            // tentando recuperar os horarios do inicio do trabalho as quartas ---
            if (TimeSpan.TryParse(
                sqlCmd.Parameters["@startOfWorkOnWednesdays"].Value.ToString(),
                out TimeSpan startOfWorkOnWednesdays))
                settings.startOfWorkOnWednesdays = startOfWorkOnWednesdays;

            // tentando recuperar os horarios do final do trabalho as quartas
            if (TimeSpan.TryParse(
                sqlCmd.Parameters["@endOfWorkOnWednesdays"].Value.ToString(),
                out TimeSpan endOfWorkOnWednesdays))
                settings.endOfWorkOnWednesdays = endOfWorkOnWednesdays;

            // tentando recuperar os horarios do inicio do trabalho as quintas ---
            if (TimeSpan.TryParse(
                sqlCmd.Parameters["@startOfWorkOnThursdays"].Value.ToString(),
                out TimeSpan startOfWorkOnThursdays))
                settings.startOfWorkOnThursdays = startOfWorkOnThursdays;

            // tentando recuperar os horarios do final do trabalho as quintas
            if (TimeSpan.TryParse(
                sqlCmd.Parameters["@endOfWorkOnThursdays"].Value.ToString(),
                out TimeSpan endOfWorkOnThursdays))
                settings.endOfWorkOnThursdays = endOfWorkOnThursdays;

            // tentando recuperar os horarios do inicio do trabalho as sextas ---
            if (TimeSpan.TryParse(
                sqlCmd.Parameters["@startOfWorkOnFridays"].Value.ToString(),
                out TimeSpan startOfWorkOnFridays))
                settings.startOfWorkOnFridays = startOfWorkOnFridays;

            // tentando recuperar os horarios do final do trabalho as sextas
            if (TimeSpan.TryParse(
                sqlCmd.Parameters["@endOfWorkOnFridays"].Value.ToString(),
                out TimeSpan endOfWorkOnFridays))
                settings.endOfWorkOnFridays = endOfWorkOnFridays;

            // tentando recuperar os horarios do inicio do trabalho aos sabados ---
            if (TimeSpan.TryParse(
                sqlCmd.Parameters["@startOfWorkOnSaturdays"].Value.ToString(),
                out TimeSpan startOfWorkOnSaturdays))
                settings.startOfWorkOnSaturdays = startOfWorkOnSaturdays;

            // tentando recuperar os horarios do final do trabalho aos sabados
            if (TimeSpan.TryParse(
                sqlCmd.Parameters["@endOfWorkOnSaturdays"].Value.ToString(),
                out TimeSpan endOfWorkOnSaturdays))
                settings.endOfWorkOnSaturdays = endOfWorkOnSaturdays;

            // tentando recuperar os horarios do inicio do trabalho aos domingos ---
            if (TimeSpan.TryParse(
                sqlCmd.Parameters["@startOfWorkOnSundays"].Value.ToString(),
                out TimeSpan startOfWorkOnSundays))
                settings.startOfWorkOnSundays = startOfWorkOnSundays;

            // tentando recuperar os horarios do final do trabalho aos domingos
            if (TimeSpan.TryParse(
                sqlCmd.Parameters["@endOfWorkOnSundays"].Value.ToString(),
                out TimeSpan endOfWorkOnSundays))
                settings.endOfWorkOnSundays = endOfWorkOnSundays;

            // tentando recuperar os horarios do inicio do almoço as segundas ---
            if (TimeSpan.TryParse(
                sqlCmd.Parameters["@startOfBreakOnMondays"].Value.ToString(),
                out TimeSpan startOfBreakOnMondays))
                settings.startOfBreakOnMondays = startOfBreakOnMondays;

            // tentando recuperar os horarios do final do almoço as segundas
            if (TimeSpan.TryParse(
                sqlCmd.Parameters["@endOfBreakOnMondays"].Value.ToString(),
                out TimeSpan endOfBreakOnMondays))
                settings.endOfBreakOnMondays = endOfBreakOnMondays;

            // tentando recuperar os horarios do inicio do almoço as terças ---
            if (TimeSpan.TryParse(
                sqlCmd.Parameters["@startOfBreakOnTuesdays"].Value.ToString(),
                out TimeSpan startOfBreakOnTuesdays))
                settings.startOfBreakOnTuesdays = startOfBreakOnTuesdays;

            // tentando recuperar os horarios do final do almoço as terças
            if (TimeSpan.TryParse(
                sqlCmd.Parameters["@endOfBreakOnTuesdays"].Value.ToString(),
                out TimeSpan endOfBreakOnTuesdays))
                settings.endOfBreakOnTuesdays = endOfBreakOnTuesdays;

            // tentando recuperar os horarios do inicio do almoço as quartas ---
            if (TimeSpan.TryParse(
                sqlCmd.Parameters["@startOfBreakOnWednesdays"].Value.ToString(),
                out TimeSpan startOfBreakOnWednesdays))
                settings.startOfBreakOnWednesdays = startOfBreakOnWednesdays;

            // tentando recuperar os horarios do final do almoço as quartas
            if (TimeSpan.TryParse(
                sqlCmd.Parameters["@endOfBreakOnWednesdays"].Value.ToString(),
                out TimeSpan endOfBreakOnWednesdays))
                settings.endOfBreakOnWednesdays = endOfBreakOnWednesdays;

            // tentando recuperar os horarios do inicio do almoço as quintas ---
            if (TimeSpan.TryParse(
                sqlCmd.Parameters["@startOfBreakOnThursdays"].Value.ToString(),
                out TimeSpan startOfBreakOnThursdays))
                settings.startOfBreakOnThursdays = startOfBreakOnThursdays;

            // tentando recuperar os horarios do final do almoço as quintas
            if (TimeSpan.TryParse(
                sqlCmd.Parameters["@endOfBreakOnThursdays"].Value.ToString(),
                out TimeSpan endOfBreakOnThursdays))
                settings.endOfBreakOnThursdays = endOfBreakOnThursdays;

            // tentando recuperar os horarios do inicio do almoço as sextas ---
            if (TimeSpan.TryParse(
                sqlCmd.Parameters["@startOfBreakOnFridays"].Value.ToString(),
                out TimeSpan startOfBreakOnFridays))
                settings.startOfBreakOnFridays = startOfBreakOnFridays;

            // tentando recuperar os horarios do final do almoço as sextas
            if (TimeSpan.TryParse(
                sqlCmd.Parameters["@endOfBreakOnFridays"].Value.ToString(),
                out TimeSpan endOfBreakOnFridays))
                settings.endOfBreakOnFridays = endOfBreakOnFridays;

            // tentando recuperar os horarios do inicio do almoço aos sabados ---
            if (TimeSpan.TryParse(
                sqlCmd.Parameters["@startOfBreakOnSaturdays"].Value.ToString(),
                out TimeSpan startOfBreakOnSaturdays))
                settings.startOfBreakOnSaturdays = startOfBreakOnSaturdays;

            // tentando recuperar os horarios do final do almoço aos sabados
            if (TimeSpan.TryParse(
                sqlCmd.Parameters["@endOfBreakOnSaturdays"].Value.ToString(),
                out TimeSpan endOfBreakOnSaturdays))
                settings.endOfBreakOnSaturdays = endOfBreakOnSaturdays;

            // tentando recuperar os horarios do inicio do almoço aos domingos ---
            if (TimeSpan.TryParse(
                sqlCmd.Parameters["@startOfBreakOnSundays"].Value.ToString(),
                out TimeSpan startOfBreakOnSundays))
                settings.startOfBreakOnSundays = startOfBreakOnSundays;

            // tentando recuperar os horarios do final do almoço aos domingos
            if (TimeSpan.TryParse(
                sqlCmd.Parameters["@endOfBreakOnSundays"].Value.ToString(),
                out TimeSpan endOfBreakOnSundays))
                settings.endOfBreakOnSundays = endOfBreakOnSundays;

            settings.standardConsultationTime = Convert.ToInt32(sqlCmd.Parameters["@standardConsultationTime"].Value);

            return settings;
        }

        // método enviar as configurações para o banco de dados
        public static string InsertSettings(Settings settings)
        {
            string resp = "";

            using (SqlConnection sqlCon = new SqlConnection(Connection.Cn))
            {
                try
                {
                    sqlCon.Open();

                    using (SqlCommand sqlCmd = new SqlCommand("sp_verify_configurations", sqlCon))
                    {
                        sqlCmd.CommandType = CommandType.StoredProcedure;

                        // parametro output para verificar se tem dado no banco de dados
                        //SqlParameter sqlPar = CreateSqlParameter("@returnBit", SqlDbType.Bit);
                        sqlCmd.Parameters.Add(CreateSqlParameter("@returnBit", SqlDbType.Bit));

                        // Executa o comando
                        sqlCmd.ExecuteNonQuery();

                        // Captura o resultado
                        //bool result = Convert.ToBoolean(sqlPar.Value);
                        bool result = Convert.ToBoolean(sqlCmd.Parameters["@returnBit"].Value);

                        //se já tiver algo no banco de dados
                        if (result)
                            resp = EditConfigurations(sqlCon, settings);

                        //se não cria um novo registro
                        else
                            resp = CreateConfigurations(sqlCon, settings);
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine("Exception: " + ex);
                }
            }

            return resp;
        }

        // método que vai ser chamado se não houverem configurações no banco
        private static string CreateConfigurations(SqlConnection sqlCon, Settings settings)
        {
            string resp = "";

            try
            {
                // Cria um comando SQL que vai chamar uma stored procedure
                SqlCommand sqlCmd = FillSqlCommand("sp_insert_settings", sqlCon, settings);

                // Executa o comando e captura o código de retorno
                int returnCode = Convert.ToInt32(sqlCmd.ExecuteScalar());
                if (returnCode == 0)
                    resp = "Registro inserido com sucesso.";
                else
                    resp = $"Erro ao inserido registro. Código: {returnCode}";

                // garantir que o recurso seja liberado
                sqlCmd?.Dispose();
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Exception: " + ex);
            }

            return resp;
        }

        // método que vai ser chamado se houverem configurações no banco
        private static string EditConfigurations(SqlConnection sqlCon, Settings settings)
        {
            string resp = "";

            try
            {
                // Cria um comando SQL que vai chamar uma stored procedure
                SqlCommand sqlCmd = FillSqlCommand("sp_edit_all_settings", sqlCon, settings);

                // chamando um procedimento armazenado no banco de dados.
                sqlCmd.CommandType = CommandType.StoredProcedure;

                // Executa o comando e captura o código de retorno
                int returnCode = Convert.ToInt32(sqlCmd.ExecuteScalar());
                if (returnCode == 0)
                    resp = "Registro inserido com sucesso.";
                else
                    resp = $"Erro ao inserido registro. Código: {returnCode}";

                // garantir que o recurso seja liberado
                sqlCmd?.Dispose();
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Exception: " + ex);
            }

            return resp;
        }

        // método que vai colocar os sqlParameters dentro do SqlCommand
        private static SqlCommand FillSqlCommand(string procedure, SqlConnection sqlCon, Settings settings)
        {
            SqlCommand sqlCmd = new SqlCommand(procedure, sqlCon);

            // Parâmetro sql para trabalho as segudas
            sqlCmd.Parameters.Add(CreateSqlParameter(settings.workOnMondays, "@workOnMondays"));

            // Parâmetro sql para trabalho as terças
            sqlCmd.Parameters.Add(CreateSqlParameter(settings.workOnTuesdays, "@workOnTuesdays"));

            // Parâmetro sql para trabalho as quartas
            sqlCmd.Parameters.Add(CreateSqlParameter(settings.workOnWednesdays, "@workOnWednesdays"));

            // Parâmetro sql para trabalho as quintas
            sqlCmd.Parameters.Add(CreateSqlParameter(settings.workOnThursdays, "@workOnThursdays"));

            // Parâmetro sql para trabalho as sextas
            sqlCmd.Parameters.Add(CreateSqlParameter(settings.workOnFridays, "@workOnFridays"));

            // Parâmetro sql para trabalho as sabados
            sqlCmd.Parameters.Add(CreateSqlParameter(settings.workOnSaturdays, "@workOnSaturdays"));

            // Parâmetro sql para trabalho as domingos
            sqlCmd.Parameters.Add(CreateSqlParameter(settings.workOnSundays, "@workOnSundays"));

            // Parâmetro sql para o inicio do horario de trabalho as segundas
            sqlCmd.Parameters.Add(CreateSqlParameter(settings.startOfWorkOnMondays, "@startOfWorkOnMondays"));

            // Parâmetro sql para o final do horario de trabalho as segundas
            sqlCmd.Parameters.Add(CreateSqlParameter(settings.endOfWorkOnMondays, "@endOfWorkOnMondays"));

            // Parâmetro sql para o inicio do horario de trabalho as terças
            sqlCmd.Parameters.Add(CreateSqlParameter(settings.startOfWorkOnTuesdays, "@startOfWorkOnTuesdays"));

            // Parâmetro sql para o final do horario de trabalho as terças
            sqlCmd.Parameters.Add(CreateSqlParameter(settings.endOfWorkOnTuesdays, "@endOfWorkOnTuesdays"));

            // Parâmetro sql para o inicio do horario de trabalho as quartas
            sqlCmd.Parameters.Add(CreateSqlParameter(settings.startOfWorkOnWednesdays, "@startOfWorkOnWednesdays"));

            // Parâmetro sql para o final do horario de trabalho as quartas
            sqlCmd.Parameters.Add(CreateSqlParameter(settings.endOfWorkOnWednesdays, "@endOfWorkOnWednesdays"));

            // Parâmetro sql para o inicio do horario de trabalho as quintas
            sqlCmd.Parameters.Add(CreateSqlParameter(settings.startOfWorkOnThursdays, "@startOfWorkOnThursdays"));

            // Parâmetro sql para o final do horario de trabalho as quintas
            sqlCmd.Parameters.Add(CreateSqlParameter(settings.endOfWorkOnThursdays, "@endOfWorkOnThursdays"));

            // Parâmetro sql para o inicio do horario de trabalho as sextas
            sqlCmd.Parameters.Add(CreateSqlParameter(settings.startOfWorkOnFridays, "@startOfWorkOnFridays"));

            // Parâmetro sql para o final do horario de trabalho as sextas
            sqlCmd.Parameters.Add(CreateSqlParameter(settings.endOfWorkOnFridays, "@endOfWorkOnFridays"));

            // Parâmetro sql para o inicio do horario de trabalho aos sabados
            sqlCmd.Parameters.Add(CreateSqlParameter(settings.startOfWorkOnSaturdays, "@startOfWorkOnSaturdays"));

            // Parâmetro sql para o final do horario de trabalho aos sabados
            sqlCmd.Parameters.Add(CreateSqlParameter(settings.endOfWorkOnSaturdays, "@endOfWorkOnSaturdays"));

            // Parâmetro sql para o inicio do horario de trabalho aos domingos
            sqlCmd.Parameters.Add(CreateSqlParameter(settings.startOfWorkOnSundays, "@startOfWorkOnSundays"));

            // Parâmetro sql para o final do horario de trabalho aos domingos
            sqlCmd.Parameters.Add(CreateSqlParameter(settings.endOfWorkOnSundays, "@endOfWorkOnSundays"));

            // Parâmetro sql para o inicio do horario de almoço as segundas
            sqlCmd.Parameters.Add(CreateSqlParameter(settings.startOfBreakOnMondays, "@startOfBreakOnMondays"));

            // Parâmetro sql para o final do horario de almoço as segundas
            sqlCmd.Parameters.Add(CreateSqlParameter(settings.endOfBreakOnMondays, "@endOfBreakOnMondays"));

            // Parâmetro sql para o inicio do horario de almoço as terças
            sqlCmd.Parameters.Add(CreateSqlParameter(settings.startOfBreakOnTuesdays, "@startOfBreakOnTuesdays"));

            // Parâmetro sql para o final do horario de almoço as terças
            sqlCmd.Parameters.Add(CreateSqlParameter(settings.endOfBreakOnTuesdays, "@endOfBreakOnTuesdays"));

            // Parâmetro sql para o inicio do horario de almoço as quartas
            sqlCmd.Parameters.Add(CreateSqlParameter(settings.startOfBreakOnWednesdays, "@startOfBreakOnWednesdays"));

            // Parâmetro sql para o final do horario de almoço as quartas
            sqlCmd.Parameters.Add(CreateSqlParameter(settings.endOfBreakOnWednesdays, "@endOfBreakOnWednesdays"));

            // Parâmetro sql para o inicio do horario de almoço as quintas
            sqlCmd.Parameters.Add(CreateSqlParameter(settings.startOfBreakOnThursdays, "@startOfBreakOnThursdays"));

            // Parâmetro sql para o final do horario de almoço as quintas
            sqlCmd.Parameters.Add(CreateSqlParameter(settings.endOfBreakOnThursdays, "@endOfBreakOnThursdays"));

            // Parâmetro sql para o inicio do horario de almoço as sextas
            sqlCmd.Parameters.Add(CreateSqlParameter(settings.startOfBreakOnFridays, "@startOfBreakOnFridays"));

            // Parâmetro sql para o final do horario de almoço as sextas
            sqlCmd.Parameters.Add(CreateSqlParameter(settings.endOfBreakOnFridays, "@endOfBreakOnFridays"));

            // Parâmetro sql para o inicio do horario de almoço aos sabados
            sqlCmd.Parameters.Add(CreateSqlParameter(settings.startOfBreakOnSaturdays, "@startOfBreakOnSaturdays"));

            // Parâmetro sql para o final do horario de almoço aos sabados
            sqlCmd.Parameters.Add(CreateSqlParameter(settings.endOfBreakOnSaturdays, "@endOfBreakOnSaturdays"));

            // Parâmetro sql para o inicio do horario de almoço aos domingos
            sqlCmd.Parameters.Add(CreateSqlParameter(settings.startOfBreakOnSundays, "@startOfBreakOnSundays"));

            // Parâmetro sql para o final do horario de almoço aos domingos
            sqlCmd.Parameters.Add(CreateSqlParameter(settings.endOfBreakOnSundays, "@endOfBreakOnSundays"));

            // Parâmetro sql para o tempo médio das consultas
            sqlCmd.Parameters.Add(CreateSqlParameter(settings.standardConsultationTime, "@standardConsultationTime"));

            return sqlCmd;
        }

        //------------------------------------- SqlParameter -------------------------------------

        // sobrecarga para criar um parametro do tipo int não output
        private static SqlParameter CreateSqlParameter(int value, string varName)
        {
            //Debug.WriteLine($"value: {value}, varname: {varName}");
            SqlParameter parameter = new SqlParameter
            {
                ParameterName = varName,
                SqlDbType = SqlDbType.Int,
                Value = value
            };
            return parameter;
        }

        // sobrecarga para criar um paramentro do tipo string não output
        private static SqlParameter CreateSqlParameter(string value, string varName, int size)
        {
            //Debug.WriteLine($"value: {value}, varname: {varName}, size: {size}");
            SqlParameter parameter = new SqlParameter
            {
                ParameterName = varName,
                SqlDbType = SqlDbType.VarChar,
                Size = size,
                Value = value
            };
            return parameter;
        }

        // sobrecarca para criar um paramentro do tipo Date não output
        private static SqlParameter CreateSqlParameter(DateTime value, string varName)
        {
            SqlParameter parameter = new SqlParameter
            {
                ParameterName = varName,
                SqlDbType = SqlDbType.Date,
                Value = value
            };
            return parameter;
        }

        // sobrecarca para criar um paramentro do tipo Time não output
        private static SqlParameter CreateSqlParameter(TimeSpan value, string varName)
        {
            SqlParameter parameter = new SqlParameter
            {
                ParameterName = varName,
                SqlDbType = SqlDbType.Time,
                Value = value
            };
            return parameter;
        }

        // sobrecarca para criar um paramentro do tipo Time? não output
        private static SqlParameter CreateSqlParameter(TimeSpan? value, string varName)
        {
            SqlParameter parameter = new SqlParameter
            {
                ParameterName = varName,
                SqlDbType = SqlDbType.Time,
                Value = value.HasValue ? (object)value.Value : DBNull.Value
            };
            return parameter;
        }

        // sobrecarga criar um parametro do tipo Bit não output
        private static SqlParameter CreateSqlParameter(bool value, string varName)
        {
            SqlParameter parameter = new SqlParameter
            {
                ParameterName = varName,
                SqlDbType = SqlDbType.Bit,
                Value = value
            };
            return parameter;
        }

        // sobrecarga para criar um paramentro ParameterDirection.Output
        private static SqlParameter CreateSqlParameter(string varName, SqlDbType type)
        {
            SqlParameter parameter = new SqlParameter
            {
                Direction = ParameterDirection.Output,
                SqlDbType = type,
                ParameterName = varName
            };
            return parameter;
        }
    
    }
}
