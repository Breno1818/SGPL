namespace SGPL.App.Register
{
    partial class FeedForm
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
            txtFeedType = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtQuantity = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            tabControlRegister.SuspendLayout();
            tabPageRegister.SuspendLayout();
            SuspendLayout();
            // 
            // tabControlRegister
            // 
            tabControlRegister.Size = new Size(800, 444);
            // 
            // tabPageRegister
            // 
            tabPageRegister.Controls.Add(txtId);
            tabPageRegister.Controls.Add(txtFeedType);
            tabPageRegister.Controls.Add(txtQuantity);
            tabPageRegister.Size = new Size(792, 416);
            tabPageRegister.Controls.SetChildIndex(txtQuantity, 0);
            tabPageRegister.Controls.SetChildIndex(txtFeedType, 0);
            tabPageRegister.Controls.SetChildIndex(txtId, 0);
            tabPageRegister.Controls.SetChildIndex(panel1, 0);
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(3, 363);
            panel1.Size = new Size(786, 50);
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
            txtId.Location = new Point(595, 49);
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
            txtId.Size = new Size(119, 48);
            txtId.TabIndex = 1;
            txtId.TabStop = false;
            txtId.TextAlign = HorizontalAlignment.Left;
            txtId.TrailingIcon = null;
            txtId.UseSystemPasswordChar = false;
            // 
            // txtFeedType
            // 
            txtFeedType.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtFeedType.AnimateReadOnly = false;
            txtFeedType.AutoCompleteMode = AutoCompleteMode.None;
            txtFeedType.AutoCompleteSource = AutoCompleteSource.None;
            txtFeedType.BackgroundImageLayout = ImageLayout.None;
            txtFeedType.CharacterCasing = CharacterCasing.Normal;
            txtFeedType.Depth = 0;
            txtFeedType.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtFeedType.HideSelection = true;
            txtFeedType.Hint = "FeedType";
            txtFeedType.LeadingIcon = null;
            txtFeedType.Location = new Point(30, 49);
            txtFeedType.MaxLength = 32767;
            txtFeedType.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtFeedType.Name = "txtFeedType";
            txtFeedType.PasswordChar = '\0';
            txtFeedType.PrefixSuffixText = null;
            txtFeedType.ReadOnly = false;
            txtFeedType.RightToLeft = RightToLeft.No;
            txtFeedType.SelectedText = "";
            txtFeedType.SelectionLength = 0;
            txtFeedType.SelectionStart = 0;
            txtFeedType.ShortcutsEnabled = true;
            txtFeedType.Size = new Size(550, 48);
            txtFeedType.TabIndex = 2;
            txtFeedType.TabStop = false;
            txtFeedType.TextAlign = HorizontalAlignment.Left;
            txtFeedType.TrailingIcon = null;
            txtFeedType.UseSystemPasswordChar = false;
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
            txtQuantity.Location = new Point(30, 129);
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
            txtQuantity.Size = new Size(550, 48);
            txtQuantity.TabIndex = 3;
            txtQuantity.TabStop = false;
            txtQuantity.TextAlign = HorizontalAlignment.Left;
            txtQuantity.TrailingIcon = null;
            txtQuantity.UseSystemPasswordChar = false;
            // 
            // FeedForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(806, 511);
            Location = new Point(0, 0);
            Name = "FeedForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Feed";
            tabControlRegister.ResumeLayout(false);
            tabPageRegister.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtId;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtFeedType;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtQuantity;
    }
}
