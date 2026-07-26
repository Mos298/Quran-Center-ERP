using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace النظام_النهائي
{
    public partial class ucNotifications : UserControl
    {
        public string ConnectionString { get; set; }
        private List<Request> _allRequests;
        private Request _selectedRequest;

        public ucNotifications()
        {
            InitializeComponent();
        }

        public void LoadData()
        {
            _allRequests = new List<Request>();
            // This is where you would load real data from the database
            // For now, we use mock data to demonstrate functionality.
            LoadMockData();

            PopulateRequestList();
            // Show the placeholder panel by default
            pnlNoSelection.BringToFront();
            pnlDetails.Visible = false;
        }

        private void LoadMockData()
        {
            _allRequests.Add(new Request
            {
                Id = 1,
                Type = RequestType.StudentTransfer,
                Status = RequestStatus.Pending,
                SubjectName = "الطالب: علي محمد",
                InitiatorName = "الشيخ: خالد أحمد",
                RequestDate = DateTime.Now.AddDays(-1),
                Details = new Dictionary<string, string> { { "From", "مركز الهدى" }, { "To", "مركز النور" } }
            });
            _allRequests.Add(new Request
            {
                Id = 2,
                Type = RequestType.DataModification,
                Status = RequestStatus.Pending,
                SubjectName = "المحفظ: فاطمة علي",
                InitiatorName = "مدير النظام",
                RequestDate = DateTime.Now.AddHours(-5),
                Details = new Dictionary<string, string> { { "Field", "رقم الهاتف" }, { "OldValue", "091xxxxxxx" }, { "NewValue", "092xxxxxxx" } }
            });
            _allRequests.Add(new Request
            {
                Id = 3,
                Type = RequestType.StudentTransfer,
                Status = RequestStatus.Approved,
                SubjectName = "الطالب: عمر عبدالله",
                InitiatorName = "الشيخ: محمود سعيد",
                RequestDate = DateTime.Now.AddDays(-5),
                Details = new Dictionary<string, string> { { "From", "مركز البيان" }, { "To", "مركز الفرقان" } }
            });
        }

        /// <summary>
        /// Populates the side list with request items
        /// </summary>
        private void PopulateRequestList()
        {
            flpRequestsList.Controls.Clear();
            foreach (var request in _allRequests)
            {
                var itemControl = new RequestItemControl();
                itemControl.RequestData = request;
                itemControl.Click += RequestItem_Click; // Add click event
                flpRequestsList.Controls.Add(itemControl);
            }
        }

        /// <summary>
        /// Handles click on any request item in the list
        /// </summary>
        private void RequestItem_Click(object sender, EventArgs e)
        {
            var selectedControl = sender as RequestItemControl;
            if (selectedControl != null)
            {
                _selectedRequest = selectedControl.RequestData;
                DisplayRequestDetails();
            }
        }

        /// <summary>
        /// Displays the details of the currently selected request
        /// </summary>
        private void DisplayRequestDetails()
        {
            if (_selectedRequest == null) return;

            lblDetailTitle.Text = (_selectedRequest.Type == RequestType.StudentTransfer) ? "تفاصيل طلب نقل" : "تفاصيل طلب تعديل";
            lblDetailSubject.Text = _selectedRequest.SubjectName;
            lblDetailDate.Text = "تاريخ الطلب: " + _selectedRequest.RequestDate.ToString("yyyy/MM/dd");
            lblDetailInitiator.Text = "مقدم الطلب: " + _selectedRequest.InitiatorName;

            // Build the details string
            var detailsBuilder = new StringBuilder();
            detailsBuilder.AppendLine("تفاصيل الطلب:");
            foreach (var detail in _selectedRequest.Details)
            {
                detailsBuilder.AppendLine($"- {detail.Key}: {detail.Value}");
            }
            lblDetailsContent.Text = detailsBuilder.ToString();

            // Show/hide action buttons based on status
            bool isPending = _selectedRequest.Status == RequestStatus.Pending;
            btnApprove.Visible = isPending;
            btnReject.Visible = isPending;

            pnlDetails.BringToFront();
            pnlDetails.Visible = true;
        }

        private void btnApprove_Click(object sender, EventArgs e)
        {
            if (_selectedRequest != null)
            {
                // Here you would write code to update the database
                // For now, we update the mock data and refresh
                _selectedRequest.Status = RequestStatus.Approved;
                MessageBox.Show("تمت الموافقة على الطلب بنجاح.", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                PopulateRequestList(); // Refresh the list to show status change
                DisplayRequestDetails(); // Refresh the details view
            }
        }

        private void btnReject_Click(object sender, EventArgs e)
        {
            if (_selectedRequest != null)
            {
                // Here you would write code to update the database
                // For now, we update the mock data and refresh
                _selectedRequest.Status = RequestStatus.Rejected;
                MessageBox.Show("تم رفض الطلب.", "تم", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                PopulateRequestList();
                DisplayRequestDetails();
            }
        }
    }
}
