namespace SGPL.App.Register
{
    partial class ProductionForm
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
            txtProduct = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtQuantity = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            cmbFeedType = new ReaLTaiizor.Controls.MaterialComboBox();
            txtId = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            tabControlRegister.SuspendLayout();
            tabPageRegister.SuspendLayout();
            SuspendLayout();
            // 
            // tabControlRegister
            // 
            tabControlRegister.Size = new Size(794, 445);
            // 
            // tabPageRegister
            // 
            tabPageRegister.Controls.Add(txtId);
            tabPageRegister.Controls.Add(txtProduct);
            tabPageRegister.Controls.Add(txtQuantity);
            tabPageRegister.Controls.Add(cmbFeedType);
            tabPageRegister.Size = new Size(786, 417);
            tabPageRegister.Controls.SetChildIndex(cmbFeedType, 0);
            tabPageRegister.Controls.SetChildIndex(txtQuantity, 0);
            tabPageRegister.Controls.SetChildIndex(txtProduct, 0);
            tabPageRegister.Controls.SetChildIndex(panel1, 0);
            tabPageRegister.Controls.SetChildIndex(txtId, 0);
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(3, 360);
            panel1.Size = new Size(780, 54);
            // 
            // txtProduct
            // 
            txtProduct.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtProduct.AnimateReadOnly = false;
            txtProduct.AutoCompleteMode = AutoCompleteMode.None;
            txtProduct.AutoCompleteSource = AutoCompleteSource.None;
            txtProduct.BackgroundImageLayout = ImageLayout.None;
            txtProduct.CharacterCasing = CharacterCasing.Normal;
            txtProduct.Depth = 0;
            txtProduct.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtProduct.HideSelection = true;
            txtProduct.Hint = "Product";
            txtProduct.LeadingIcon = null;
            txtProduct.Location = new Point(32, 44);
            txtProduct.MaxLength = 32767;
            txtProduct.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtProduct.Name = "txtProduct";
            txtProduct.PasswordChar = '\0';
            txtProduct.PrefixSuffixText = null;
            txtProduct.ReadOnly = false;
            txtProduct.RightToLeft = RightToLeft.No;
            txtProduct.SelectedText = "";
            txtProduct.SelectionLength = 0;
            txtProduct.SelectionStart = 0;
            txtProduct.ShortcutsEnabled = true;
            txtProduct.Size = new Size(538, 48);
            txtProduct.TabIndex = 0;
            txtProduct.TabStop = false;
            txtProduct.TextAlign = HorizontalAlignment.Left;
            txtProduct.TrailingIcon = null;
            txtProduct.UseSystemPasswordChar = false;
            // 
            // txtQuantity
            // 
            txtQuantity.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtQuantity.AnimateReadOnly = false;
            txtQuantity.AutoCompleteMode = AutoCompleteMode.None;
            txtQuantity.AutoCompleteSource = AutoCompleteSource.None;
            txtQuantity.BackgroundImageLayout = ImageLayout.None;
            txtQuantity.CharacterCasing = CharacterCasing.Normal;
            txtQuantity.Depth = 0;
            txtQuantity.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtQuantity.HideSelection = true;
            txtQuantity.Hint = "Quantity";
            txtQuantity.LeadingIcon = null;
            txtQuantity.Location = new Point(32, 112);
            txtQuantity.MaxLength = 32767;
            txtQuantity.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtQuantity.Name = "txtQuantity";
            txtQuantity.PasswordChar = '\0';
            txtQuantity.PrefixSuffixText = null;
            txtQuantity.ReadOnly = false;
            txtQuantity.RightToLeft = RightToLeft.No;
            txtQuantity.SelectedText = "";
            txtQuantity.SelectionLength = 0;
            txtQuantity.SelectionStart = 0;
            txtQuantity.ShortcutsEnabled = true;
            txtQuantity.Size = new Size(538, 48);
            txtQuantity.TabIndex = 1;
            txtQuantity.TabStop = false;
            txtQuantity.TextAlign = HorizontalAlignment.Left;
            txtQuantity.TrailingIcon = null;
            txtQuantity.UseSystemPasswordChar = false;
            // 
            // cmbFeedType
            // 
            cmbFeedType.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cmbFeedType.AutoResize = false;
            cmbFeedType.BackColor = Color.FromArgb(255, 255, 255);
            cmbFeedType.Depth = 0;
            cmbFeedType.DrawMode = DrawMode.OwnerDrawVariable;
            cmbFeedType.DropDownHeight = 174;
            cmbFeedType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFeedType.DropDownWidth = 121;
            cmbFeedType.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cmbFeedType.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cmbFeedType.FormattingEnabled = true;
            cmbFeedType.Hint = "Feed Type";
            cmbFeedType.IntegralHeight = false;
            cmbFeedType.ItemHeight = 43;
            cmbFeedType.Location = new Point(32, 185);
            cmbFeedType.MaxDropDownItems = 4;
            cmbFeedType.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cmbFeedType.Name = "cmbFeedType";
            cmbFeedType.Size = new Size(538, 49);
            cmbFeedType.StartIndex = 0;
            cmbFeedType.TabIndex = 2;
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
            txtId.Location = new Point(602, 44);
            txtId.MaxLength = 32767;
            txtId.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtId.Name = "txtId";
            txtId.PasswordChar = '\0';
            txtId.PrefixSuffixText = null;
            txtId.ReadOnly = false;
            txtId.RightToLeft = RightToLeft.No;
            txtId.SelectedText = "";
            txtId.SelectionLength = 0;
            txtId.SelectionStart = 0;
            txtId.ShortcutsEnabled = true;
            txtId.Size = new Size(137, 48);
            txtId.TabIndex = 3;
            txtId.TabStop = false;
            txtId.TextAlign = HorizontalAlignment.Left;
            txtId.TrailingIcon = null;
            txtId.UseSystemPasswordChar = false;
            // 
            // ProductionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            ClientSize = new Size(800, 512);
            Location = new Point(0, 0);
            Name = "ProductionForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Production";
            tabControlRegister.ResumeLayout(false);
            tabPageRegister.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtProduct;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtQuantity;
        private ReaLTaiizor.Controls.MaterialComboBox cmbFeedType;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtId;
    }
}
