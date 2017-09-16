using AgendaADONET.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AgendaADONET
{
    public partial class frmAgenda : Form
    {
        public frmAgenda()
        {
            InitializeComponent();
        }
           private void Form1_Load(object sender, EventArgs e)
        {
            ContatoDAO contatoDAO = new ContatoDAO();
            DataTable dataTable = contatoDAO.GetContatos();
            dgvAgenda.DataSource = dataTable;
            dgvAgenda.Refresh();
        }
    }
}
