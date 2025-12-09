namespace SGPL.App.Register
{
    partial class AnimalForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            txtName = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtAge = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            chkProducer = new ReaLTaiizor.Controls.MaterialSwitch();
            txtId = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            cmbProduction = new ReaLTaiizor.Controls.MaterialComboBox();
            tabControlRegister.SuspendLayout();
            tabPageRegister.SuspendLayout();
            SuspendLayout();
            // 
            // tabControlRegister
            // 
            tabControlRegister.Size = new Size(794, 448);
            // 
            // tabPageRegister
            // 
            tabPageRegister.Controls.Add(txtName);
            tabPageRegister.Controls.Add(txtAge);
            tabPageRegister.Controls.Add(chkProducer);
            tabPageRegister.Controls.Add(txtId);
            tabPageRegister.Controls.Add(cmbProduction);
            tabPageRegister.Size = new Size(786, 420);
            tabPageRegister.Controls.SetChildIndex(cmbProduction, 0);
            tabPageRegister.Controls.SetChildIndex(txtId, 0);
            tabPageRegister.Controls.SetChildIndex(chkProducer, 0);
            tabPageRegister.Controls.SetChildIndex(txtAge, 0);
            tabPageRegister.Controls.SetChildIndex(txtName, 0);
            tabPageRegister.Controls.SetChildIndex(panel1, 0);
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(3, 361);
            panel1.Size = new Size(780, 56);
            // 
            // txtName
            // 
            txtName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtName.AnimateReadOnly = false;
            txtName.AutoCompleteMode = AutoCompleteMode.None;
            txtName.AutoCompleteSource = AutoCompleteSource.None;
            txtName.BackgroundImageLayout = ImageLayout.None;
            txtName.CharacterCasing = CharacterCasing.Normal;
            txtName.Depth = 0;
            txtName.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtName.HideSelection = true;
            txtName.Hint = "Name";
            txtName.LeadingIcon = null;
            txtName.Location = new Point(6, 38);
            txtName.Margin = new Padding(3, 2, 3, 2);
            txtName.MaxLength = 32767;
            txtName.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtName.Name = "txtName";
            txtName.PasswordChar = '\0';
            txtName.PrefixSuffixText = null;
            txtName.ReadOnly = false;
            txtName.RightToLeft = RightToLeft.No;
            txtName.SelectedText = "";
            txtName.SelectionLength = 0;
            txtName.SelectionStart = 0;
            txtName.ShortcutsEnabled = true;
            txtName.Size = new Size(538, 48);
            txtName.TabIndex = 5;
            txtName.TabStop = false;
            txtName.TextAlign = HorizontalAlignment.Left;
            txtName.TrailingIcon = null;
            txtName.UseSystemPasswordChar = false;
            // 
            // txtAge
            // 
            txtAge.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtAge.AnimateReadOnly = false;
            txtAge.AutoCompleteMode = AutoCompleteMode.None;
            txtAge.AutoCompleteSource = AutoCompleteSource.None;
            txtAge.BackgroundImageLayout = ImageLayout.None;
            txtAge.CharacterCasing = CharacterCasing.Normal;
            txtAge.Depth = 0;
            txtAge.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtAge.HideSelection = true;
            txtAge.Hint = "Age";
            txtAge.LeadingIcon = null;
            txtAge.Location = new Point(6, 101);
            txtAge.Margin = new Padding(3, 2, 3, 2);
            txtAge.MaxLength = 32767;
            txtAge.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtAge.Name = "txtAge";
            txtAge.PasswordChar = '\0';
            txtAge.PrefixSuffixText = null;
            txtAge.ReadOnly = false;
            txtAge.RightToLeft = RightToLeft.No;
            txtAge.SelectedText = "";
            txtAge.SelectionLength = 0;
            txtAge.SelectionStart = 0;
            txtAge.ShortcutsEnabled = true;
            txtAge.Size = new Size(538, 48);
            txtAge.TabIndex = 6;
            txtAge.TabStop = false;
            txtAge.TextAlign = HorizontalAlignment.Left;
            txtAge.TrailingIcon = null;
            txtAge.UseSystemPasswordChar = false;
            // 
            // chkProducer
            // 
            chkProducer.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            chkProducer.AutoSize = true;
            chkProducer.Depth = 0;
            chkProducer.Location = new Point(573, 112);
            chkProducer.Margin = new Padding(0);
            chkProducer.MouseLocation = new Point(-1, -1);
            chkProducer.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            chkProducer.Name = "chkProducer";
            chkProducer.Ripple = true;
            chkProducer.Size = new Size(121, 37);
            chkProducer.TabIndex = 7;
            chkProducer.Text = "Producer";
            chkProducer.UseAccentColor = false;
            chkProducer.UseVisualStyleBackColor = true;
            // 
            // txtId
            // 
            txtId.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtId.AnimateReadOnly = false;
            txtId.AutoCompleteMode = AutoCompleteMode.None;
            txtId.AutoCompleteSource = AutoCompleteSource.None;
            txtId.BackgroundImageLayout = ImageLayout.None;
            txtId.CharacterCasing = CharacterCasing.Normal;
            txtId.Depth = 0;
            txtId.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtId.HideSelection = true;
            txtId.Hint = "Id";
            txtId.LeadingIcon = null;
            txtId.Location = new Point(573, 38);
            txtId.Margin = new Padding(3, 2, 3, 2);
            txtId.MaxLength = 32767;
            txtId.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtId.Name = "txtId";
            txtId.PasswordChar = '\0';
            txtId.PrefixSuffixText = null;
            txtId.ReadOnly = true;
            txtId.RightToLeft = RightToLeft.No;
            txtId.SelectedText = "";
            txtId.SelectionLength = 0;
            txtId.SelectionStart = 0;
            txtId.ShortcutsEnabled = true;
            txtId.Size = new Size(173, 48);
            txtId.TabIndex = 11;
            txtId.TabStop = false;
            txtId.TextAlign = HorizontalAlignment.Left;
            txtId.TrailingIcon = null;
            txtId.UseSystemPasswordChar = false;
            // 
            // cmbProduction
            // 
            cmbProduction.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cmbProduction.AutoResize = false;
            cmbProduction.BackColor = Color.FromArgb(255, 255, 255);
            cmbProduction.Depth = 0;
            cmbProduction.DrawMode = DrawMode.OwnerDrawVariable;
            cmbProduction.DropDownHeight = 174;
            cmbProduction.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbProduction.DropDownWidth = 121;
            cmbProduction.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cmbProduction.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cmbProduction.FormattingEnabled = true;
            cmbProduction.Hint = "Production";
            cmbProduction.IntegralHeight = false;
            cmbProduction.ItemHeight = 43;
            cmbProduction.Location = new Point(6, 172);
            cmbProduction.MaxDropDownItems = 4;
            cmbProduction.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cmbProduction.Name = "cmbProduction";
            cmbProduction.Size = new Size(780, 49);
            cmbProduction.StartIndex = 0;
            cmbProduction.TabIndex = 12;
            // 
            // AnimalForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            ClientSize = new Size(800, 515);
            Location = new Point(0, 0);
            Name = "AnimalForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Animal";
            tabControlRegister.ResumeLayout(false);
            tabPageRegister.ResumeLayout(false);
            tabPageRegister.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtName;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtAge;
        private ReaLTaiizor.Controls.MaterialSwitch chkProducer;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtId;
        private ReaLTaiizor.Controls.MaterialComboBox cmbProduction;
    }
}
