using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;



namespace testeserial
{
    public partial class Form1 : Form
    {
        string modo;
        string envio;
        string recebe ="";
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            cb_dts.Checked = false;
            serialPort1.DtrEnable = false;
            cb_rts.Checked = false;
            serialPort1.RtsEnable = false;
            bt_enviar.Enabled = false;
            lb_onoff.Enabled = false;
            lb_onoff.Text = "OFF";
            cb_wl.Checked = true;
            modo = "WriteLine";
            cb_au.Checked = true;
            cb_add.Checked = false;
            cb_dts.Checked = true;
            cb_rts.Checked = false;
            cb_ue.Checked = false;
            cv_ubt.Checked = true;
            
            string[] ports = SerialPort.GetPortNames();
            cb_com.Items.AddRange(ports);

        }
        private void bt_conectar_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.PortName = cb_com.Text;
                serialPort1.BaudRate = Convert.ToInt32(cb_baud.Text);
                serialPort1.DataBits = Convert.ToInt32(cb_bits.Text);
                serialPort1.StopBits = (StopBits)Enum.Parse(typeof(StopBits), cb_stop.Text);
                serialPort1.Parity = (Parity)Enum.Parse(typeof(Parity), cb_parity.Text);
                serialPort1.Open();
                progressBar1.Value = 100;
                lb_onoff.Enabled = true;
                lb_onoff.Text = "ON";
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message,"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void cb_com_SelectedIndexChanged(object sender, EventArgs e)
        {
            serialPort1.PortName = cb_com.Text;
        }       
        private void cb_parity_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void cb_stop_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void cb_bits_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void cb_baud_SelectedIndexChanged(object sender, EventArgs e)
        {

        }       
        private void bt_enviar_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                if (modo == "WriteLine")
                {
                    envio = tb_envia.Text;
                    serialPort1.WriteLine(envio);
                    tb_envia.Text = "";

                }
                else if (modo == "Write")
                {
                    envio = tb_envia.Text;
                    serialPort1.Write(envio);
                    tb_envia.Text = "";
                }

            }
        }
        private void bt_fechar_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
                Environment.Exit(0);
            }
            else
            {
                Environment.Exit(0);
            }
        }
        private void bt_desconectar_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
                progressBar1.Value = 0;
                lb_onoff.Enabled = false;
                lb_onoff.Text = "OFF";
            }
        }
        private void bt_clear_Click(object sender, EventArgs e)
        {
            if (tb_recebe.Text != "")
            {
                tb_recebe.Text = "";
               
            }
        }
        private void cv_ubt_CheckedChanged(object sender, EventArgs e)
        {
            if (cv_ubt.Checked)
            {
                bt_enviar.Enabled = true;
                cb_ue.Checked = false;
            }
            else
            {
                bt_enviar.Enabled = false;
                cb_ue.Checked = true;
            }
        }
        private void cb_ue_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_ue.Checked)
            {
                cv_ubt.Checked = false;
            }
            else
            {
                cv_ubt.Checked = true;
            }
        }
        private void tb_envia_TextChanged(object sender, EventArgs e)
        {
            int tamanho = tb_envia.TextLength;
            lb_carac.Text = string.Format("{0:00}", tamanho);

        }
        private void tb_recebe_TextChanged(object sender, EventArgs e)
        {
            int tamanhorec = tb_recebe.TextLength;
            lb_rec.Text = string.Format("{0:00}", tamanhorec);

        }
        private void tb_recebe_KeyDown(object sender, KeyEventArgs e)
        {

        }
        private void tb_envia_KeyDown(object sender, KeyEventArgs e)
        {
            if (cb_ue.Checked)
            {

                if (e.KeyCode == Keys.Enter)
                {
                    if (serialPort1.IsOpen)
                    {
                        if (modo == "WriteLine")
                        {
                            envio = tb_envia.Text;
                            serialPort1.WriteLine(envio);
                            tb_envia.Text = "";
                        }
                        else if(modo == "Write")
                        {
                            envio = tb_envia.Text;
                            serialPort1.Write(envio);
                            tb_envia.Text = "";
                        }
                    }
                }
            }
        }
        private void bt_limpasend_Click(object sender, EventArgs e)
        {
            tb_envia.Text = "";
        }
        private void cb_wl_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_wl.Checked)
            {
                modo = "WriteLine";
                cb_w.Checked = false;
            }
            else
            {
                modo = "Write";
                cb_w.Checked = true;
            }
        }
        private void cb_w_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_w.Checked)
            {
                cb_wl.Checked = false;
            }
            else
            {
                cb_wl.Checked = true;
            }
        }
        private void cb_dts_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_dts.Checked == true)
            {
                cb_rts.Checked = false;
                serialPort1.DtrEnable = true;
            }
            else
            {
                cb_rts.Checked = true;
                serialPort1.RtsEnable = true;
            }
        }
        private void cb_rts_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_rts.Checked == true)
            {
                cb_dts.Checked = false;
                serialPort1.RtsEnable = true;
            }
            else
            {
                cb_dts.Checked = true;
                serialPort1.DtrEnable = true;
            }
        }
        private void bt_fechar_MouseEnter(object sender, EventArgs e)
        {
            bt_fechar.Size = new Size(90, 80);
            bt_fechar.Location = new Point(825, 198);
        }
        private void bt_fechar_MouseLeave(object sender, EventArgs e)
        {
            bt_fechar.Size = new Size(83, 70);
            bt_fechar.Location = new Point(829, 203);
        }
        private void lb_carac_Click(object sender, EventArgs e)
        {

        }
        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            recebe = serialPort1.ReadLine();
           
            this.Invoke(new EventHandler(ShowData));        

        }
        private void ShowData(object sender, EventArgs e)
        {
            if (cb_au.Checked)
            {
               tb_recebe.Text ="";
               tb_recebe.Text += recebe;
               recebe = "";
            }
            else //(cb_add.Checked)
            {
             tb_recebe.Text += recebe;
            }
        }
        private void cb_au_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_au.Checked)
            {
                cb_au.Checked = true;                
                cb_add.Checked = false;                
            }
            else if (cb_au.Checked == false)
            {
                cb_add.Checked = true;
                cb_au.Checked = false;
            }
        }
        private void cb_add_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_add.Checked)
            {
                cb_add.Checked = true;
                cb_au.Checked = false;
            }
            else if (cb_add.Checked == false)
            {
                cb_au.Checked = true;
                cb_add.Checked = false;
            }
        }
        private void tb_recebe_MouseEnter(object sender, EventArgs e)
        {
            tb_recebe.Enabled = false;
        }
        private void tb_recebe_MouseLeave(object sender, EventArgs e)
        {
            tb_recebe.Enabled = true;
        }
    }
}
