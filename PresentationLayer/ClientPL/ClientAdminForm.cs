using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entities;
using BusinessLogic;
using System.Data.SqlClient;

namespace PresentationLayer.ClientPL
{
    public partial class ClientAdminForm : Form
    {
        private ClientLogic clientLogic = new ClientLogic();
        private string _connectionString = @"Data Source=TOP-PC\SQLEXPRESS;Initial Catalog = RepairStation; Integrated Security = True";
        private string sql = "Select * from Client";
        private DataSet ds;
        private SqlDataAdapter adapter;
        private SqlCommandBuilder commandBuilder;
        public ClientAdminForm()
        {
            InitializeComponent();            
            ClientTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ClientTable.AllowUserToAddRows = false;
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                adapter = new SqlDataAdapter(sql, connection);

                ds = new DataSet();
                adapter.Fill(ds);
                ClientTable.DataSource = ds.Tables[0];                
            }
        }

        private void RemoveClient_Click(object sender, EventArgs e)
        {
            int id = (int)ClientTable.CurrentRow.Cells[0].Value;
            clientLogic.Remove(id);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            ClientTable.DataSource = clientLogic.GetAll();
        }

        private void AddClient_Click(object sender, EventArgs e)
        {
            AddClientForm f = new AddClientForm();
            f.Show();
        }

        private void ClientAdminForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            AdminForm f = new AdminForm();
            f.Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                adapter = new SqlDataAdapter(sql, connection);
                commandBuilder = new SqlCommandBuilder(adapter);
                adapter.InsertCommand = new SqlCommand("AddClient", connection);
                adapter.InsertCommand.CommandType = CommandType.StoredProcedure;
                adapter.InsertCommand.Parameters.Add(new SqlParameter("@Name", SqlDbType.NVarChar, 50, "Name"));
                adapter.InsertCommand.Parameters.Add(new SqlParameter("@SecondName", SqlDbType.NVarChar, 50, "SecondName"));
                adapter.InsertCommand.Parameters.Add(new SqlParameter("@PhoneNumber", SqlDbType.NVarChar, 50, "PhoneNumber"));
                adapter.InsertCommand.Parameters.Add(new SqlParameter("@Passport", SqlDbType.NVarChar, 50, "Passport"));
                adapter.InsertCommand.Parameters.Add(new SqlParameter("@Address", SqlDbType.NVarChar, 50, "Address"));               
                SqlParameter parameter = adapter.InsertCommand.Parameters.Add("@ID", SqlDbType.Int, 0, "ClientID");
                parameter.Direction = ParameterDirection.Output;

                adapter.Update(ds);
            }

        }
    }
}
