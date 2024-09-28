using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Diagnostics;
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

        // método que vai inserir um cliente no banco de dados
        public static string InsertClient(string name, string telephone, string street, string houseNumber, string neighborhood, string city, string complement, string idNumber, string cpf)
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

                        // Parâmetro sql para o nome da rua
                        sqlCmd.Parameters.Add(CreateSqlParameter(street, "@street", 50));

                        // Parâmetro sql para o número da casa
                        sqlCmd.Parameters.Add(CreateSqlParameter(houseNumber, "@houseNumber", 10));

                        // Parâmetro sql para o Bairro
                        sqlCmd.Parameters.Add(CreateSqlParameter(neighborhood, "@neighborhood", 50));

                        // Parâmetro sql para a cidade
                        sqlCmd.Parameters.Add(CreateSqlParameter(city, "@city", 50));

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
        public static string EditClient(int idClient, string telephone, string street, string houseNumber, string neighborhood, string city, string complement)
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

                        // Parâmetro sql para o nome da rua
                        sqlCmd.Parameters.Add(CreateSqlParameter(street, "@street", 50));

                        // Parâmetro sql para o número da casa
                        sqlCmd.Parameters.Add(CreateSqlParameter(houseNumber, "@houseNumber", 10));

                        // Parâmetro sql para o Bairro
                        sqlCmd.Parameters.Add(CreateSqlParameter(neighborhood, "@neighborhood", 50));

                        // Parâmetro sql para a cidade
                        sqlCmd.Parameters.Add(CreateSqlParameter(city, "@city", 50));

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
        public static string EditClientAdm(int idClient, string name, string telephone, string street, string houseNumber, string neighborhood, string city, string complement, string idNumber, string cpf)
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

                        // Parâmetro sql para o nome da rua
                        sqlCmd.Parameters.Add(CreateSqlParameter(street, "@street", 50));

                        // Parâmetro sql para o número da casa
                        sqlCmd.Parameters.Add(CreateSqlParameter(houseNumber, "@houseNumber", 10));

                        // Parâmetro sql para o Bairro
                        sqlCmd.Parameters.Add(CreateSqlParameter(neighborhood, "@neighborhood", 50));

                        // Parâmetro sql para a cidade
                        sqlCmd.Parameters.Add(CreateSqlParameter(city, "@city", 50));

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

        // método que vai pegar 50 consultas do dia e exibir
        public static DataTable ShowConsultations(DateTime date)
        {
            // Objeto do tipo DataTable
            DataTable dtResult = new DataTable("consultations");

            // lista para pegar os ids dos clientes
            //List<int> ids = new List<int>();
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

            //return dtResult;

            return EditConsultationsTable(dtResult, names);
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

        private static DataTable EditConsultationsTable(DataTable dtResult, List<string> names)
        {
            // Adicionando a nova coluna para o nome do paciente
            dtResult.Columns.Add("Nome", typeof(string));

            // Reorganizando as colunas para que "Nome" fique depois de "idConsultation"
            dtResult.Columns["Nome"].SetOrdinal(dtResult.Columns["idConsultation"].Ordinal + 1);

            int index = 0;

            //Adicionando os nomes dos pacientes
            foreach (DataRow row in dtResult.Rows)
            {
                row["Nome"] = names[index];

                index++;
            }

            return dtResult;
        }
    }
}
