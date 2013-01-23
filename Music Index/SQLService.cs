using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;


namespace Music_Index
{
    public class SQLService
    {
        // gegevens vooraf declareren
        private string databaseString = @"Provider=Microsoft.SQLSERVER.CE.OLEDB.4.0;Data Source=|DataDirectory|\MusicIndexDataSet.sdf";
        private OleDbConnection connectie;
        private DataTable tabel;

        //Verbinding maken met de database, gebruikmakende van de OleDbConnectie en de databasestring
        public SQLService()
        {
            try
            {
                connectie = new OleDbConnection(databaseString);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        /// <summary>
        /// Het commando om een Insert query aan te maken
        /// </summary>
        /// <param name="commando">het INSERT commando</param>
        public void Insert(string commando)
        {
            try
            {
                // Definieer het command en de adapter
                OleDbCommand insertCommand = new OleDbCommand();
                OleDbDataAdapter adapter = new OleDbDataAdapter();

                // Open de connectie
                connectie.Open();

                // Zet het commando in de adapter
                insertCommand.Connection = connectie;
                insertCommand.CommandText = commando;
                adapter.InsertCommand = insertCommand;

                // Execute het commando
                adapter.InsertCommand.ExecuteNonQuery();
                MessageBox.Show("SQL DONE");
            }

            // Catch de exception indien deze ontstaat.
            catch (Exception obj)
            {
                MessageBox.Show(obj.Message);
            }
            //Uiteindelijk de SQL Connectie weer sluiten
            finally
            {
                connectie.Close();
            }

        }

        public void Update(string command)
        {
            try
            {
                OleDbCommand updateCommand = new OleDbCommand();
                OleDbDataAdapter adapter = new OleDbDataAdapter();
                connectie.Open();

                // put the command in the adapter
                updateCommand.Connection = connectie;
                updateCommand.CommandText = command;
                adapter.UpdateCommand = updateCommand;

                // do the update
                adapter.UpdateCommand.ExecuteNonQuery();
                connectie.Close();



            }
            catch (Exception obj )
            {
                MessageBox.Show(obj.Message);                
            }
            finally
            {
                connectie.Close();
            }

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="command"></param>
        public bool Bestaat(string command)
        {
          
                tabel = new DataTable();

                OleDbDataAdapter adapter = new OleDbDataAdapter(command, databaseString);
                tabel.Clear();
                int count = adapter.Fill(tabel);

                return count != 0;                        

        }

    }
}
