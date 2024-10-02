using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Diagnostics;
using static System.Windows.Forms.AxHost;
using System.Runtime.ConstrainedExecution;
using System.Xml.Linq;

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
            using (SqlConnection SqlCon = new SqlConnection(Connection.Cn))
            {
                try
                {
                    // Abrindo a conexão ao banco de dados
                    SqlCon.Open();

                    // Comando SQL - que está no banco de dados
                    using (SqlCommand sqlCmd = new SqlCommand("sp_show_clients", SqlCon))
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
            using (SqlConnection SqlCon = new SqlConnection(Connection.Cn))
            {
                try
                {
                    // Abrindo a conexão ao banco de dados
                    SqlCon.Open();

                    // Configurando o comando SQL
                    using (SqlCommand sqlCmd = new SqlCommand("sp_search_clientName", SqlCon))
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
            using (SqlConnection SqlCon = new SqlConnection(Connection.Cn))
            {
                try
                {
                    // Abrindo a conexão ao banco de dados
                    SqlCon.Open();

                    // Configurando o comando SQL
                    using (SqlCommand sqlCmd = new SqlCommand("sp_search_clientCPF", SqlCon))
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
            using (SqlConnection SqlCon = new SqlConnection(Connection.Cn))
            {
                try
                {
                    // Abrindo a conexão ao banco de dados
                    SqlCon.Open();

                    // Configurando o comando SQL
                    using (SqlCommand sqlCmd = new SqlCommand("sp_search_client_name", SqlCon))
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
                catch(Exception ex)
                {
                    resp = $"Erro: {ex.Message}";
                    Debug.WriteLine("Exception: "+ex.Message);
                }
            }

            return resp;
        }

        //------------------------------------- consultas -------------------------------------

        // método que vai pegar as consultas da data no banco de dados
        public static DataTable ShowConsultationsByDate(DateTime date, string search)
        {
            // Objeto do tipo DataTable
            DataTable dtResult = new DataTable("consultations");

            // string para pegar os ids dos clientes
            string idList = "";

            // lista para guardar os nomes dos clientes
            List<string> names = new List<string>();

            // Objeto da conexão com o banco de dados
            using (SqlConnection SqlCon = new SqlConnection(Connection.Cn))
            {
                try
                {
                    // Abrindo a conexão ao banco de dados
                    SqlCon.Open();

                    // Comando SQL - que está no banco de dados
                    using (SqlCommand sqlCmd = new SqlCommand("sp_search_date", SqlCon))
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

                    //pegado as ids dos clientes
                    foreach (DataRow row in dtResult.Rows)
                    {
                        idList += row["idClient"] + ",";
                    }

                    // Pegando os nomes com as ids
                    using (SqlCommand sqlCmd = new SqlCommand("sp_search_clients_by_ids", SqlCon))
                    {
                        sqlCmd.CommandType = CommandType.StoredProcedure;

                        // Prepare a string com os IDs separados por vírgula
                        //string idList = string.Join(",", ids);
                        sqlCmd.Parameters.AddWithValue("@idList", idList);

                        // Recuperando os nomes e guardando em uma lista
                        using (SqlDataReader sqlDat = sqlCmd.ExecuteReader())
                        {
                            while (sqlDat.Read())
                            {
                                string name = sqlDat["name"].ToString();
                                names.Add(name);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    dtResult = null;
                    Debug.WriteLine("Exception: " + ex.Message);
                }
            }

            //chamando a gambiarra que vai adiconar uma coluna de nomes na tabela
            return EditConsultationsTable(dtResult, names, search);
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
                            resp = $"Erro ao editado registro. Código: {returnCode}";
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
                            resp = $"Erro ao editado registro. Código: {returnCode}";
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

        //------------------------------------- Ganbiarra -------------------------------------

        // Método que vai adiconar a coluna name e preencher ela com os nomes que estão na lista
        private static DataTable EditConsultationsTable(DataTable dtResult, List<string> names, string name)
        {
            // Adicionando a nova coluna para o nome do paciente
            dtResult.Columns.Add("Nome do paciente", typeof(string));

            // Reorganizando as colunas para que "Nome" fique depois de "idConsultation"
            dtResult.Columns["Nome do paciente"].SetOrdinal(dtResult.Columns["idConsultation"].Ordinal + 1);

            if(name == "")
            {
                int index = 0;

                //Adicionando os nomes dos pacientes
                foreach (DataRow row in dtResult.Rows)
                {
                    row["Nome do paciente"] = names[index];

                    index++;
                }
            }
            else
            {
                int index = 0;

                //Adicionando os nomes dos pacientes
                foreach (DataRow row in dtResult.Rows)
                {
                    if(names[index].StartsWith(name, StringComparison.OrdinalIgnoreCase) )
                        row["Nome do paciente"] = names[index];
                    
                    else
                        row.Delete();// marca para deletar

                    index++;
                }

                dtResult.AcceptChanges();// aqui deleta o que estava marcado para deletar
            }
            
            return dtResult;
        }
    }
}
