using SGPL.App.Base;
using SGPL.App.ViewModel;
using SGPL.Domain.Base;
using SGPL.Domain.Entities;
using SGPL.Service.Validators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SGPL.App.Register
{
    public partial class FeedForm : BaseForm
    {
        private readonly IBaseService<Feed> _feedService;
        private List<FeedViewModel>? feeds;

        public FeedForm(IBaseService<Feed> feedService)
        {
            _feedService = feedService;
            InitializeComponent();
            PopulateGrid();
        }

        private void FormToObject(Feed feed)
        {
            feed.FeedType = txtFeedType.Text;
            feed.Quantity = decimal.TryParse(txtQuantity.Text, out var quantity) ? quantity : 0;
        }

        protected override void Save()
        {
            try
            {
                if (IsEditMode)
                {
                    int.TryParse(txtId.Text, out int id);
                    var feed = _feedService.GetById<Feed>(id);
                    FormToObject(feed);
                    _feedService.Update<Feed, Feed, FeedValidator>(feed);
                }
                else
                {
                    var feed = new Feed();
                    FormToObject(feed);
                    _feedService.Add<Feed, Feed, FeedValidator>(feed);
                }
                PopulateGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"SGPL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void Delete(int id)
        {
            try
            {
                _feedService.Delete(id);
                PopulateGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"SGPL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void PopulateGrid()
        {
            feeds = _feedService.Get<FeedViewModel>().ToList();
            dataGridViewList.DataSource = feeds;
            if (dataGridViewList.Columns["FeedType"] != null)
                dataGridViewList.Columns["FeedType"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            if (dataGridViewList.Columns["Id"] != null)
                dataGridViewList.Columns["Id"].Visible = false;
        }

        protected override void GridToForm(DataGridViewRow? record)
        {
            if (record == null) return;
            txtId.Text = record.Cells["Id"].Value.ToString();
            txtFeedType.Text = record.Cells["FeedType"].Value.ToString();
            txtQuantity.Text = record.Cells["Quantity"].Value.ToString();
        }
    }
}
