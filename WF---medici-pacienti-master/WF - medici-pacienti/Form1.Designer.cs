
namespace WF___medici_pacienti
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Nume = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Cnp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Specializare = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemAdaugaMedic = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemModificaMedic = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemStergeMedic = new System.Windows.Forms.ToolStripMenuItem();
            this.listView2 = new System.Windows.Forms.ListView();
            this.lvpNume = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvpCnp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvpCardS = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.buttonEditeazaMedic = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.treeView2 = new System.Windows.Forms.TreeView();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonEditeazaPacient = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Nume,
            this.Cnp,
            this.Specializare});
            this.listView1.ContextMenuStrip = this.contextMenuStrip1;
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(36, 54);
            this.listView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(324, 191);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Nume
            // 
            this.Nume.Text = "Nume";
            this.Nume.Width = 104;
            // 
            // Cnp
            // 
            this.Cnp.Text = "Cnp";
            this.Cnp.Width = 104;
            // 
            // Specializare
            // 
            this.Specializare.Text = "Specializare";
            this.Specializare.Width = 160;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemAdaugaMedic,
            this.toolStripMenuItemModificaMedic,
            this.toolStripMenuItemStergeMedic});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(158, 70);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // toolStripMenuItemAdaugaMedic
            // 
            this.toolStripMenuItemAdaugaMedic.Name = "toolStripMenuItemAdaugaMedic";
            this.toolStripMenuItemAdaugaMedic.Size = new System.Drawing.Size(157, 22);
            this.toolStripMenuItemAdaugaMedic.Text = "Adauga Medic";
            this.toolStripMenuItemAdaugaMedic.Click += new System.EventHandler(this.toolStripMenuItemAdaugaMedic_Click);
            // 
            // toolStripMenuItemModificaMedic
            // 
            this.toolStripMenuItemModificaMedic.Name = "toolStripMenuItemModificaMedic";
            this.toolStripMenuItemModificaMedic.Size = new System.Drawing.Size(157, 22);
            this.toolStripMenuItemModificaMedic.Text = "Modifica Medic";
            this.toolStripMenuItemModificaMedic.Click += new System.EventHandler(this.toolStripMenuItemModificaMedic_Click);
            // 
            // toolStripMenuItemStergeMedic
            // 
            this.toolStripMenuItemStergeMedic.Name = "toolStripMenuItemStergeMedic";
            this.toolStripMenuItemStergeMedic.Size = new System.Drawing.Size(157, 22);
            this.toolStripMenuItemStergeMedic.Text = "Sterge Medic";
            this.toolStripMenuItemStergeMedic.Click += new System.EventHandler(this.toolStripMenuItemStergeMedic_Click);
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lvpNume,
            this.lvpCnp,
            this.lvpCardS});
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(484, 54);
            this.listView2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(302, 191);
            this.listView2.TabIndex = 1;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            this.listView2.SelectedIndexChanged += new System.EventHandler(this.listView2_SelectedIndexChanged);
            // 
            // lvpNume
            // 
            this.lvpNume.Text = "Nume";
            this.lvpNume.Width = 96;
            // 
            // lvpCnp
            // 
            this.lvpCnp.Text = "Cnp";
            this.lvpCnp.Width = 97;
            // 
            // lvpCardS
            // 
            this.lvpCardS.Text = "Card sanatate";
            this.lvpCardS.Width = 133;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(36, 263);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 32);
            this.button1.TabIndex = 2;
            this.button1.Text = "Adauga Medic";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonEditeazaMedic
            // 
            this.buttonEditeazaMedic.Location = new System.Drawing.Point(187, 263);
            this.buttonEditeazaMedic.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonEditeazaMedic.Name = "buttonEditeazaMedic";
            this.buttonEditeazaMedic.Size = new System.Drawing.Size(91, 32);
            this.buttonEditeazaMedic.TabIndex = 3;
            this.buttonEditeazaMedic.Text = "Editeaza Medic";
            this.buttonEditeazaMedic.UseVisualStyleBackColor = true;
            this.buttonEditeazaMedic.Click += new System.EventHandler(this.buttonEditeazaMedic_Click);
            // 
            // treeView1
            // 
            this.treeView1.CheckBoxes = true;
            this.treeView1.Location = new System.Drawing.Point(36, 328);
            this.treeView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(324, 218);
            this.treeView1.TabIndex = 5;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // treeView2
            // 
            this.treeView2.CheckBoxes = true;
            this.treeView2.Location = new System.Drawing.Point(484, 328);
            this.treeView2.Margin = new System.Windows.Forms.Padding(2);
            this.treeView2.Name = "treeView2";
            this.treeView2.Size = new System.Drawing.Size(324, 218);
            this.treeView2.TabIndex = 6;
            this.treeView2.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView2_AfterSelect);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(484, 263);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 32);
            this.button2.TabIndex = 7;
            this.button2.Text = "Adauga Pacient";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonEditeazaPacient
            // 
            this.buttonEditeazaPacient.Location = new System.Drawing.Point(662, 263);
            this.buttonEditeazaPacient.Margin = new System.Windows.Forms.Padding(2);
            this.buttonEditeazaPacient.Name = "buttonEditeazaPacient";
            this.buttonEditeazaPacient.Size = new System.Drawing.Size(115, 32);
            this.buttonEditeazaPacient.TabIndex = 8;
            this.buttonEditeazaPacient.Text = "Editeaza Pacient";
            this.buttonEditeazaPacient.UseVisualStyleBackColor = true;
            this.buttonEditeazaPacient.Click += new System.EventHandler(this.buttonEditeazaPacient_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 555);
            this.Controls.Add(this.buttonEditeazaPacient);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.treeView2);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.buttonEditeazaMedic);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.listView1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Nume;
        private System.Windows.Forms.ColumnHeader Cnp;
        private System.Windows.Forms.ColumnHeader Specializare;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader lvpNume;
        private System.Windows.Forms.ColumnHeader lvpCnp;
        private System.Windows.Forms.ColumnHeader lvpCardS;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonEditeazaMedic;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemAdaugaMedic;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemModificaMedic;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemStergeMedic;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.TreeView treeView2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonEditeazaPacient;
    }
}

