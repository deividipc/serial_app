namespace testeserial
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bt_conectar = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.cb_com = new System.Windows.Forms.ComboBox();
            this.tb_envia = new System.Windows.Forms.TextBox();
            this.tb_recebe = new System.Windows.Forms.TextBox();
            this.Envia = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lb_rec = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cb_add = new System.Windows.Forms.CheckBox();
            this.cb_au = new System.Windows.Forms.CheckBox();
            this.bt_fechar = new System.Windows.Forms.Button();
            this.bt_clear = new System.Windows.Forms.Button();
            this.lb_onoff = new System.Windows.Forms.Label();
            this.bt_limpasend = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lb_carac = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cb_w = new System.Windows.Forms.CheckBox();
            this.cb_wl = new System.Windows.Forms.CheckBox();
            this.cb_ue = new System.Windows.Forms.CheckBox();
            this.cv_ubt = new System.Windows.Forms.CheckBox();
            this.bt_desconectar = new System.Windows.Forms.Button();
            this.cb_rts = new System.Windows.Forms.CheckBox();
            this.cb_dts = new System.Windows.Forms.CheckBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.bt_enviar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_parity = new System.Windows.Forms.ComboBox();
            this.cb_stop = new System.Windows.Forms.ComboBox();
            this.cb_bits = new System.Windows.Forms.ComboBox();
            this.cb_baud = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bt_conectar
            // 
            this.bt_conectar.BackColor = System.Drawing.Color.Transparent;
            this.bt_conectar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_conectar.BackgroundImage")));
            this.bt_conectar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_conectar.FlatAppearance.BorderSize = 0;
            this.bt_conectar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_conectar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bt_conectar.Location = new System.Drawing.Point(7, 19);
            this.bt_conectar.Name = "bt_conectar";
            this.bt_conectar.Size = new System.Drawing.Size(79, 42);
            this.bt_conectar.TabIndex = 0;
            this.bt_conectar.UseVisualStyleBackColor = false;
            this.bt_conectar.Click += new System.EventHandler(this.bt_conectar_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // cb_com
            // 
            this.cb_com.FormattingEnabled = true;
            this.cb_com.Location = new System.Drawing.Point(82, 85);
            this.cb_com.Name = "cb_com";
            this.cb_com.Size = new System.Drawing.Size(109, 21);
            this.cb_com.TabIndex = 1;
            this.cb_com.SelectedIndexChanged += new System.EventHandler(this.cb_com_SelectedIndexChanged);
            // 
            // tb_envia
            // 
            this.tb_envia.Location = new System.Drawing.Point(272, 23);
            this.tb_envia.Multiline = true;
            this.tb_envia.Name = "tb_envia";
            this.tb_envia.Size = new System.Drawing.Size(162, 124);
            this.tb_envia.TabIndex = 2;
            this.tb_envia.TextChanged += new System.EventHandler(this.tb_envia_TextChanged);
            this.tb_envia.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_envia_KeyDown);
            // 
            // tb_recebe
            // 
            this.tb_recebe.Cursor = System.Windows.Forms.Cursors.No;
            this.tb_recebe.Location = new System.Drawing.Point(633, 23);
            this.tb_recebe.Multiline = true;
            this.tb_recebe.Name = "tb_recebe";
            this.tb_recebe.Size = new System.Drawing.Size(162, 124);
            this.tb_recebe.TabIndex = 3;
            this.tb_recebe.TextChanged += new System.EventHandler(this.tb_recebe_TextChanged);
            this.tb_recebe.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_recebe_KeyDown);
            this.tb_recebe.MouseEnter += new System.EventHandler(this.tb_recebe_MouseEnter);
            this.tb_recebe.MouseLeave += new System.EventHandler(this.tb_recebe_MouseLeave);
            // 
            // Envia
            // 
            this.Envia.AutoSize = true;
            this.Envia.Location = new System.Drawing.Point(235, 78);
            this.Envia.Name = "Envia";
            this.Envia.Size = new System.Drawing.Size(37, 13);
            this.Envia.TabIndex = 4;
            this.Envia.Text = "SEND";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(574, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "RECEIVE";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.bt_fechar);
            this.groupBox1.Controls.Add(this.bt_clear);
            this.groupBox1.Controls.Add(this.lb_onoff);
            this.groupBox1.Controls.Add(this.bt_limpasend);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.bt_desconectar);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tb_recebe);
            this.groupBox1.Controls.Add(this.cb_rts);
            this.groupBox1.Controls.Add(this.cb_dts);
            this.groupBox1.Controls.Add(this.progressBar1);
            this.groupBox1.Controls.Add(this.bt_enviar);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cb_parity);
            this.groupBox1.Controls.Add(this.cb_stop);
            this.groupBox1.Controls.Add(this.cb_bits);
            this.groupBox1.Controls.Add(this.cb_baud);
            this.groupBox1.Controls.Add(this.Envia);
            this.groupBox1.Controls.Add(this.tb_envia);
            this.groupBox1.Controls.Add(this.cb_com);
            this.groupBox1.Controls.Add(this.bt_conectar);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(918, 279);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Porta Serial";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lb_rec);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.cb_add);
            this.groupBox3.Controls.Add(this.cb_au);
            this.groupBox3.Location = new System.Drawing.Point(589, 153);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(206, 120);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Config Receive";
            // 
            // lb_rec
            // 
            this.lb_rec.AutoSize = true;
            this.lb_rec.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_rec.Location = new System.Drawing.Point(170, 88);
            this.lb_rec.Name = "lb_rec";
            this.lb_rec.Size = new System.Drawing.Size(34, 22);
            this.lb_rec.TabIndex = 5;
            this.lb_rec.Text = "00";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(13, 86);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(143, 22);
            this.label9.TabIndex = 4;
            this.label9.Text = "Caracteres:";
            // 
            // cb_add
            // 
            this.cb_add.AutoSize = true;
            this.cb_add.Location = new System.Drawing.Point(17, 55);
            this.cb_add.Name = "cb_add";
            this.cb_add.Size = new System.Drawing.Size(102, 17);
            this.cb_add.TabIndex = 1;
            this.cb_add.Text = "Add to Old Data";
            this.cb_add.UseVisualStyleBackColor = true;
            this.cb_add.CheckedChanged += new System.EventHandler(this.cb_add_CheckedChanged);
            // 
            // cb_au
            // 
            this.cb_au.AutoSize = true;
            this.cb_au.Location = new System.Drawing.Point(17, 23);
            this.cb_au.Name = "cb_au";
            this.cb_au.Size = new System.Drawing.Size(97, 17);
            this.cb_au.TabIndex = 0;
            this.cb_au.Text = "Always Update";
            this.cb_au.UseVisualStyleBackColor = true;
            this.cb_au.CheckedChanged += new System.EventHandler(this.cb_au_CheckedChanged);
            // 
            // bt_fechar
            // 
            this.bt_fechar.BackColor = System.Drawing.Color.Transparent;
            this.bt_fechar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_fechar.BackgroundImage")));
            this.bt_fechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_fechar.FlatAppearance.BorderSize = 0;
            this.bt_fechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_fechar.ForeColor = System.Drawing.Color.Transparent;
            this.bt_fechar.Location = new System.Drawing.Point(829, 203);
            this.bt_fechar.Name = "bt_fechar";
            this.bt_fechar.Size = new System.Drawing.Size(83, 70);
            this.bt_fechar.TabIndex = 17;
            this.bt_fechar.UseVisualStyleBackColor = false;
            this.bt_fechar.Click += new System.EventHandler(this.bt_fechar_Click);
            this.bt_fechar.MouseEnter += new System.EventHandler(this.bt_fechar_MouseEnter);
            this.bt_fechar.MouseLeave += new System.EventHandler(this.bt_fechar_MouseLeave);
            // 
            // bt_clear
            // 
            this.bt_clear.Location = new System.Drawing.Point(803, 63);
            this.bt_clear.Name = "bt_clear";
            this.bt_clear.Size = new System.Drawing.Size(109, 42);
            this.bt_clear.TabIndex = 24;
            this.bt_clear.Text = "Clear Receive";
            this.bt_clear.UseVisualStyleBackColor = true;
            this.bt_clear.Click += new System.EventHandler(this.bt_clear_Click);
            // 
            // lb_onoff
            // 
            this.lb_onoff.AutoSize = true;
            this.lb_onoff.Location = new System.Drawing.Point(106, 35);
            this.lb_onoff.Name = "lb_onoff";
            this.lb_onoff.Size = new System.Drawing.Size(23, 13);
            this.lb_onoff.TabIndex = 26;
            this.lb_onoff.Text = "ON";
            // 
            // bt_limpasend
            // 
            this.bt_limpasend.Location = new System.Drawing.Point(445, 63);
            this.bt_limpasend.Name = "bt_limpasend";
            this.bt_limpasend.Size = new System.Drawing.Size(109, 42);
            this.bt_limpasend.TabIndex = 25;
            this.bt_limpasend.Text = "Clear Send";
            this.bt_limpasend.UseVisualStyleBackColor = true;
            this.bt_limpasend.Click += new System.EventHandler(this.bt_limpasend_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lb_carac);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.cb_w);
            this.groupBox2.Controls.Add(this.cb_wl);
            this.groupBox2.Controls.Add(this.cb_ue);
            this.groupBox2.Controls.Add(this.cv_ubt);
            this.groupBox2.Location = new System.Drawing.Point(197, 153);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(237, 120);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Config Send";
            // 
            // lb_carac
            // 
            this.lb_carac.AutoSize = true;
            this.lb_carac.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_carac.Location = new System.Drawing.Point(170, 88);
            this.lb_carac.Name = "lb_carac";
            this.lb_carac.Size = new System.Drawing.Size(34, 22);
            this.lb_carac.TabIndex = 5;
            this.lb_carac.Text = "00";
            this.lb_carac.Click += new System.EventHandler(this.lb_carac_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(143, 22);
            this.label7.TabIndex = 4;
            this.label7.Text = "Caracteres:";
            // 
            // cb_w
            // 
            this.cb_w.AutoSize = true;
            this.cb_w.Location = new System.Drawing.Point(127, 55);
            this.cb_w.Name = "cb_w";
            this.cb_w.Size = new System.Drawing.Size(81, 17);
            this.cb_w.TabIndex = 3;
            this.cb_w.Text = "Using Write";
            this.cb_w.UseVisualStyleBackColor = true;
            this.cb_w.CheckedChanged += new System.EventHandler(this.cb_w_CheckedChanged);
            // 
            // cb_wl
            // 
            this.cb_wl.AutoSize = true;
            this.cb_wl.Location = new System.Drawing.Point(127, 23);
            this.cb_wl.Name = "cb_wl";
            this.cb_wl.Size = new System.Drawing.Size(104, 17);
            this.cb_wl.TabIndex = 2;
            this.cb_wl.Text = "Using Write Line";
            this.cb_wl.UseVisualStyleBackColor = true;
            this.cb_wl.CheckedChanged += new System.EventHandler(this.cb_wl_CheckedChanged);
            // 
            // cb_ue
            // 
            this.cb_ue.AutoSize = true;
            this.cb_ue.Location = new System.Drawing.Point(17, 55);
            this.cb_ue.Name = "cb_ue";
            this.cb_ue.Size = new System.Drawing.Size(81, 17);
            this.cb_ue.TabIndex = 1;
            this.cb_ue.Text = "Using Enter";
            this.cb_ue.UseVisualStyleBackColor = true;
            this.cb_ue.CheckedChanged += new System.EventHandler(this.cb_ue_CheckedChanged);
            // 
            // cv_ubt
            // 
            this.cv_ubt.AutoSize = true;
            this.cv_ubt.Location = new System.Drawing.Point(17, 23);
            this.cv_ubt.Name = "cv_ubt";
            this.cv_ubt.Size = new System.Drawing.Size(87, 17);
            this.cv_ubt.TabIndex = 0;
            this.cv_ubt.Text = "Using Button";
            this.cv_ubt.UseVisualStyleBackColor = true;
            this.cv_ubt.CheckedChanged += new System.EventHandler(this.cv_ubt_CheckedChanged);
            // 
            // bt_desconectar
            // 
            this.bt_desconectar.BackColor = System.Drawing.Color.Transparent;
            this.bt_desconectar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_desconectar.BackgroundImage")));
            this.bt_desconectar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_desconectar.Cursor = System.Windows.Forms.Cursors.Default;
            this.bt_desconectar.FlatAppearance.BorderColor = System.Drawing.SystemColors.InactiveBorder;
            this.bt_desconectar.FlatAppearance.BorderSize = 0;
            this.bt_desconectar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_desconectar.ForeColor = System.Drawing.Color.Transparent;
            this.bt_desconectar.Location = new System.Drawing.Point(148, 19);
            this.bt_desconectar.Name = "bt_desconectar";
            this.bt_desconectar.Size = new System.Drawing.Size(79, 42);
            this.bt_desconectar.TabIndex = 21;
            this.bt_desconectar.UseVisualStyleBackColor = false;
            this.bt_desconectar.Click += new System.EventHandler(this.bt_desconectar_Click);
            // 
            // cb_rts
            // 
            this.cb_rts.AutoSize = true;
            this.cb_rts.Location = new System.Drawing.Point(93, 239);
            this.cb_rts.Name = "cb_rts";
            this.cb_rts.Size = new System.Drawing.Size(48, 17);
            this.cb_rts.TabIndex = 19;
            this.cb_rts.Text = "RTS";
            this.cb_rts.UseVisualStyleBackColor = true;
            this.cb_rts.CheckedChanged += new System.EventHandler(this.cb_rts_CheckedChanged);
            // 
            // cb_dts
            // 
            this.cb_dts.Location = new System.Drawing.Point(9, 235);
            this.cb_dts.Name = "cb_dts";
            this.cb_dts.Size = new System.Drawing.Size(60, 24);
            this.cb_dts.TabIndex = 22;
            this.cb_dts.Text = "DTR";
            this.cb_dts.CheckedChanged += new System.EventHandler(this.cb_dts_CheckedChanged);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(93, 19);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(48, 42);
            this.progressBar1.TabIndex = 16;
            // 
            // bt_enviar
            // 
            this.bt_enviar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_enviar.BackgroundImage")));
            this.bt_enviar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_enviar.FlatAppearance.BorderSize = 0;
            this.bt_enviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_enviar.Location = new System.Drawing.Point(445, 11);
            this.bt_enviar.Name = "bt_enviar";
            this.bt_enviar.Size = new System.Drawing.Size(109, 42);
            this.bt_enviar.TabIndex = 15;
            this.bt_enviar.UseVisualStyleBackColor = true;
            this.bt_enviar.Click += new System.EventHandler(this.bt_enviar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 206);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "PARITY BITS";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "STOP BITS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "BITS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "BAUD RATE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "PORTS";
            // 
            // cb_parity
            // 
            this.cb_parity.FormattingEnabled = true;
            this.cb_parity.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even"});
            this.cb_parity.Location = new System.Drawing.Point(82, 197);
            this.cb_parity.Name = "cb_parity";
            this.cb_parity.Size = new System.Drawing.Size(109, 21);
            this.cb_parity.TabIndex = 9;
            this.cb_parity.Text = "None";
            this.cb_parity.SelectedIndexChanged += new System.EventHandler(this.cb_parity_SelectedIndexChanged);
            // 
            // cb_stop
            // 
            this.cb_stop.FormattingEnabled = true;
            this.cb_stop.Items.AddRange(new object[] {
            "One",
            "Two"});
            this.cb_stop.Location = new System.Drawing.Point(82, 169);
            this.cb_stop.Name = "cb_stop";
            this.cb_stop.Size = new System.Drawing.Size(109, 21);
            this.cb_stop.TabIndex = 8;
            this.cb_stop.Text = "One";
            this.cb_stop.SelectedIndexChanged += new System.EventHandler(this.cb_stop_SelectedIndexChanged);
            // 
            // cb_bits
            // 
            this.cb_bits.FormattingEnabled = true;
            this.cb_bits.Items.AddRange(new object[] {
            "6",
            "7",
            "8"});
            this.cb_bits.Location = new System.Drawing.Point(82, 141);
            this.cb_bits.Name = "cb_bits";
            this.cb_bits.Size = new System.Drawing.Size(109, 21);
            this.cb_bits.TabIndex = 7;
            this.cb_bits.Text = "8";
            this.cb_bits.SelectedIndexChanged += new System.EventHandler(this.cb_bits_SelectedIndexChanged);
            // 
            // cb_baud
            // 
            this.cb_baud.FormattingEnabled = true;
            this.cb_baud.Items.AddRange(new object[] {
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "38400",
            "57600"});
            this.cb_baud.Location = new System.Drawing.Point(82, 113);
            this.cb_baud.Name = "cb_baud";
            this.cb_baud.Size = new System.Drawing.Size(109, 21);
            this.cb_baud.TabIndex = 6;
            this.cb_baud.Text = "9600";
            this.cb_baud.SelectedIndexChanged += new System.EventHandler(this.cb_baud_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 307);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "CONEXÃO SERIAL";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_conectar;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.ComboBox cb_com;
        private System.Windows.Forms.TextBox tb_envia;
        private System.Windows.Forms.TextBox tb_recebe;
        private System.Windows.Forms.Label Envia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_parity;
        private System.Windows.Forms.ComboBox cb_stop;
        private System.Windows.Forms.ComboBox cb_bits;
        private System.Windows.Forms.ComboBox cb_baud;
        private System.Windows.Forms.Button bt_enviar;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button bt_fechar;
        private System.Windows.Forms.CheckBox cb_rts;
        private System.Windows.Forms.CheckBox cb_dts;
        private System.Windows.Forms.Button bt_desconectar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox cb_w;
        private System.Windows.Forms.CheckBox cb_wl;
        private System.Windows.Forms.CheckBox cb_ue;
        private System.Windows.Forms.CheckBox cv_ubt;
        private System.Windows.Forms.Button bt_clear;
        private System.Windows.Forms.Label lb_carac;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button bt_limpasend;
        private System.Windows.Forms.Label lb_onoff;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lb_rec;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox cb_add;
        private System.Windows.Forms.CheckBox cb_au;
    }
}

