namespace SGPL.App.Register
{
    partial class SaleForm
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
            txtId = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtUser = new ReaLTaiizor.Controls.MaterialComboBox();
            txtDateSale = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            groupBox1 = new GroupBox();
            lblValue = new ReaLTaiizor.Controls.MaterialLabel();
            lblQuantityItems = new ReaLTaiizor.Controls.MaterialLabel();
            btnAdd = new ReaLTaiizor.Controls.MaterialButton();
            txtTotalValue = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtQuantity = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtUnitValue = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtProduct = new ReaLTaiizor.Controls.MaterialComboBox();
            dataGridViewItems = new DataGridView();
            tabControlRegister.SuspendLayout();
            tabPageRegister.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewItems).BeginInit();
            SuspendLayout();
            // 
            // tabPageRegister
            // 
            tabPageRegister.Controls.Add(txtId);
            tabPageRegister.Controls.Add(txtUser);
            tabPageRegister.Controls.Add(txtDateSale);
            tabPageRegister.Controls.Add(groupBox1);
            tabPageRegister.Controls.SetChildIndex(groupBox1, 0);
            tabPageRegister.Controls.SetChildIndex(txtDateSale, 0);
            tabPageRegister.Controls.SetChildIndex(txtUser, 0);
            tabPageRegister.Controls.SetChildIndex(txtId, 0);
            tabPageRegister.Controls.SetChildIndex(panel1, 0);
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(3, 390);
            panel1.Size = new Size(780, 54);
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
            txtId.Location = new Point(625, 29);
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
            txtId.Size = new Size(107, 48);
            txtId.TabIndex = 1;
            txtId.TabStop = false;
            txtId.TextAlign = HorizontalAlignment.Left;
            txtId.TrailingIcon = null;
            txtId.UseSystemPasswordChar = false;
            // 
            // txtUser
            // 
            txtUser.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtUser.AutoResize = false;
            txtUser.BackColor = Color.FromArgb(255, 255, 255);
            txtUser.Depth = 0;
            txtUser.DrawMode = DrawMode.OwnerDrawVariable;
            txtUser.DropDownHeight = 174;
            txtUser.DropDownStyle = ComboBoxStyle.DropDownList;
            txtUser.DropDownWidth = 121;
            txtUser.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            txtUser.ForeColor = Color.FromArgb(222, 0, 0, 0);
            txtUser.Hint = "User";
            txtUser.IntegralHeight = false;
            txtUser.ItemHeight = 43;
            txtUser.Location = new Point(251, 29);
            txtUser.MaxDropDownItems = 4;
            txtUser.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(288, 49);
            txtUser.StartIndex = 0;
            txtUser.TabIndex = 2;
            // 
            // txtDateSale
            // 
            txtDateSale.AllowPromptAsInput = true;
            txtDateSale.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtDateSale.AnimateReadOnly = false;
            txtDateSale.AsciiOnly = false;
            txtDateSale.BackgroundImageLayout = ImageLayout.None;
            txtDateSale.BeepOnError = false;
            txtDateSale.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtDateSale.Depth = 0;
            txtDateSale.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtDateSale.HidePromptOnLeave = false;
            txtDateSale.HideSelection = true;
            txtDateSale.Hint = "DateSale";
            txtDateSale.InsertKeyMode = InsertKeyMode.Default;
            txtDateSale.LeadingIcon = null;
            txtDateSale.Location = new Point(22, 29);
            txtDateSale.Mask = "99/99/9999";
            txtDateSale.MaxLength = 32767;
            txtDateSale.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtDateSale.Name = "txtDateSale";
            txtDateSale.PasswordChar = '\0';
            txtDateSale.PrefixSuffixText = null;
            txtDateSale.PromptChar = '_';
            txtDateSale.ReadOnly = false;
            txtDateSale.RejectInputOnFirstFailure = false;
            txtDateSale.ResetOnPrompt = true;
            txtDateSale.ResetOnSpace = true;
            txtDateSale.RightToLeft = RightToLeft.No;
            txtDateSale.SelectedText = "";
            txtDateSale.SelectionLength = 0;
            txtDateSale.SelectionStart = 0;
            txtDateSale.ShortcutsEnabled = true;
            txtDateSale.Size = new Size(195, 48);
            txtDateSale.SkipLiterals = true;
            txtDateSale.TabIndex = 3;
            txtDateSale.TabStop = false;
            txtDateSale.Text = "  /  /";
            txtDateSale.TextAlign = HorizontalAlignment.Left;
            txtDateSale.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtDateSale.TrailingIcon = null;
            txtDateSale.UseSystemPasswordChar = false;
            txtDateSale.ValidatingType = null;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblValue);
            groupBox1.Controls.Add(lblQuantityItems);
            groupBox1.Controls.Add(btnAdd);
            groupBox1.Controls.Add(txtTotalValue);
            groupBox1.Controls.Add(txtQuantity);
            groupBox1.Controls.Add(txtUnitValue);
            groupBox1.Controls.Add(txtProduct);
            groupBox1.Controls.Add(dataGridViewItems);
            groupBox1.Location = new Point(-1, 84);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(781, 300);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Sale Products";
            // 
            // lblValue
            // 
            lblValue.Depth = 0;
            lblValue.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblValue.Location = new Point(444, 229);
            lblValue.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            lblValue.Name = "lblValue";
            lblValue.Size = new Size(159, 23);
            lblValue.TabIndex = 0;
            lblValue.Text = "Total Value: 0";
            // 
            // lblQuantityItems
            // 
            lblQuantityItems.Depth = 0;
            lblQuantityItems.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblQuantityItems.Location = new Point(5, 226);
            lblQuantityItems.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            lblQuantityItems.Name = "lblQuantityItems";
            lblQuantityItems.Size = new Size(100, 23);
            lblQuantityItems.TabIndex = 1;
            lblQuantityItems.Text = "Products: 0";
            // 
            // btnAdd
            // 
            btnAdd.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAdd.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnAdd.Depth = 0;
            btnAdd.HighEmphasis = true;
            btnAdd.Icon = null;
            btnAdd.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnAdd.Location = new Point(698, 25);
            btnAdd.Margin = new Padding(4, 6, 4, 6);
            btnAdd.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnAdd.Name = "btnAdd";
            btnAdd.NoAccentTextColor = Color.Empty;
            btnAdd.Size = new Size(64, 36);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "+";
            btnAdd.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnAdd.UseAccentColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtTotalValue
            // 
            txtTotalValue.AnimateReadOnly = false;
            txtTotalValue.AutoCompleteMode = AutoCompleteMode.None;
            txtTotalValue.AutoCompleteSource = AutoCompleteSource.None;
            txtTotalValue.BackgroundImageLayout = ImageLayout.None;
            txtTotalValue.CharacterCasing = CharacterCasing.Normal;
            txtTotalValue.Depth = 0;
            txtTotalValue.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtTotalValue.HideSelection = true;
            txtTotalValue.Hint = "Total Value";
            txtTotalValue.LeadingIcon = null;
            txtTotalValue.Location = new Point(562, 21);
            txtTotalValue.MaxLength = 32767;
            txtTotalValue.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtTotalValue.Name = "txtTotalValue";
            txtTotalValue.PasswordChar = '\0';
            txtTotalValue.PrefixSuffixText = null;
            txtTotalValue.ReadOnly = true;
            txtTotalValue.RightToLeft = RightToLeft.No;
            txtTotalValue.SelectedText = "";
            txtTotalValue.SelectionLength = 0;
            txtTotalValue.SelectionStart = 0;
            txtTotalValue.ShortcutsEnabled = true;
            txtTotalValue.Size = new Size(129, 48);
            txtTotalValue.TabIndex = 3;
            txtTotalValue.TabStop = false;
            txtTotalValue.TextAlign = HorizontalAlignment.Left;
            txtTotalValue.TrailingIcon = null;
            txtTotalValue.UseSystemPasswordChar = false;
            // 
            // txtQuantity
            // 
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
            txtQuantity.Location = new Point(372, 21);
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
            txtQuantity.Size = new Size(184, 48);
            txtQuantity.TabIndex = 4;
            txtQuantity.TabStop = false;
            txtQuantity.TextAlign = HorizontalAlignment.Left;
            txtQuantity.TrailingIcon = null;
            txtQuantity.UseSystemPasswordChar = false;
            // 
            // txtUnitValue
            // 
            txtUnitValue.AnimateReadOnly = false;
            txtUnitValue.AutoCompleteMode = AutoCompleteMode.None;
            txtUnitValue.AutoCompleteSource = AutoCompleteSource.None;
            txtUnitValue.BackgroundImageLayout = ImageLayout.None;
            txtUnitValue.CharacterCasing = CharacterCasing.Normal;
            txtUnitValue.Depth = 0;
            txtUnitValue.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtUnitValue.HideSelection = true;
            txtUnitValue.Hint = "Unit Value";
            txtUnitValue.LeadingIcon = null;
            txtUnitValue.Location = new Point(205, 22);
            txtUnitValue.MaxLength = 32767;
            txtUnitValue.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtUnitValue.Name = "txtUnitValue";
            txtUnitValue.PasswordChar = '\0';
            txtUnitValue.PrefixSuffixText = null;
            txtUnitValue.ReadOnly = false;
            txtUnitValue.RightToLeft = RightToLeft.No;
            txtUnitValue.SelectedText = "";
            txtUnitValue.SelectionLength = 0;
            txtUnitValue.SelectionStart = 0;
            txtUnitValue.ShortcutsEnabled = true;
            txtUnitValue.Size = new Size(161, 48);
            txtUnitValue.TabIndex = 5;
            txtUnitValue.TabStop = false;
            txtUnitValue.TextAlign = HorizontalAlignment.Left;
            txtUnitValue.TrailingIcon = null;
            txtUnitValue.UseSystemPasswordChar = false;
            // 
            // txtProduct
            // 
            txtProduct.AutoResize = false;
            txtProduct.BackColor = Color.FromArgb(255, 255, 255);
            txtProduct.Depth = 0;
            txtProduct.DrawMode = DrawMode.OwnerDrawVariable;
            txtProduct.DropDownHeight = 174;
            txtProduct.DropDownStyle = ComboBoxStyle.DropDownList;
            txtProduct.DropDownWidth = 121;
            txtProduct.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            txtProduct.ForeColor = Color.FromArgb(222, 0, 0, 0);
            txtProduct.Hint = "Product";
            txtProduct.IntegralHeight = false;
            txtProduct.ItemHeight = 43;
            txtProduct.Location = new Point(3, 21);
            txtProduct.MaxDropDownItems = 4;
            txtProduct.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtProduct.Name = "txtProduct";
            txtProduct.Size = new Size(196, 49);
            txtProduct.StartIndex = 0;
            txtProduct.TabIndex = 6;
            // 
            // dataGridViewItems
            // 
            dataGridViewItems.Location = new Point(0, 70);
            dataGridViewItems.Name = "dataGridViewItems";
            dataGridViewItems.ReadOnly = true;
            dataGridViewItems.Size = new Size(784, 151);
            dataGridViewItems.TabIndex = 7;
            // 
            // SaleForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            ClientSize = new Size(800, 542);
            Location = new Point(0, 0);
            Name = "SaleForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Sale";
            tabControlRegister.ResumeLayout(false);
            tabPageRegister.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewItems).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtId;
        private ReaLTaiizor.Controls.MaterialComboBox txtUser;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtDateSale;
        private GroupBox groupBox1;
        private ReaLTaiizor.Controls.MaterialLabel lblValue;
        private ReaLTaiizor.Controls.MaterialLabel lblQuantityItems;
        private ReaLTaiizor.Controls.MaterialButton btnAdd;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtTotalValue;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtQuantity;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtUnitValue;
        private ReaLTaiizor.Controls.MaterialComboBox txtProduct;
        private DataGridView dataGridViewItems;
    }
}
