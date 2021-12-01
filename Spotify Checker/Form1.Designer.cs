
namespace Spotify_Checker
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.nsTheme1 = new NSTheme();
            this.listView1 = new System.Windows.Forms.ListView();
            this.column_mail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nsGroupBox4 = new NSGroupBox();
            this.nsLabel4 = new NSLabel();
            this.nsLabel6 = new NSLabel();
            this.ttl_Combos = new System.Windows.Forms.Label();
            this.nsLabel5 = new NSLabel();
            this.ttl_Proxy = new System.Windows.Forms.Label();
            this.ttl_Checked = new System.Windows.Forms.Label();
            this.nsLabel3 = new NSLabel();
            this.ttl_Errors = new System.Windows.Forms.Label();
            this.nsLabel2 = new NSLabel();
            this.ttl_Good = new System.Windows.Forms.Label();
            this.nsLabel1 = new NSLabel();
            this.ttl_Bad = new System.Windows.Forms.Label();
            this.nsGroupBox3 = new NSGroupBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.nsGroupBox2 = new NSGroupBox();
            this.checkbox_Socks5 = new NSCheckBox();
            this.checkbox_http = new NSCheckBox();
            this.checkbox_Socks4 = new NSCheckBox();
            this.nsGroupBox1 = new NSGroupBox();
            this.nsButton2 = new NSButton();
            this.nsButton1 = new NSButton();
            this.nsButton3 = new NSButton();
            this.nsControlButton1 = new NSControlButton();
            this.nsTheme1.SuspendLayout();
            this.nsGroupBox4.SuspendLayout();
            this.nsGroupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.nsGroupBox2.SuspendLayout();
            this.nsGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nsTheme1
            // 
            this.nsTheme1.AccentOffset = 0;
            this.nsTheme1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.nsTheme1.BorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.nsTheme1.Colors = new Bloom[0];
            this.nsTheme1.Controls.Add(this.listView1);
            this.nsTheme1.Controls.Add(this.nsGroupBox4);
            this.nsTheme1.Controls.Add(this.nsGroupBox3);
            this.nsTheme1.Controls.Add(this.nsGroupBox2);
            this.nsTheme1.Controls.Add(this.nsGroupBox1);
            this.nsTheme1.Controls.Add(this.nsButton3);
            this.nsTheme1.Controls.Add(this.nsControlButton1);
            this.nsTheme1.Customization = "";
            this.nsTheme1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nsTheme1.Font = new System.Drawing.Font("Verdana", 8F);
            this.nsTheme1.Image = null;
            this.nsTheme1.Location = new System.Drawing.Point(0, 0);
            this.nsTheme1.Movable = true;
            this.nsTheme1.Name = "nsTheme1";
            this.nsTheme1.NoRounding = false;
            this.nsTheme1.Sizable = true;
            this.nsTheme1.Size = new System.Drawing.Size(712, 463);
            this.nsTheme1.SmartBounds = true;
            this.nsTheme1.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.nsTheme1.TabIndex = 0;
            this.nsTheme1.Text = "Spotify Checker | By Sheyzouh";
            this.nsTheme1.TransparencyKey = System.Drawing.Color.Empty;
            this.nsTheme1.Transparent = false;
            this.nsTheme1.Click += new System.EventHandler(this.nsTheme1_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.column_mail});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(229, 41);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(462, 314);
            this.listView1.TabIndex = 22;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // column_mail
            // 
            this.column_mail.Text = "Email";
            this.column_mail.Width = 180;
            // 
            // nsGroupBox4
            // 
            this.nsGroupBox4.Controls.Add(this.nsLabel4);
            this.nsGroupBox4.Controls.Add(this.nsLabel6);
            this.nsGroupBox4.Controls.Add(this.ttl_Combos);
            this.nsGroupBox4.Controls.Add(this.nsLabel5);
            this.nsGroupBox4.Controls.Add(this.ttl_Proxy);
            this.nsGroupBox4.Controls.Add(this.ttl_Checked);
            this.nsGroupBox4.Controls.Add(this.nsLabel3);
            this.nsGroupBox4.Controls.Add(this.ttl_Errors);
            this.nsGroupBox4.Controls.Add(this.nsLabel2);
            this.nsGroupBox4.Controls.Add(this.ttl_Good);
            this.nsGroupBox4.Controls.Add(this.nsLabel1);
            this.nsGroupBox4.Controls.Add(this.ttl_Bad);
            this.nsGroupBox4.DrawSeperator = false;
            this.nsGroupBox4.Location = new System.Drawing.Point(229, 362);
            this.nsGroupBox4.Name = "nsGroupBox4";
            this.nsGroupBox4.Size = new System.Drawing.Size(462, 89);
            this.nsGroupBox4.SubTitle = "";
            this.nsGroupBox4.TabIndex = 21;
            this.nsGroupBox4.Text = "nsGroupBox4";
            this.nsGroupBox4.Title = "Information";
            // 
            // nsLabel4
            // 
            this.nsLabel4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.nsLabel4.Location = new System.Drawing.Point(199, 56);
            this.nsLabel4.Name = "nsLabel4";
            this.nsLabel4.Size = new System.Drawing.Size(60, 23);
            this.nsLabel4.TabIndex = 18;
            this.nsLabel4.Text = "nsLabel4";
            this.nsLabel4.Value1 = "Errors";
            this.nsLabel4.Value2 = " :";
            // 
            // nsLabel6
            // 
            this.nsLabel6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.nsLabel6.Location = new System.Drawing.Point(337, 56);
            this.nsLabel6.Name = "nsLabel6";
            this.nsLabel6.Size = new System.Drawing.Size(48, 23);
            this.nsLabel6.TabIndex = 20;
            this.nsLabel6.Text = "nsLabel6";
            this.nsLabel6.Value1 = "Bad";
            this.nsLabel6.Value2 = " :";
            // 
            // ttl_Combos
            // 
            this.ttl_Combos.AutoSize = true;
            this.ttl_Combos.ForeColor = System.Drawing.Color.White;
            this.ttl_Combos.Location = new System.Drawing.Point(129, 34);
            this.ttl_Combos.Name = "ttl_Combos";
            this.ttl_Combos.Size = new System.Drawing.Size(14, 13);
            this.ttl_Combos.TabIndex = 9;
            this.ttl_Combos.Text = "0";
            // 
            // nsLabel5
            // 
            this.nsLabel5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.nsLabel5.Location = new System.Drawing.Point(325, 27);
            this.nsLabel5.Name = "nsLabel5";
            this.nsLabel5.Size = new System.Drawing.Size(60, 23);
            this.nsLabel5.TabIndex = 19;
            this.nsLabel5.Text = "nsLabel5";
            this.nsLabel5.Value1 = "Good";
            this.nsLabel5.Value2 = " :";
            // 
            // ttl_Proxy
            // 
            this.ttl_Proxy.AutoSize = true;
            this.ttl_Proxy.ForeColor = System.Drawing.Color.White;
            this.ttl_Proxy.Location = new System.Drawing.Point(129, 62);
            this.ttl_Proxy.Name = "ttl_Proxy";
            this.ttl_Proxy.Size = new System.Drawing.Size(14, 13);
            this.ttl_Proxy.TabIndex = 10;
            this.ttl_Proxy.Text = "0";
            // 
            // ttl_Checked
            // 
            this.ttl_Checked.AutoSize = true;
            this.ttl_Checked.ForeColor = System.Drawing.Color.White;
            this.ttl_Checked.Location = new System.Drawing.Point(274, 34);
            this.ttl_Checked.Name = "ttl_Checked";
            this.ttl_Checked.Size = new System.Drawing.Size(14, 13);
            this.ttl_Checked.TabIndex = 11;
            this.ttl_Checked.Text = "0";
            // 
            // nsLabel3
            // 
            this.nsLabel3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.nsLabel3.Location = new System.Drawing.Point(181, 27);
            this.nsLabel3.Name = "nsLabel3";
            this.nsLabel3.Size = new System.Drawing.Size(78, 23);
            this.nsLabel3.TabIndex = 17;
            this.nsLabel3.Text = "nsLabel3";
            this.nsLabel3.Value1 = "Checked";
            this.nsLabel3.Value2 = " :";
            // 
            // ttl_Errors
            // 
            this.ttl_Errors.AutoSize = true;
            this.ttl_Errors.ForeColor = System.Drawing.Color.White;
            this.ttl_Errors.Location = new System.Drawing.Point(274, 62);
            this.ttl_Errors.Name = "ttl_Errors";
            this.ttl_Errors.Size = new System.Drawing.Size(14, 13);
            this.ttl_Errors.TabIndex = 12;
            this.ttl_Errors.Text = "0";
            // 
            // nsLabel2
            // 
            this.nsLabel2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.nsLabel2.Location = new System.Drawing.Point(56, 56);
            this.nsLabel2.Name = "nsLabel2";
            this.nsLabel2.Size = new System.Drawing.Size(58, 23);
            this.nsLabel2.TabIndex = 16;
            this.nsLabel2.Text = "nsLabel2";
            this.nsLabel2.Value1 = "Proxy";
            this.nsLabel2.Value2 = " :";
            // 
            // ttl_Good
            // 
            this.ttl_Good.AutoSize = true;
            this.ttl_Good.ForeColor = System.Drawing.Color.White;
            this.ttl_Good.Location = new System.Drawing.Point(405, 34);
            this.ttl_Good.Name = "ttl_Good";
            this.ttl_Good.Size = new System.Drawing.Size(14, 13);
            this.ttl_Good.TabIndex = 13;
            this.ttl_Good.Text = "0";
            // 
            // nsLabel1
            // 
            this.nsLabel1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.nsLabel1.Location = new System.Drawing.Point(39, 27);
            this.nsLabel1.Name = "nsLabel1";
            this.nsLabel1.Size = new System.Drawing.Size(75, 23);
            this.nsLabel1.TabIndex = 15;
            this.nsLabel1.Text = "nsLabel1";
            this.nsLabel1.Value1 = "Combos";
            this.nsLabel1.Value2 = " :";
            // 
            // ttl_Bad
            // 
            this.ttl_Bad.AutoSize = true;
            this.ttl_Bad.ForeColor = System.Drawing.Color.White;
            this.ttl_Bad.Location = new System.Drawing.Point(405, 62);
            this.ttl_Bad.Name = "ttl_Bad";
            this.ttl_Bad.Size = new System.Drawing.Size(14, 13);
            this.ttl_Bad.TabIndex = 14;
            this.ttl_Bad.Text = "0";
            // 
            // nsGroupBox3
            // 
            this.nsGroupBox3.Controls.Add(this.numericUpDown1);
            this.nsGroupBox3.DrawSeperator = false;
            this.nsGroupBox3.Location = new System.Drawing.Point(12, 280);
            this.nsGroupBox3.Name = "nsGroupBox3";
            this.nsGroupBox3.Size = new System.Drawing.Size(196, 75);
            this.nsGroupBox3.SubTitle = "";
            this.nsGroupBox3.TabIndex = 7;
            this.nsGroupBox3.Text = "nsGroupBox3";
            this.nsGroupBox3.Title = "Threads";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.numericUpDown1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numericUpDown1.ForeColor = System.Drawing.Color.Red;
            this.numericUpDown1.Location = new System.Drawing.Point(11, 41);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(174, 16);
            this.numericUpDown1.TabIndex = 6;
            this.numericUpDown1.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // nsGroupBox2
            // 
            this.nsGroupBox2.Controls.Add(this.checkbox_Socks5);
            this.nsGroupBox2.Controls.Add(this.checkbox_http);
            this.nsGroupBox2.Controls.Add(this.checkbox_Socks4);
            this.nsGroupBox2.DrawSeperator = false;
            this.nsGroupBox2.Location = new System.Drawing.Point(12, 147);
            this.nsGroupBox2.Name = "nsGroupBox2";
            this.nsGroupBox2.Size = new System.Drawing.Size(196, 127);
            this.nsGroupBox2.SubTitle = "";
            this.nsGroupBox2.TabIndex = 5;
            this.nsGroupBox2.Text = "nsGroupBox2";
            this.nsGroupBox2.Title = "Proxy type";
            // 
            // checkbox_Socks5
            // 
            this.checkbox_Socks5.Checked = false;
            this.checkbox_Socks5.Location = new System.Drawing.Point(11, 91);
            this.checkbox_Socks5.Name = "checkbox_Socks5";
            this.checkbox_Socks5.Size = new System.Drawing.Size(107, 23);
            this.checkbox_Socks5.TabIndex = 8;
            this.checkbox_Socks5.Text = "Socks5";
            // 
            // checkbox_http
            // 
            this.checkbox_http.Checked = false;
            this.checkbox_http.Location = new System.Drawing.Point(11, 33);
            this.checkbox_http.Name = "checkbox_http";
            this.checkbox_http.Size = new System.Drawing.Size(107, 23);
            this.checkbox_http.TabIndex = 6;
            this.checkbox_http.Text = "Http/s";
            // 
            // checkbox_Socks4
            // 
            this.checkbox_Socks4.Checked = false;
            this.checkbox_Socks4.Location = new System.Drawing.Point(11, 62);
            this.checkbox_Socks4.Name = "checkbox_Socks4";
            this.checkbox_Socks4.Size = new System.Drawing.Size(107, 23);
            this.checkbox_Socks4.TabIndex = 7;
            this.checkbox_Socks4.Text = "Socks4";
            // 
            // nsGroupBox1
            // 
            this.nsGroupBox1.Controls.Add(this.nsButton2);
            this.nsGroupBox1.Controls.Add(this.nsButton1);
            this.nsGroupBox1.DrawSeperator = false;
            this.nsGroupBox1.Location = new System.Drawing.Point(12, 41);
            this.nsGroupBox1.Name = "nsGroupBox1";
            this.nsGroupBox1.Size = new System.Drawing.Size(196, 100);
            this.nsGroupBox1.SubTitle = "";
            this.nsGroupBox1.TabIndex = 4;
            this.nsGroupBox1.Text = "nsGroupBox1";
            this.nsGroupBox1.Title = "Load ";
            // 
            // nsButton2
            // 
            this.nsButton2.Location = new System.Drawing.Point(11, 61);
            this.nsButton2.Name = "nsButton2";
            this.nsButton2.SelectedIndex = 0;
            this.nsButton2.Size = new System.Drawing.Size(174, 23);
            this.nsButton2.TabIndex = 2;
            this.nsButton2.Text = "Load Proxy";
            this.nsButton2.Click += new System.EventHandler(this.Load_Proxy);
            // 
            // nsButton1
            // 
            this.nsButton1.Location = new System.Drawing.Point(11, 32);
            this.nsButton1.Name = "nsButton1";
            this.nsButton1.SelectedIndex = 0;
            this.nsButton1.Size = new System.Drawing.Size(174, 23);
            this.nsButton1.TabIndex = 1;
            this.nsButton1.Text = "Load Combo";
            this.nsButton1.Click += new System.EventHandler(this.Load_Combos);
            // 
            // nsButton3
            // 
            this.nsButton3.Location = new System.Drawing.Point(23, 385);
            this.nsButton3.Name = "nsButton3";
            this.nsButton3.SelectedIndex = 0;
            this.nsButton3.Size = new System.Drawing.Size(174, 23);
            this.nsButton3.TabIndex = 3;
            this.nsButton3.Text = "Start";
            this.nsButton3.Click += new System.EventHandler(this.btn_Start);
            // 
            // nsControlButton1
            // 
            this.nsControlButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nsControlButton1.ControlButton = NSControlButton.Button.Close;
            this.nsControlButton1.Location = new System.Drawing.Point(691, 4);
            this.nsControlButton1.Margin = new System.Windows.Forms.Padding(0);
            this.nsControlButton1.MaximumSize = new System.Drawing.Size(18, 20);
            this.nsControlButton1.MinimumSize = new System.Drawing.Size(18, 20);
            this.nsControlButton1.Name = "nsControlButton1";
            this.nsControlButton1.Size = new System.Drawing.Size(18, 20);
            this.nsControlButton1.TabIndex = 0;
            this.nsControlButton1.Text = "nsControlButton1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 463);
            this.Controls.Add(this.nsTheme1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.nsTheme1.ResumeLayout(false);
            this.nsGroupBox4.ResumeLayout(false);
            this.nsGroupBox4.PerformLayout();
            this.nsGroupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.nsGroupBox2.ResumeLayout(false);
            this.nsGroupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private NSTheme nsTheme1;
        private NSGroupBox nsGroupBox3;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private NSGroupBox nsGroupBox2;
        private NSCheckBox checkbox_Socks5;
        private NSCheckBox checkbox_http;
        private NSCheckBox checkbox_Socks4;
        private NSGroupBox nsGroupBox1;
        private NSButton nsButton2;
        private NSButton nsButton1;
        private NSButton nsButton3;
        private NSControlButton nsControlButton1;
        private NSGroupBox nsGroupBox4;
        private NSLabel nsLabel6;
        private NSLabel nsLabel5;
        private NSLabel nsLabel4;
        private NSLabel nsLabel3;
        private NSLabel nsLabel2;
        private NSLabel nsLabel1;
        private System.Windows.Forms.Label ttl_Bad;
        private System.Windows.Forms.Label ttl_Good;
        private System.Windows.Forms.Label ttl_Errors;
        private System.Windows.Forms.Label ttl_Checked;
        private System.Windows.Forms.Label ttl_Proxy;
        private System.Windows.Forms.Label ttl_Combos;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader column_mail;
    }
}

